namespace KnowledgeRepresentation.Forms
{
    partial class ActionsForm<T>
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabelDGV = new System.Windows.Forms.DataGridView();
            this.editColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelDGV
            // 
            this.tabelDGV.AllowUserToAddRows = false;
            this.tabelDGV.AllowUserToDeleteRows = false;
            this.tabelDGV.AllowUserToOrderColumns = true;
            this.tabelDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabelDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabelDGV.ColumnHeadersHeight = 25;
            this.tabelDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.editColumn,
            this.deleteColumn});
            this.tabelDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabelDGV.Location = new System.Drawing.Point(0, 111);
            this.tabelDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabelDGV.Name = "tabelDGV";
            this.tabelDGV.ReadOnly = true;
            this.tabelDGV.RowTemplate.Height = 26;
            this.tabelDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelDGV.Size = new System.Drawing.Size(403, 158);
            this.tabelDGV.TabIndex = 6;
            this.tabelDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelDGV_CellClick);
            // 
            // editColumn
            // 
            this.editColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editColumn.FillWeight = 50F;
            this.editColumn.Frozen = true;
            this.editColumn.HeaderText = "";
            this.editColumn.Image = global::KnowledgeRepresentation.Properties.Resources.edit_24;
            this.editColumn.Name = "editColumn";
            this.editColumn.ReadOnly = true;
            this.editColumn.Width = 50;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.deleteColumn.FillWeight = 50F;
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.Image = global::KnowledgeRepresentation.Properties.Resources.delete_24;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteColumn.Width = 50;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.titleTB);
            this.panel2.Location = new System.Drawing.Point(171, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(208, 25);
            this.panel2.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Title:";
            // 
            // titleTB
            // 
            this.titleTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.titleTB.Enabled = false;
            this.titleTB.Location = new System.Drawing.Point(51, 0);
            this.titleTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(157, 20);
            this.titleTB.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Image = global::KnowledgeRepresentation.Properties.Resources.cancel_24;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(299, 41);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 30);
            this.cancelBtn.TabIndex = 15;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::KnowledgeRepresentation.Properties.Resources.edit_24;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::KnowledgeRepresentation.Properties.Resources.delete_24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // newBtn
            // 
            this.newBtn.Image = global::KnowledgeRepresentation.Properties.Resources.add_24;
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtn.Location = new System.Drawing.Point(43, 41);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(80, 30);
            this.newBtn.TabIndex = 16;
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = global::KnowledgeRepresentation.Properties.Resources.save_24;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(171, 41);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 30);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ActionsForm
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(403, 269);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabelDGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ActionsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Actions";
            ((System.ComponentModel.ISupportInitialize)(this.tabelDGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.DataGridView tabelDGV;
        private System.Windows.Forms.DataGridViewImageColumn editColumn;
        private System.Windows.Forms.DataGridViewImageColumn deleteColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;

    }
}