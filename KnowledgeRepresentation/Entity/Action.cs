using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
  public class Action : SystemItem
    {
        public Action()
            : base()
        {

        }
        public Action( string name)
            : base(  name)
        {
        }
    }
}
