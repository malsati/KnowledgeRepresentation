using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Glee.Drawing;
using KnowledgeRepresentation.Entity;
using System.Collections;
namespace KnowledgeRepresentation.Forms
{
    public partial class QueriesForm : Form
    {
        private List<Entity.State> items;
        private Graph G;
        Entity.Query query;
        private Entity.Formula resultFormula;
        private Hashtable resultStatus;
        public QueriesForm()
        {
            InitializeComponent();
            items = Entity.AraSystem.GetInstance().States;
            G = new Graph("Graph");
            DrawGraph();
            query = new Entity.Query();
            resultFormula = new Formula();
            resultStatus = new Hashtable();
            actionsCmb.DataSource = Entity.AraSystem.GetInstance().Actions.ToArray();
            agentsCmb.DataSource = Entity.AraSystem.GetInstance().Agents.ToArray();
            formulaFluentsCmb.DataSource = Entity.AraSystem.GetInstance().Fluents.ToList();
 
            actionsCmb.SelectedIndex = -1;
            agentsCmb.SelectedIndex = -1;

        }
        private void DrawGraph()
        {
            G = new Graph("Graph");
            foreach (Entity.State state in items)
            {
               Node node = G.AddNode(state.ToString());
                if(state == AraSystem.GetInstance().InitState)
                {
                    node.Attr.Fillcolor = Microsoft.Glee.Drawing.Color.Aquamarine;
                }
                if (state.Color.HasValue)
                {
                    node.Attr.Color = state.Color.Value;
                }
            }

            foreach (Entity.State st in items)
            {
                foreach (Entity.Arc arc in st.Arcs)
                {
                    Edge edge= G.AddEdge(st.ToString(), arc.ToString(), arc.State.ToString());
                    if (arc.Color.HasValue)
                    {
                        edge.Attr.Color = arc.Color.Value;
                    }

                }
            }

            graphViewer.Graph = G;
        }

        private void setInitStateBtn_Click(object sender, EventArgs e)
        {
            new InitialStateForm().ShowDialog();
            if (Entity.AraSystem.GetInstance().InitState != null)
            {
                initStateTB.Text = Entity.AraSystem.GetInstance().InitState.ToString();
                DrawGraph();
            }
        }

        private void addActionBtn_Click(object sender, EventArgs e)
        {
            queryEP.Clear();
            if (actionsCmb.SelectedValue == null)
            {
                queryEP.SetError(actionsCmb, "choose Agent");
                return;
            }
            if (agentsCmb.SelectedValue == null)
            {
                queryEP.SetError(agentsCmb, "choose Agent");
                return;
            }

            query.AddAction((KnowledgeRepresentation.Entity.Action)actionsCmb.SelectedValue, (Agent)agentsCmb.SelectedValue);
            queryTB.Text = query.ToString();
        }

        private void removeActionBtn_Click(object sender, EventArgs e)
        {

            query.RemoveAction();
            queryTB.Text = query.ToString();
        }

        private void testQueryBtn_Click(object sender, EventArgs e)
        {
            if (AraSystem.GetInstance().InitState == null)
            {
                MessageBox.Show("Select the initai State First");
                return;
            }
            if (!resultFormula.IsValid)
            {
                MessageBox.Show("Invalid Formula");
                return;
            }
            query.QueryPossibility = possiblyRB.Checked ? Utility.QueryPossibility.Possibly : Utility.QueryPossibility.Necessary;
            query.ResultFormula = resultFormula;
            resultTB.Text =  query.Execute().ToString();
            DrawGraph();
        }

        private void addFormulaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (formulaFluentsCmb.SelectedValue == null) return;
                resultFormula.AddItem(formulaFluentsCmb.SelectedValue);
                formulaTB.Text = resultFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void notOperatorBtn_Click(object sender, EventArgs e)
        {

            try
            {
                resultFormula.AddItem(Entity.Utility.Operator.Not);
                formulaTB.Text = resultFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void andOperatorBtn_Click(object sender, EventArgs e)
        {

            try
            {
                resultFormula.AddItem(Entity.Utility.Operator.And);
                formulaTB.Text = resultFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void orOperatorBtn_Click(object sender, EventArgs e)
        {

            try
            {
                resultFormula.AddItem(Entity.Utility.Operator.OR);
                formulaTB.Text = resultFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void leftParenthesisBtn_Click(object sender, EventArgs e)
        {
            try
            {
                resultFormula.AddItem("(");
                formulaTB.Text = resultFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void rightParenthesisBtn_Click(object sender, EventArgs e)
        {

            try
            {
                resultFormula.AddItem(")");
                formulaTB.Text = resultFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void removeFormulaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                resultFormula.RemoveItem();
                formulaTB.Text = resultFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
