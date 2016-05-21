using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
   public class Utility
    {
        public enum Operation { New, Edit, None };
        public enum RuleEffect 
        { 
            Causes, 
            Release 
        };
        public enum FluentStatus { Positive, Negative };
        public enum Operator { Not, And, OR };
        public enum QueryPossibility { Necessary, Possibly };


        public static bool[] DecimalToBinary(int no, int size)
        {
            bool[] result = new bool[size];
            for (int i = size - 1; i >= 0 && no > 0; i--)
            {
                result[i] = (no % 2) == 1;
                no /= 2;
            }
            return result;
        }


        public static void Tester()
        {
            List<State> allStat = AraSystem.GetInstance().States;

            foreach (State s in allStat)
            {
                System.Diagnostics.Debug.WriteLine(String.Format("State {0} :",s.ToString()));
                foreach (Arc arc in s.Arcs)
                {
                    System.Diagnostics.Debug.WriteLine(String.Format("\t  {0} to {1}", arc.ToString(),arc.State.ToString()));                    
                }
            }
            /*Object[] expressions = value.ToArray();
            Array.Reverse(expressions, 0, expressions.Length);
            int counter = 0;
            Fluent[] allFluents = new Fluent[fluents.Count];
            foreach (Fluent f in fluents.Keys)
            {
                allFluents[counter] = f;
                counter++;
                System.Diagnostics.Debug.Write(f + "\t");
            }

            System.Diagnostics.Debug.Write("\n------------------------------\n");
            Hashtable[] test = getTruthTable();
            for (int i = 0; i < test.Length; i++)
            {
                Hashtable h = test[i];
                for (int j = 0; j < h.Count; j++)
                {
                    System.Diagnostics.Debug.Write(h[allFluents[j]] + "\t");
                }
                bool b = expressionValue(expressions, test[i]);
                System.Diagnostics.Debug.Write(">>>>  " + b);
                System.Diagnostics.Debug.Write("\n");
            }
             */
        }

    }

}
