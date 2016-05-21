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
    public partial class InitialStateForm : Form
    {
        public InitialStateForm()
        {
            InitializeComponent();
            statesCmb.DataSource = Entity.AraSystem.GetInstance().States;
            statesCmb.SelectedIndex = -1;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (statesCmb.SelectedValue == null)
            {
                MessageBox.Show("Choose the state first");
                return;
            }
            Entity.AraSystem.GetInstance().InitState = (Entity.State)statesCmb.SelectedValue;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
