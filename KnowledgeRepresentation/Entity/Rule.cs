using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
    public class Rule
    {
        private static int counter ;
        public Agent Agent { get; set; }
        public Action Action { get; set; }
        public Utility.RuleEffect Effect { get; set; }
        public int Id { get { return id; } }
        private int id;
        public Formula ResultFormula { get; set; }
        public Formula ConditionFormula { get; set; }
          public Rule()
        {
            id = counter++;
        }
     
    }
}
