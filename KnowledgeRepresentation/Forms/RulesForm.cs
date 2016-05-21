using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KnowledgeRepresentation.Forms
{
    public partial class RulesForm : Form
    {
        private Entity.AraSystem sysetm;
        Entity.Rule rule;
        private Entity.Formula resultFormula;
        private Entity.Formula conditionFormula;
        private RulesForm()
        {
            InitializeComponent();
        }
        public RulesForm(Entity.AraSystem sysetm):this()
        {
            this.sysetm = sysetm;
            resultFormula = new Entity.Formula();
            conditionFormula = new Entity.Formula();
            displayData();
            activateForm(false);
        }
        private void displayData()
        {
            actionsCmb.DataSource = sysetm.Actions.ToArray();
            agentsCmb.DataSource = sysetm.Agents.ToArray();
            formulaFluentsCmb.DataSource = sysetm.Fluents.ToArray();
            conditionFormulaFluentsCmb.DataSource = sysetm.Fluents.ToArray();
            effectsCmb.Items.Add(Entity.Utility.RuleEffect.Causes);
            effectsCmb.Items.Add(Entity.Utility.RuleEffect.Release);

            actionsCmb.SelectedIndex = -1;
            agentsCmb.SelectedIndex = -1;
            formulaFluentsCmb.SelectedIndex = -1;
            conditionFormulaFluentsCmb.SelectedIndex = -1;

            fillRulesTable();
        }

        private void fillRulesTable()
        {
            tabelDGV.DataSource = sysetm.Rules.ToArray();
            tabelDGV.Columns["Agent"].HeaderText = "Agent";
            tabelDGV.Columns["Action"].HeaderText = "Action";
            tabelDGV.Columns["Effect"].HeaderText = "Effect";
            tabelDGV.Columns["ResultFormula"].HeaderText = "Results";
            tabelDGV.Columns["ConditionFormula"].HeaderText = "Conditions";
            tabelDGV.Columns["Id"].Visible = false;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (rule == null) return;
            ruleEP.Clear();
            if (agentsCmb.SelectedValue == null)
            {
                ruleEP.SetError(agentsCmb, "Choose the Agent first");
                return;
            }

            if (actionsCmb.SelectedValue == null)
            {
                ruleEP.SetError(actionsCmb, "Choose the Action first");
                return;
            }

            if (effectsCmb.SelectedItem == null)
            {
                ruleEP.SetError(effectsCmb, "Choose the Effects first");
                return;
            }

            if (formulaTB.Text.Trim().Length==0)
            {
                ruleEP.SetError(formulaTB, "Create result first");
                return;
            }
            if (!resultFormula.IsValid)
            {
                ruleEP.SetError(formulaTB, "Invalid Formula");
                return;
            }

            if (conditionFormulaTB.Text.Trim().Length != 0)
            {
                if (!conditionFormula.IsValid)
                {
                    ruleEP.SetError(conditionFormulaTB, "Invalid Formula");
                    return;
                }
                rule.ConditionFormula = conditionFormula;
            }
            else
            {
                rule.ConditionFormula = null;
            }
            rule.Action = (Entity.Action)actionsCmb.SelectedValue;
            rule.Agent = (Entity.Agent)agentsCmb.SelectedValue;
            rule.Effect = (Entity.Utility.RuleEffect)effectsCmb.SelectedItem;
            rule.ResultFormula = resultFormula;
            sysetm.Rules.Add(rule);

            fillRulesTable();
            clearForm();
            activateForm(false);
        }

        private void clearForm()
        {
            actionsCmb.SelectedIndex = -1;
            agentsCmb.SelectedIndex = -1;
            formulaFluentsCmb.SelectedIndex = -1;
            conditionFormulaFluentsCmb.SelectedIndex = -1;
            effectsCmb.SelectedItem = null;
            conditionFormulaTB.Text = "";
            formulaTB.Text = "";
            resultFormula = new Entity.Formula();
            conditionFormula = new Entity.Formula();

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            saveBtn.Enabled = cancelBtn.Enabled = true;
            rule = new Entity.Rule();
            clearForm();
            activateForm(true);


        }

        private void activateForm(bool b)
        {
            actionsCmb.Enabled = agentsCmb.Enabled  = effectsCmb.Enabled = b;
            resultFormula = new Entity.Formula();
            conditionFormula = new Entity.Formula();

            saveBtn.Enabled=cancelBtn.Enabled = b;
            newBtn.Enabled = !b;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            rule = null;
            clearForm();
            activateForm(false);
        }

        private void tabelDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == -1) return;
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show("Are you Sure you want to delete this record", "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {

                   int id = (int)tabelDGV.Rows[e.RowIndex].Cells["Id"].Value;
                   Entity.Rule result = sysetm.FindRule(id);
                    if (result == null)
                    {
                        MessageBox.Show("An error has occure the item not found!");
                        return;
                    }
                    sysetm.Rules.Remove(result);
                    fillRulesTable();
                }
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


        private void addConditionFormulaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conditionFormulaFluentsCmb.SelectedValue == null) return;
                conditionFormula.AddItem(conditionFormulaFluentsCmb.SelectedValue);
                conditionFormulaTB.Text = conditionFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conditionNotOperatorBtn_Click(object sender, EventArgs e)
        {

            try
            {
                conditionFormula.AddItem(Entity.Utility.Operator.Not);
                conditionFormulaTB.Text = conditionFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conditionAndOperatorBtn_Click(object sender, EventArgs e)
        { 
            try
            {
                conditionFormula.AddItem(Entity.Utility.Operator.And);
                conditionFormulaTB.Text = conditionFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conditionOrOperatorBtn_Click(object sender, EventArgs e)
        {

            try
            {
                conditionFormula.AddItem(Entity.Utility.Operator.OR);
                conditionFormulaTB.Text = conditionFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conditionLeftParenthesisBtn_Click(object sender, EventArgs e)
        {

            try
            {
                conditionFormula.AddItem("(");
                conditionFormulaTB.Text = conditionFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conditionRightParenthesisBtn_Click(object sender, EventArgs e)
        {

            try
            {
                conditionFormula.AddItem(")");
                conditionFormulaTB.Text = conditionFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void conditionRemoveFormulaBtn_Click(object sender, EventArgs e)
        {

            try
            {
                conditionFormula.RemoveItem();
                conditionFormulaTB.Text = conditionFormula.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
