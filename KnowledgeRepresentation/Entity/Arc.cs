using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
  public class Arc
    {
        public Agent Agent { get; set; }
        public Action Action { get; set; }
        public State State { get; set; }
        public Microsoft.Glee.Drawing.Color? Color { get; set; }
        public Arc(Agent Agent, Action Action, State State)
        {
            this.Agent = Agent; 
            this.Action = Action; 
            this.State = State;
        }

        public override string ToString()
        {
            return String.Format("({0},{1})",Action.ToString(),Agent.ToString()) ;
        }
        public override bool Equals(object obj)
        {
            if (obj is Arc)
            {
                Arc arc = (Arc)obj;
                return arc.Action == Action && arc.Agent == Agent && arc.State == State;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
