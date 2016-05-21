using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using KnowledgeRepresentation.Entity;
using KnowledgeRepresentation.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
namespace KnowledgeRepresentation
{
    public partial class MainForm : Form
    {
        AraSystem system;
        public MainForm()
        {
            InitializeComponent();
            system = AraSystem.GetInstance();
        }

        private void manageAgentsBtn_Click(object sender, EventArgs e)
        {
            List<Entity.SystemItem> systemAgents = system.Agents.Cast<Entity.SystemItem>().ToList();
            new ActionsForm<Entity.Agent>(systemAgents, "Agents").ShowDialog();
            system.Agents = systemAgents.Cast<Entity.Agent>().ToList();
            displayList(agentsTB, systemAgents);
        }

        private void manageActionsBtn_Click(object sender, EventArgs e)
        {
            List<Entity.SystemItem> systemActions = system.Actions.Cast<Entity.SystemItem>().ToList();
            new ActionsForm<Entity.Action>(systemActions, "Actions").ShowDialog();
            system.Actions = systemActions.Cast<Entity.Action>().ToList();
            displayList(actionsTB, systemActions);
        }

        private void manageFluentsBtn_Click(object sender, EventArgs e)
        {
            List<Entity.SystemItem> systemFluents = system.Fluents.Cast<Entity.SystemItem>().ToList();
            new ActionsForm<Entity.Fluent>(systemFluents, "Fluents").ShowDialog();
            system.Fluents = systemFluents.Cast<Fluent>().ToList();
            displayList(fluentsTB, systemFluents);
        }
        private void displayList(TextBox display, List<Entity.SystemItem> items)
        {
            StringBuilder str = new StringBuilder();
            int counter = 1;
            foreach (Entity.SystemItem item in items)
            {
                str.Append(string.Format("{0}.{1}\t", counter++, item.Name));
            }
            display.Text = str.ToString();
        }

        private void rulesMangerBtn_Click(object sender, EventArgs e)
        {
            new Forms.RulesForm(system).ShowDialog();
            fillRulesTable();
        }
        private void fillRulesTable()
        {
            rulesDGV.DataSource = system.Rules.ToArray();
            rulesDGV.Columns["Agent"].HeaderText = "Agent";
            rulesDGV.Columns["Action"].HeaderText = "Action";
            rulesDGV.Columns["Effect"].HeaderText = "Effect";
            rulesDGV.Columns["ResultFormula"].HeaderText = "Results";
            rulesDGV.Columns["ConditionFormula"].HeaderText = "Conditions";
            rulesDGV.Columns["Id"].Visible = false;
        }
        private void ShowGraghBtn_Click(object sender, EventArgs e)
        {
            InitialStateForm gform = new InitialStateForm();
            gform.ShowDialog();

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
           
                system.Start();
                QueriesForm gform = new QueriesForm();
                gform.ShowDialog();
                Utility.Tester();
            try
            { }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Application.StartupPath;
            sfd.Filter = "Ara System (*.ara)|*.ara";
            DialogResult dr = sfd.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, system);
                stream.Close();
 
            }

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Application.StartupPath;
            ofd.Filter = "Ara System (*.ara)|*.ara";
            DialogResult dr = ofd.ShowDialog();
            if (dr != System.Windows.Forms.DialogResult.OK || ofd.FileName == null)
            {
                return;
            }
            try
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                system = (AraSystem)formatter.Deserialize(stream);
                AraSystem.LoadSystem(system);
                stream.Close();
                fillRulesTable();
                displayList(agentsTB, system.Agents.Cast<Entity.SystemItem>().ToList());
                displayList(actionsTB, system.Actions.Cast<Entity.SystemItem>().ToList());
                displayList(fluentsTB, system.Fluents.Cast<Entity.SystemItem>().ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void alwaysBtn_Click(object sender, EventArgs e)
        {
            new AlwaysForm().ShowDialog();
        }

    }
}
