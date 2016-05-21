using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
    public class Fluent : SystemItem
    {
        public Fluent()
            : base()
        {

        }
        public Fluent(string name)
            : base(name)
        {
        }


    }
}
