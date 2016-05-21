namespace KnowledgeRepresentation.Forms
{
    partial class AlwaysForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notOperatorBtn = new System.Windows.Forms.Button();
            this.orOperatorBtn = new System.Windows.Forms.Button();
            this.andOperatorBtn = new System.Windows.Forms.Button();
            this.removeFormulaBtn = new System.Windows.Forms.Button();
            this.rightParenthesisBtn = new System.Windows.Forms.Button();
            this.leftParenthesisBtn = new System.Windows.Forms.Button();
            this.formulaTB = new System.Windows.Forms.TextBox();
            this.addFormulaBtn = new System.Windows.Forms.Button();
            this.formulaFluentsCmb = new System.Windows.Forms.ComboBox();
            this.newBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.alwaysEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabelDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alwaysEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.notOperatorBtn);
            this.groupBox3.Controls.Add(this.orOperatorBtn);
            this.groupBox3.Controls.Add(this.andOperatorBtn);
            this.groupBox3.Controls.Add(this.removeFormulaBtn);
            this.groupBox3.Controls.Add(this.rightParenthesisBtn);
            this.groupBox3.Controls.Add(this.leftParenthesisBtn);
            this.groupBox3.Controls.Add(this.formulaTB);
            this.groupBox3.Controls.Add(this.addFormulaBtn);
            this.groupBox3.Controls.Add(this.formulaFluentsCmb);
            this.groupBox3.Location = new System.Drawing.Point(12, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 88);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Formula";
            // 
            // notOperatorBtn
            // 
            this.notOperatorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notOperatorBtn.Location = new System.Drawing.Point(231, 19);
            this.notOperatorBtn.Name = "notOperatorBtn";
            this.notOperatorBtn.Size = new System.Drawing.Size(59, 23);
            this.notOperatorBtn.TabIndex = 39;
            this.notOperatorBtn.Text = "Not";
            this.notOperatorBtn.UseVisualStyleBackColor = true;
            this.notOperatorBtn.Click += new System.EventHandler(this.notOperatorBtn_Click);
            // 
            // orOperatorBtn
            // 
            this.orOperatorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orOperatorBtn.Location = new System.Drawing.Point(360, 19);
            this.orOperatorBtn.Name = "orOperatorBtn";
            this.orOperatorBtn.Size = new System.Drawing.Size(59, 23);
            this.orOperatorBtn.TabIndex = 37;
            this.orOperatorBtn.Text = "OR";
            this.orOperatorBtn.UseVisualStyleBackColor = true;
            this.orOperatorBtn.Click += new System.EventHandler(this.orOperatorBtn_Click);
            // 
            // andOperatorBtn
            // 
            this.andOperatorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.andOperatorBtn.Location = new System.Drawing.Point(295, 19);
            this.andOperatorBtn.Name = "andOperatorBtn";
            this.andOperatorBtn.Size = new System.Drawing.Size(59, 23);
            this.andOperatorBtn.TabIndex = 38;
            this.andOperatorBtn.Text = "AND";
            this.andOperatorBtn.UseVisualStyleBackColor = true;
            this.andOperatorBtn.Click += new System.EventHandler(this.andOperatorBtn_Click);
            // 
            // removeFormulaBtn
            // 
            this.removeFormulaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removeFormulaBtn.Location = new System.Drawing.Point(559, 19);
            this.removeFormulaBtn.Name = "removeFormulaBtn";
            this.removeFormulaBtn.Size = new System.Drawing.Size(94, 23);
            this.removeFormulaBtn.TabIndex = 36;
            this.removeFormulaBtn.Text = "<<    remove";
            this.removeFormulaBtn.UseVisualStyleBackColor = true;
            this.removeFormulaBtn.Click += new System.EventHandler(this.removeFormulaBtn_Click);
            // 
            // rightParenthesisBtn
            // 
            this.rightParenthesisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rightParenthesisBtn.Location = new System.Drawing.Point(494, 19);
            this.rightParenthesisBtn.Name = "rightParenthesisBtn";
            this.rightParenthesisBtn.Size = new System.Drawing.Size(59, 23);
            this.rightParenthesisBtn.TabIndex = 35;
            this.rightParenthesisBtn.Text = ")";
            this.rightParenthesisBtn.UseVisualStyleBackColor = true;
            this.rightParenthesisBtn.Click += new System.EventHandler(this.rightParenthesisBtn_Click);
            // 
            // leftParenthesisBtn
            // 
            this.leftParenthesisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftParenthesisBtn.Location = new System.Drawing.Point(429, 19);
            this.leftParenthesisBtn.Name = "leftParenthesisBtn";
            this.leftParenthesisBtn.Size = new System.Drawing.Size(59, 23);
            this.leftParenthesisBtn.TabIndex = 35;
            this.leftParenthesisBtn.Text = " (";
            this.leftParenthesisBtn.UseVisualStyleBackColor = true;
            this.leftParenthesisBtn.Click += new System.EventHandler(this.leftParenthesisBtn_Click);
            // 
            // formulaTB
            // 
            this.formulaTB.BackColor = System.Drawing.Color.White;
            this.formulaTB.Location = new System.Drawing.Point(14, 58);
            this.formulaTB.Name = "formulaTB";
            this.formulaTB.ReadOnly = true;
            this.formulaTB.Size = new System.Drawing.Size(693, 20);
            this.formulaTB.TabIndex = 34;
            // 
            // addFormulaBtn
            // 
            this.addFormulaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addFormulaBtn.Location = new System.Drawing.Point(141, 19);
            this.addFormulaBtn.Name = "addFormulaBtn";
            this.addFormulaBtn.Size = new System.Drawing.Size(84, 23);
            this.addFormulaBtn.TabIndex = 32;
            this.addFormulaBtn.Text = "Add Fluent";
            this.addFormulaBtn.UseVisualStyleBackColor = true;
            this.addFormulaBtn.Click += new System.EventHandler(this.addFormulaBtn_Click);
            // 
            // formulaFluentsCmb
            // 
            this.formulaFluentsCmb.FormattingEnabled = true;
            this.formulaFluentsCmb.Location = new System.Drawing.Point(14, 19);
            this.formulaFluentsCmb.Name = "formulaFluentsCmb";
            this.formulaFluentsCmb.Size = new System.Drawing.Size(121, 21);
            this.formulaFluentsCmb.TabIndex = 28;
            // 
            // newBtn
            // 
            this.newBtn.Image = global::KnowledgeRepresentation.Properties.Resources.add_24;
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtn.Location = new System.Drawing.Point(12, 12);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(80, 30);
            this.newBtn.TabIndex = 40;
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Image = global::KnowledgeRepresentation.Properties.Resources.cancel_24;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(659, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 30);
            this.cancelBtn.TabIndex = 39;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Image = global::KnowledgeRepresentation.Properties.Resources.save_24;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(573, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 30);
            this.saveBtn.TabIndex = 38;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // alwaysEP
            // 
            this.alwaysEP.ContainerControl = this;
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
            this.dataGridViewImageColumn2});
            this.tabelDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabelDGV.Location = new System.Drawing.Point(0, 162);
            this.tabelDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabelDGV.Name = "tabelDGV";
            this.tabelDGV.ReadOnly = true;
            this.tabelDGV.RowTemplate.Height = 26;
            this.tabelDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelDGV.Size = new System.Drawing.Size(746, 158);
            this.tabelDGV.TabIndex = 41;
            this.tabelDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelDGV_CellClick);
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 50F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::KnowledgeRepresentation.Properties.Resources.delete_24;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 50;
            // 
            // AlwaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 320);
            this.Controls.Add(this.tabelDGV);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.groupBox3);
            this.Name = "AlwaysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Always";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alwaysEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button notOperatorBtn;
        private System.Windows.Forms.Button orOperatorBtn;
        private System.Windows.Forms.Button andOperatorBtn;
        private System.Windows.Forms.Button removeFormulaBtn;
        private System.Windows.Forms.Button rightParenthesisBtn;
        private System.Windows.Forms.Button leftParenthesisBtn;
        private System.Windows.Forms.TextBox formulaTB;
        private System.Windows.Forms.Button addFormulaBtn;
        private System.Windows.Forms.ComboBox formulaFluentsCmb;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ErrorProvider alwaysEP;
        protected System.Windows.Forms.DataGridView tabelDGV;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}