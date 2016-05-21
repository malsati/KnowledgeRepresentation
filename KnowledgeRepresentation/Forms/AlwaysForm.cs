using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KnowledgeRepresentation.Entity;
namespace KnowledgeRepresentation.Forms
{
    public partial class AlwaysForm : Form
    {
        AraSystem sysetm;
        Formula resultFormula;
        public AlwaysForm()
        {
            InitializeComponent();
            sysetm = AraSystem.GetInstance();
            
            if(
            sysetm.Always == null)
            {
                sysetm.Always = new List<Formula>();
            }
            resultFormula = new Formula();
            formulaFluentsCmb.DataSource = sysetm.Fluents.ToArray();
            tabelDGV.DataSource = sysetm.Always.ToList();
            tabelDGV.Columns["Label"].HeaderText = "Exprestion";
            tabelDGV.Columns["IsValid"].Visible = false; ;
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

        private void newBtn_Click(object sender, EventArgs e)
        {
            resultFormula = new Formula();
            formulaTB.Text = resultFormula.ToString();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            resultFormula = new Formula();
            formulaTB.Text = resultFormula.ToString();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            alwaysEP.Clear();
            if (formulaTB.Text.Trim().Length == 0)
            {
                alwaysEP.SetError(formulaTB, "Create result first");
                return;
            }
            if (!resultFormula.IsValid)
            {
                alwaysEP.SetError(formulaTB, "Invalid Formula");
                return;
            }

            sysetm.Always.Add(resultFormula);
            resultFormula = new Formula();
            formulaTB.Text = resultFormula.ToString();
            tabelDGV.DataSource = sysetm.Always.ToList();
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
                    sysetm.Always.RemoveAt(e.RowIndex);
                    tabelDGV.DataSource = sysetm.Always.ToList();
                    
                }
            }
        }
    }
}
