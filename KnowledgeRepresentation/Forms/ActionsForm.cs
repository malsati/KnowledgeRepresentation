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
    public partial class ActionsForm<T> : Form where T : Entity.SystemItem,new()
    {
        private List<Entity.SystemItem> items;
        private Entity.Utility.Operation operation;
        private Entity.SystemItem item;
        public ActionsForm(List<Entity.SystemItem> items, String formText)
        {
            InitializeComponent();
            this.items = items;
            this.Text = formText;

            fillData();
            operation = Entity.Utility.Operation.None;
        }

        private void fillData()
        {
            //tabelDGV.DataSource = null;
            tabelDGV.DataSource = items.ToArray();
            tabelDGV.Columns["Id"].Visible = false;
            tabelDGV.Columns["Name"].HeaderText = "Title";
            tabelDGV.Columns["IsUsed"].HeaderText = "Is Used";
            tabelDGV.Columns["Name"].FillWeight = 175;

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            operation = Entity.Utility.Operation.New;
            titleTB.Text = "";
            saveBtn.Enabled = cancelBtn.Enabled = titleTB.Enabled = true;
            newBtn.Enabled = false;
        }

        private void tabelDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.ColumnIndex == -1) return;
            if (tabelDGV.Columns[e.ColumnIndex]  == editColumn && e.RowIndex > -1)
            {
                operation = Entity.Utility.Operation.Edit;
                saveBtn.Enabled = cancelBtn.Enabled = titleTB.Enabled = true;
                newBtn.Enabled = false;
                string idStr  =tabelDGV.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                int id = int.Parse(idStr);
                item = getItemFromList(id);
                if (item == null)
                {
                    MessageBox.Show("An error has occure the item not found!");
                    return;
                }
                titleTB.Text = item.Name;
            }
            else if (tabelDGV.Columns[e.ColumnIndex] == deleteColumn && e.RowIndex > -1)
            {
                DialogResult dr = MessageBox.Show("Are you Sure you want to delete " + tabelDGV.Rows[e.RowIndex].Cells["Name"].Value.ToString(), "Warrning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    string idStr = tabelDGV.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                    int id = int.Parse(idStr);
                    item = getItemFromList(id);
                    if (item == null)
                    {
                        MessageBox.Show("An error has occure the item not found!");
                        return;
                    }
                    items.Remove(item);
                    fillData();
                    operation = Entity.Utility.Operation.None;
                    titleTB.Text = "";
                    saveBtn.Enabled = cancelBtn.Enabled= titleTB.Enabled = false;
                    newBtn.Enabled = true;
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (operation == Entity.Utility.Operation.None) return;
            if (operation == Entity.Utility.Operation.New)
            {
                if (titleTB.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Fill the field first");
                    return;
                }
                else if (isItemNameExist(titleTB.Text,-1))
                {
                    MessageBox.Show("The Item Alrady Exist!");
                    return;
                }
                item = new T(); //new Entity.Fluent(titleTB.Text);
                item.Name = titleTB.Text;
                items.Add(item); 
                fillData();
            }
            else if(operation == Entity.Utility.Operation.Edit)
            {

                if (titleTB.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Fill the field first");
                    return;
                }
                else if (isItemNameExist(titleTB.Text,item.Id))
                {
                    MessageBox.Show("The Item Alrady Exist!");
                    return;
                }
                item.Name = titleTB.Text;
                fillData();
            }
            titleTB.Text = "";
            saveBtn.Enabled = false;
            cancelBtn.Enabled = false;
            titleTB.Enabled = false;
            newBtn.Enabled = true;
            operation = Entity.Utility.Operation.None;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            titleTB.Text = "";
            saveBtn.Enabled = cancelBtn.Enabled = titleTB.Enabled = false;
            newBtn.Enabled = true;
            operation = Entity.Utility.Operation.None;
        }

        private Entity.SystemItem getItemFromList(int id)
        {
            foreach (Entity.SystemItem it in items)
            {
                if (it.Id == id)
                {
                    return it;
                }
            }
            return null;
        }
        private bool isItemNameExist(string name, int id)
        {
            foreach (Entity.SystemItem it in items)
            {
                if (it.Name.Equals(name) && it.Id!= id)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
