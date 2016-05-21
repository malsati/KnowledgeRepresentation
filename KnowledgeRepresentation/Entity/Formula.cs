using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnowledgeRepresentation.Entity
{
    [Serializable]
    public class Formula
    {
        public Formula()
        {
            value = new Stack<object>();
            fluents = new Hashtable();
        }
        private Stack<Object> value;
        public object[] Value { get { return value.ToArray(); } }
        public List<Hashtable> ResultStatesFluents { get; set; }
        private Hashtable fluents;
        bool IsUsed { get; set; }
        public string Label { get { return ToString(); } }
        private int fluentsCount;
        private int leftParenthesisCount;
        public bool IsValid
        {
            get
            {
                if (leftParenthesisCount != 0)
                {
                    return false;
                }
                try
                { 
                    int fluentsCount = fluents.Count; 
                    Hashtable expressionTester = new Hashtable();
                    Fluent[] allFluents = new Fluent[fluentsCount];  
                    foreach (Fluent f in fluents.Keys)
                    {
                        expressionTester.Add(f, true);
                    }

                    Object[] expression = value.ToArray();
                    Array.Reverse(expression, 0, expression.Length);
                    expressionValue(expression, expressionTester);
                }
                catch
                {
                    return false;
                }
                return true;
            }

        }
        public object LastObject()
        {
                if (value.Count == 0) return null;
                object obj = value.Pop();
                value.Push(obj);
                return obj;
            
        }
        public void AddItem(Object obj)
        {
            try
            {
                checkNewItem(obj);
                value.Push(obj);
                addFluent(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void addFluent(Object obj)
        {
            if (obj is Fluent)
            {
                fluentsCount++;
                if (fluents.Contains(obj))
                {
                    int val = (int)fluents[obj];
                    fluents[obj] = val++;
                }
                else
                {
                    fluents.Add(obj, 1);
                }
            }
        }
        public void RemoveItem()
        {
            if (value.Count == 0) return;
            object obj = value.Pop();
            if (obj.ToString().Equals("("))
            {
                leftParenthesisCount--;
            }
            else if (obj.ToString().Equals(")"))
            {
                leftParenthesisCount++;
            }
            removeFluent(obj);
        }

        private void removeFluent(object obj)
        {
            if (obj is Fluent)
            {
                fluentsCount--;
                if (fluents.Contains(obj))
                {
                    int val = (int)fluents[obj];
                    if (val == 1)
                    {
                        fluents.Remove(obj);
                    }
                    else
                    {
                        fluents[obj] = val--;
                    }
                }
            }
        }

        private void checkNewItem(object obj)
        {
            if (obj.ToString().Equals("("))
            {
                if (value.Count == 0)
                {
                    leftParenthesisCount++;
                    return;
                }
                object preObj = LastObject();
                if (preObj is Fluent || preObj.ToString().Equals(")"))
                {
                    throw new Exception("Left parenthesis cannot come directly afetr fluent or right parenthesis!");
                }
                leftParenthesisCount++;

            }
            else if (obj.ToString().Equals(")"))
            {
                if (leftParenthesisCount == 0)
                {
                    throw new Exception("Unbalanced parenthesis");
                }
                object preObj = LastObject();
                if (preObj is Utility.Operator)
                {
                    throw new Exception("Right parenthesis cannot come directly afetr Operator");
                }
                if (preObj.ToString().Equals("("))
                {
                    throw new Exception("Empty parenthesis");
                }
                leftParenthesisCount--;
            }
            else if (obj is Fluent)
            {
                object preObj = LastObject();
                if (preObj == null)
                {
                    return;
                }
                if (preObj is Fluent)
                {
                    throw new Exception("Fluent cannon follow fluent");
                }
                if (preObj.ToString().Equals(")"))
                {
                    throw new Exception("Fluent cannon follow Right parenthesis");
                }
            }
            else if (obj is Utility.Operator && ((Utility.Operator)obj == Utility.Operator.And || (Utility.Operator)obj == Utility.Operator.And))
            {
                object preObj = LastObject();
                if (preObj == null)
                {
                    throw new Exception("Cannon start with operator");
                }
                else if (preObj.ToString().Equals("("))
                {
                    throw new Exception("Operator cannon follow left parenthesis");
                }
                else if (preObj is Utility.Operator)
                {
                    throw new Exception("Operator cannon follow Operator");
                }
            }
            else if (obj is Utility.Operator && (Utility.Operator)obj == Utility.Operator.Not)
            {
                object preObj = LastObject();
                if (preObj == null)
                {
                    return;
                }
                else if (preObj.ToString().Equals(")"))
                {
                    throw new Exception("Not Operator cannon follow Right parenthesis");
                }
                else if (preObj is Utility.Operator)
                {
                    throw new Exception("Operator cannon follow Operator");
                }
                else if (preObj is Fluent)
                {
                    throw new Exception("Not Operator cannon follow Fluent");
                }
            }
        }
        public List<State> GetResultStates()
        {
            ResultStatesFluents = new List<Hashtable>();
            List<State> result = new List<State>();
            int fluentsCount = fluents.Count;
            int allPossibilities = (int)Math.Pow(2, fluentsCount);
            int counter = 0;

            Fluent[] allFluents = new Fluent[fluentsCount];
            Hashtable[] fluentsPossibilities = new Hashtable[allPossibilities];
            Hashtable fluentsState = null;
            bool[] state = null;


            foreach (Fluent f in fluents.Keys)
            {
                allFluents[counter] = f;
                counter++;
            }

            Object[] expression = value.ToArray();
            Array.Reverse(expression, 0, expression.Length);

            for (int i = 0; i < allPossibilities; i++)
            {
                state = Utility.DecimalToBinary(i, fluentsCount);
                fluentsState = new Hashtable();
                for (int j = 0; j < fluentsCount; j++)
                {
                    fluentsState.Add(allFluents[j], state[j]);
                }
                fluentsPossibilities[i] = fluentsState;
                bool b = expressionValue(expression, fluentsState);
                if (b)
                {
                    ResultStatesFluents.Add(fluentsState);
                    List<State> formulaRes = getState(fluentsState);
                    foreach (State resSt in formulaRes)
                    {
                        result.Add(resSt);
                    }
                }
            }

            return result;
        }
        public bool ExpresState(State s)
        {
            Object[] expression = value.ToArray();
            Array.Reverse(expression, 0, expression.Length);
            return expressionValue(expression, s.Fluents);
        }
        private List<State> getState(Hashtable fluentsState)
        {
            List<State> result = new List<State>();
            Hashtable fluents = null;
            List<State> states= AraSystem.GetInstance().States;
            for (int i = 0; i < states.Count; i++)
            {
                 fluents =  states[i].Fluents;
                 bool found = true;
                 foreach (Fluent f in fluentsState.Keys)
                 {
                     if ((bool)fluentsState[f] != (bool)fluents[f])
                     {
                         found = false;
                         break;
                     }
                 }
                 if (found)
                 {
                     result.Add(states[i]);
                 }
            }
            return result;
        }
        private bool expressionValue(object[] expression, Hashtable values)
        {
            bool leftOperant = false;
            bool rightOperant = false;
            object[] firstExpression = null;
            //object[] secondExpression = null;
            object[] operatorExpression = null;


            //when the expression is only fluent
            if (expression.Length == 1 && expression[0] is Fluent)
            {
                return (bool)values[expression[0]];
            }


            firstExpression = getNextExpression(expression);
            expression = removeNextExpression(expression );

            if (firstExpression.Length == 1 && firstExpression[0] is Utility.Operator)
            {
                firstExpression = getNextExpression(expression);
                expression = removeNextExpression(expression );
                leftOperant = !expressionValue(firstExpression, values);
            }
            else
            {
                leftOperant = expressionValue(firstExpression, values);
            }



            operatorExpression = getNextExpression(expression);
            if (operatorExpression == null)
            {
                return leftOperant;
            }
            expression = removeNextExpression(expression );
            //secondExpression = getNextExpression(expression);
            //expression = removeNextExpression(expression );
            rightOperant = expressionValue(expression, values);
            if (operatorExpression[0] is Utility.Operator && (Utility.Operator)operatorExpression[0] == Utility.Operator.And)
            {
                return leftOperant & rightOperant;
            }
            else if (operatorExpression[0] is Utility.Operator && (Utility.Operator)operatorExpression[0] == Utility.Operator.OR)
            {
                return leftOperant | rightOperant;

            }
            else
            {
                throw new Exception("Invalid Expression");
            }
        }
        private object[] getNextExpression(object[] expression)
        {
            if (expression.Length == 0)
            {
                return null;
            }
            object[] result = null;
            if (expression[0] is Fluent || expression[0] is Utility.Operator)
            {
                result = new object[1];
                result[0] = expression[0];
            }
            else if (expression[0].ToString().Equals("("))
            {
                int leftParentethes = 1;
                int counter = 1;
                while (leftParentethes != 0 & counter < expression.Length)
                {
                    if (expression[counter].ToString().Equals("("))
                    {
                        leftParentethes++;
                    }
                    else if (expression[counter].ToString().Equals(")"))
                    {
                        leftParentethes--;
                    }
                    counter++;
                }
                if (leftParentethes != 0)
                {
                    throw new Exception("Invalid Expression");
                }
                result = new object[counter - 2];
                Array.Copy(expression, 1, result, 0, counter - 2);
            }
            else
            {
                throw new Exception("Invalid Expression");
            }

            return result;
        }
        private object[] removeNextExpression(object[] expression )
        {

            object[] result = null;
            if (expression[0] is Fluent || expression[0] is Utility.Operator)
            {
                result = new object[expression.Length-1];
                Array.Copy(expression, 1, result, 0, expression.Length-1);
            }
            else if (expression[0].ToString().Equals("("))
            {
                int leftParentethes = 1;
                int counter = 1;
                while (leftParentethes != 0 & counter < expression.Length)
                {
                    if (expression[counter].ToString().Equals("("))
                    {
                        leftParentethes++;
                    }
                    else if (expression[counter].ToString().Equals(")"))
                    {
                        leftParentethes--;
                    }
                    counter++;
                }
                if (leftParentethes != 0)
                {
                    throw new Exception("Invalid Expression");
                }
                result = new object[expression.Length - counter];
                Array.Copy(expression, counter, result, 0, expression.Length - counter);
            }
            else
            {
                throw new Exception("Invalid Expression");
            }
            return result;
           /* if (expression.Length - length < 0)
            {
                return null;
            }
            object[] result = new object[expression.Length - length];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = expression[i + length];
            }
            return result;*/
        }

        public override string ToString()
        {
            Object[] list = value.ToArray();
            StringBuilder result = new StringBuilder();
            for (int i = list.Length - 1; i >= 0; i--)
            {
                string str = list[i].ToString();
                if (list[i] is Utility.Operator)
                {
                    switch ((Utility.Operator)list[i])
                    {
                        case Utility.Operator.OR: str = "∨"; break;
                        case Utility.Operator.And: str = "^"; break;
                        case Utility.Operator.Not: str = "¬"; break;
                        default: break;
                    }
                }
                result.Append(str + " ");
            }
            return result.ToString();
        }

        public void AndFormula(Formula f)
        {
            Stack<Object> newValue = new Stack<object>();
            newValue.Push("(");
            for (int i = Value.Length - 1; i >= 0; i--)
            {
                newValue.Push(Value[i]);
            }
            newValue.Push(")");
            newValue.Push(Utility.Operator.And);


            object[] secondValue = f.Value;
            newValue.Push("(");
            for (int i = secondValue.Length - 1; i >= 0; i--)
            {
                newValue.Push(secondValue[i]);
            }
            newValue.Push(")");
            value = newValue;
            foreach (Fluent fl in f.fluents.Keys)
            {
                if (!fluents.Contains(fl))
                {
                    fluents.Add(fl, 1);
                    fluentsCount++;
                }
            }
        }

        public void AndFormulaWithNot(Formula f)
        {
            Stack<Object> newValue = new Stack<object>();
            newValue.Push("(");
            for (int i = Value.Length - 1; i >= 0; i--)
            {
                newValue.Push(Value[i]);
            }
            newValue.Push(")");



            object[] secondValue = f.Value;

            newValue.Push(Utility.Operator.And);
            newValue.Push("(");
                newValue.Push("(");
                    for (int i = secondValue.Length - 1; i >= 0; i--)
                    {
                        newValue.Push(secondValue[i]);
                    }
                newValue.Push(")");
                newValue.Push(Utility.Operator.OR);
                newValue.Push("(");
                    newValue.Push(Utility.Operator.Not);
                    newValue.Push("(");
                        for (int i = secondValue.Length - 1; i >= 0; i--)
                        {
                            newValue.Push(secondValue[i]);
                        }
                    newValue.Push(")");
                newValue.Push(")");
            newValue.Push(")");
            value = newValue;
            foreach (Fluent fl in f.fluents.Keys)
            {
                if (!fluents.Contains(fl))
                {
                    fluents.Add(fl, 1);
                    fluentsCount++;
                }
            }
        }

        internal Formula CloneWithNot()
        {
            Formula newF = new Formula();
            Stack<Object> newValue = new Stack<object>();
            newValue.Push(Utility.Operator.Not);
            newValue.Push("(");
            for (int i = Value.Length - 1; i >= 0; i--)
            {
                newValue.Push(Value[i]);
            }
            newValue.Push(")");

            newF.value = newValue;
            Hashtable newFormulaFluents = new Hashtable();
            foreach (object key in fluents.Keys)
            {
                newFormulaFluents.Add(key, fluents[key]);
            }
            newF.fluents = newFormulaFluents;
            newF.fluentsCount = fluentsCount;

            return newF;
        }
        internal Formula Clone()
        {
            Formula newF = new Formula();
            Stack<Object> newValue = new Stack<object>();
            for (int i = Value.Length - 1; i >= 0; i--)
            {
                newValue.Push(Value[i]);
            }

            newF.value = newValue;
            Hashtable newFormulaFluents = new Hashtable();
            foreach (object key in fluents.Keys)
            {
                newFormulaFluents.Add(key, fluents[key]);
            }
            newF.fluents = newFormulaFluents;
            newF.fluentsCount = fluentsCount;

            return newF;
        }
    }
}
