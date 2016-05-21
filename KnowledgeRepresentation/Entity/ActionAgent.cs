using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
   public class ActionAgent
    {
        public Action Action { get; set; }
        public Agent Agent { get; set; }
        public ActionAgent(Action action, Agent agent)
        {
            this.Action = action;
            this.Agent = agent;
        }
        public override string ToString()
        {
            return string.Format("({0},{1})", this.Action.ToString(), this.Agent.ToString());
        }
    }
}
