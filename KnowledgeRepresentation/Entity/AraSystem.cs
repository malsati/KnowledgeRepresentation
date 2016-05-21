using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
  public  class AraSystem
    {
     public List<Action> Actions { get; set; }
     public List<Agent> Agents { get; set; }
     public List<Fluent> Fluents { get; set; }
     public List<Rule> Rules { get; set; }
     public List<Formula> Always { get; set; }
     public List<State> States { get { return states; } }
     public State InitState { get; set; }
     private List<State> states;
     private static AraSystem araSystem;
     private AraSystem()
     {
         Actions = new List<Action>();
         Agents = new List<Agent>();
         Fluents = new List<Fluent>();
         Rules = new List<Rule>();
         Always = new List<Formula>();
     }
     public static AraSystem GetInstance()
     {
         if (araSystem == null)
         {
             araSystem = new AraSystem();
         }
         return araSystem;
     }
     internal Rule FindRule(int id)
     {
         foreach (Rule r in Rules)
         {
             if (r.Id == id) return r;
         }
         return null;
     }
     private void findAllStates()
     {
         int n = Fluents.Count;
         int NumOfStates = (int)Math.Pow(2, n);
         List<State> AllStates = new List<State>();
         Fluent[] allFluents = Fluents.ToArray();
         for (int i = 0; i < NumOfStates; i++)
         {
             bool[] fluentsSign = Utility.DecimalToBinary(i, n);
             Hashtable stateFluents = new Hashtable();
             for (int j = 0; j < n; j++)
             {
                 stateFluents.Add(allFluents[j], fluentsSign[j]);
             }
             AllStates.Add(new State(stateFluents));
         }
         this.states = AllStates;
         if (Always != null) { 
         foreach (Formula f in Always)
         {
             List<State> newState = f.GetResultStates();
             this.states = newState;
         }
         }
     }
     public void Start()
     {
         findAllStates();
         InitState = null;
         List<Rule> newRelesedFRuls = new List<Rule>();
         foreach (Rule r in Rules)
         {
             if (r.Effect == Utility.RuleEffect.Release)
             {
                 Rule newR = new Rule();
                 newR.Action = r.Action;
                 newR.Agent = r.Agent;
                 newR.Effect = r.Effect;
                 if(r.ConditionFormula != null)newR.ConditionFormula = r.ConditionFormula.Clone();
                 newR.ResultFormula = r.ResultFormula.CloneWithNot();
                 newRelesedFRuls.Add(newR);
             }
         }
         foreach (Rule r in newRelesedFRuls)
         {
             Rules.Add(r);
         }
         foreach (State s in States)
         {
             Hashtable stateRules = new Hashtable();
             foreach (Rule r in Rules)
             {

                 if (r.ConditionFormula != null && !r.ConditionFormula.GetResultStates().Contains(s))
                 {
                     s.AddArc(new Arc(r.Agent, r.Action, s) );
                     continue;
                 }
                 string ruleStr = r.Action.ToString() + "_" + r.Agent.ToString();

                 if (stateRules.Contains(ruleStr))
                 {
                     Rule f = (Rule)stateRules[ruleStr];
                     f.ResultFormula.AndFormula(r.ResultFormula);
                 }
                 else
                 {
                     Rule newRule = new Rule();
                     newRule.Agent = r.Agent;
                     newRule.Action = r.Action;
                     newRule.ResultFormula = r.ResultFormula.Clone();
                     stateRules[ruleStr] = newRule;
                 }
             }
             int breake = 0;
             foreach (Rule releasedR in Rules)
             {
                 if (releasedR.Effect == Utility.RuleEffect.Causes || releasedR.ConditionFormula != null && !releasedR.ConditionFormula.GetResultStates().Contains(s))
                 {
                     continue;
                 }
                 int count = 0;
                 string ruleStr = releasedR.Action.ToString() + "_" + releasedR.Agent.ToString() + "_" + releasedR.ResultFormula.ToString();
                 foreach (Rule r in Rules)
                 {
                     if (r == releasedR || r.Agent != releasedR.Agent|| r.Action != releasedR.Action || (r.ConditionFormula != null && !r.ConditionFormula.GetResultStates().Contains(s)))
                     {
                         continue;
                     }
                     count++;

                     if (stateRules.Contains(ruleStr))
                     {
                         Rule f = (Rule)stateRules[ruleStr];
                         f.ResultFormula.AndFormula(r.ResultFormula);
                     }
                     else
                     {
                         Rule newRule = new Rule();
                         newRule.Agent = r.Agent;
                         newRule.Action = r.Action;
                         newRule.ResultFormula = r.ResultFormula.Clone();
                         stateRules[ruleStr] = newRule;
                     }
                 }

                 if (count==0)
                 {
                     s.AddArc(new Arc(releasedR.Agent, releasedR.Action, s));
                 }


             }
             breake = 0;
             foreach (Rule r in stateRules.Values)
             {                 
                 List<State> stetes = r.ResultFormula.GetResultStates();

                 //empty effects
                 if (stetes.Contains(s) )
                 {
                     s.AddArc(new Arc(r.Agent, r.Action, s));
                     continue;
                 }
                 //Self loop for for release  
                 if (r.Effect == Utility.RuleEffect.Release)
                 {
                     s.AddArc(new Arc(r.Agent, r.Action, s));
                 }
                 //Calculate the New function
                 Hashtable newStates = NewFunction(s, stetes);
                 //Calculate the Min result
                 List<State> minStates = findMinRes(newStates);
                 foreach (State resSt in minStates)
                 {
                     s.AddArc(new Arc(r.Agent, r.Action, resSt));
                 }
             }
         }


         foreach (Rule r in newRelesedFRuls)
         {
             Rules.Remove(r);
         }
     }
     private List<State> findMinRes(Hashtable newStates)
     {
         List<State> minStates = new List<State>();
         foreach (State st in newStates.Keys)
         {
             bool isMin = true;
             foreach (State subSt in newStates.Keys)
             {
                 if (subSt == st)
                 {
                     continue;
                 }
                 if (isSubset((Hashtable)newStates[subSt], (Hashtable)newStates[st]))
                 {
                     isMin = false;
                     break;
                 }
             }
             if (isMin)
             {
                 minStates.Add(st);
             }
         }
         return minStates;
     }
     private Hashtable NewFunction(State s,List<State> stetes)
     {
         Hashtable newStates = new Hashtable();
         Hashtable newStatesFluents;
         foreach (State st in stetes)
         {
             newStatesFluents = new Hashtable();
             foreach (Fluent f in st.Fluents.Keys)
             {
                 object obj = s.Fluents[f];
                 if ((bool)s.Fluents[f] != (bool)st.Fluents[f])
                 {
                     newStatesFluents.Add(f, (bool)st.Fluents[f]);
                 }
             }
             newStates.Add(st, newStatesFluents);
         }
         return newStates;
     }
     private bool isSubset(Hashtable setA, Hashtable setB)
     { 
         foreach (Fluent f in setA.Keys)
         {
             if (!setB.Contains(f) || (bool)setA[f] != (bool)setB[f])
             {
                 return false;
             }
         }
         return true;
     }



     internal static void LoadSystem(AraSystem system)
     {
         araSystem = system;
     }
    }
}
