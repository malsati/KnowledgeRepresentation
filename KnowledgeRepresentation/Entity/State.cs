using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
    public class State 
    {
        public Hashtable Fluents { get; set; }
        public List<Arc> Arcs { get { return arcs; } }
        private List<Arc> arcs;
        public Microsoft.Glee.Drawing.Color? Color { get; set; }
        public State()
        {
            Fluents = new Hashtable();
            arcs = new List<Arc>();
        }
        public State(Hashtable Fluents)
        {
            this.Fluents = Fluents;
            arcs = new List<Arc>();
        }
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            foreach (Fluent f in Fluents.Keys)
            {
                if (!((bool)Fluents[f]))
                {
                    str.Append("¬");
                }
                str.Append(f.ToString());
                str.Append(", ");
            }
            if (str.Length > 2)
            {
                str.Remove(str.Length - 2, 2);
            }
            return str.ToString();
        }

        public void AddArc(Arc arc)
        {
            if (!HasArc(arc))
            {
                arcs.Add(arc);
            }
        }
        private bool HasArc(Arc arc)
        {
            foreach (Arc a in arcs)
            {
                if(a.Equals(arc)) return true;
            }
            return false;
        }
    }
}
