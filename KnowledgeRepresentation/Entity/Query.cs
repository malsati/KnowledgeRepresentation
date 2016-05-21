using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    public class Query
    {
        private List<ActionAgent> actions;
        public Hashtable ResultFluents { get; set; }
        public Utility.QueryPossibility QueryPossibility { get; set; }
        public Formula ResultFormula { get; set; }
        public Query()
        {
            actions = new List<ActionAgent>();
        }

        public void AddAction(Action action, Agent agent)
        {
            actions.Add(new ActionAgent(action, agent));
        }
        public void RemoveAction()
        {
            if (actions.Count > 0)
            {
                actions.Remove(actions[actions.Count - 1]);
            }
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < actions.Count; i++)
            {
                str.Append(actions[i].ToString() + ", ");
            }
            if (str.Length > 2)
            {
                str.Remove(str.Length - 2, 2);
            }
            return str.ToString();
        }
        private void clearColor()
        {
            foreach (State s in AraSystem.GetInstance().States)
            {
                s.Color = null;
                foreach (Arc r in s.Arcs)
                {
                    r.Color = null;
                }
            }
        }
        internal bool Execute()
        {
            clearColor();
            Stack<QueryState> routes = new Stack<QueryState>();
            routes.Push(new QueryState(AraSystem.GetInstance().InitState, actions.ToList()));
            List<State> result = new List<State>();
            while (routes.Count > 0)
            {
                QueryState queryState = routes.Pop();
                ActionAgent acg = queryState.GetNextActionAgent();
                if (acg == null)
                {
                    result.Add(queryState.State);
                    continue;
                }
                foreach (Arc arc in queryState.State.Arcs)
                {
                    if (arc.Action == acg.Action && arc.Agent == acg.Agent)
                    {
                        arc.Color = Microsoft.Glee.Drawing.Color.Red;
                        routes.Push(new QueryState(arc.State, queryState.GetNextRoute()));
                    }
                }
            }
            List<State> wantedResultStates= ResultFormula.GetResultStates();
            
            bool isFound = true;
            foreach (State s in result)
            {
                s.Color = Microsoft.Glee.Drawing.Color.Violet;
                isFound = ResultFormula.ExpresState(s);
                if (QueryPossibility == Utility.QueryPossibility.Necessary && !isFound)
                {
                    s.Color = Microsoft.Glee.Drawing.Color.Yellow;
                    return false;
                }
                if (QueryPossibility == Utility.QueryPossibility.Possibly && isFound)
                {
                    s.Color = Microsoft.Glee.Drawing.Color.Green;
                    return true;
                }
            }
            return isFound;
        }
    }
}
