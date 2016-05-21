using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
   public class QueryState
    {
        public State State { get; set; }
        public List<ActionAgent> Route { get; set; }

        public ActionAgent GetNextActionAgent()
        {
            if (Route.Count == 0)
            {
                return null;
            }
            return Route[0];            
        }

        public List<ActionAgent> GetNextRoute()
        {
            List<ActionAgent> newRoute = Route.ToList();
            if (newRoute.Count>0)
            {
                newRoute.Remove(newRoute[0]);
            }
            return newRoute;
        }
        public QueryState(State state, List<ActionAgent> route)
        {
            this.State = state;
            this.Route = route;
        }
    }
}
