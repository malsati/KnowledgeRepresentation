using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
    public class Agent : SystemItem
    {
        public Agent()
            : base()
        {

        }
        public Agent(string name)
            : base(name)
        {
        }
    }
}
