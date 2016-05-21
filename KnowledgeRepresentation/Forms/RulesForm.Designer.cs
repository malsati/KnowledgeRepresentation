namespace KnowledgeRepresentation.Forms
{
    partial class RulesForm
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
            this.newBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.agentsCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionsCmb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.effectsCmb = new System.Windows.Forms.ComboBox();
            this.tabelDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.ruleEP = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conditionNotOperatorBtn = new System.Windows.Forms.Button();
            this.conditionOrOperatorBtn = new System.Windows.Forms.Button();
            this.conditionAndOperatorBtn = new System.Windows.Forms.Button();
            this.conditionRemoveFormulaBtn = new System.Windows.Forms.Button();
            this.conditionRightParenthesisBtn = new System.Windows.Forms.Button();
            this.conditionLeftParenthesisBtn = new System.Windows.Forms.Button();
            this.conditionFormulaTB = new System.Windows.Forms.TextBox();
            this.addConditionFormulaBtn = new System.Windows.Forms.Button();
            this.conditionFormulaFluentsCmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabelDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newBtn
            // 
            this.newBtn.Image = global::KnowledgeRepresentation.Properties.Resources.add_24;
            this.newBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newBtn.Location = new System.Drawing.Point(12, 12);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(80, 30);
            this.newBtn.TabIndex = 19;
            this.newBtn.Text = "New";
            this.newBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.newBtn.UseVisualStyleBackColor = true;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Enabled = false;
            this.cancelBtn.Image = global::KnowledgeRepresentation.Properties.Resources.cancel_24;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(665, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 30);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Enabled = false;
            this.saveBtn.Image = global::KnowledgeRepresentation.Properties.Resources.save_24;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(579, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(80, 30);
            this.saveBtn.TabIndex = 17;
            this.saveBtn.Text = "Save";
            this.saveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // agentsCmb
            // 
            this.agentsCmb.FormattingEnabled = true;
            this.agentsCmb.Location = new System.Drawing.Point(63, 54);
            this.agentsCmb.Name = "agentsCmb";
            this.agentsCmb.Size = new System.Drawing.Size(121, 21);
            this.agentsCmb.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Agent:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(304, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Action:";
            // 
            // actionsCmb
            // 
            this.actionsCmb.FormattingEnabled = true;
            this.actionsCmb.Location = new System.Drawing.Point(355, 54);
            this.actionsCmb.Name = "actionsCmb";
            this.actionsCmb.Size = new System.Drawing.Size(121, 21);
            this.actionsCmb.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(561, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "Effect:";
            // 
            // effectsCmb
            // 
            this.effectsCmb.FormattingEnabled = true;
            this.effectsCmb.Location = new System.Drawing.Point(625, 54);
            this.effectsCmb.Name = "effectsCmb";
            this.effectsCmb.Size = new System.Drawing.Size(121, 21);
            this.effectsCmb.TabIndex = 24;
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
            this.tabelDGV.Location = new System.Drawing.Point(0, 288);
            this.tabelDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabelDGV.Name = "tabelDGV";
            this.tabelDGV.ReadOnly = true;
            this.tabelDGV.RowTemplate.Height = 26;
            this.tabelDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelDGV.Size = new System.Drawing.Size(755, 158);
            this.tabelDGV.TabIndex = 34;
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
            // ruleEP
            // 
            this.ruleEP.ContainerControl = this;
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
            this.groupBox3.Location = new System.Drawing.Point(15, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 88);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conditionNotOperatorBtn);
            this.groupBox1.Controls.Add(this.conditionOrOperatorBtn);
            this.groupBox1.Controls.Add(this.conditionAndOperatorBtn);
            this.groupBox1.Controls.Add(this.conditionRemoveFormulaBtn);
            this.groupBox1.Controls.Add(this.conditionRightParenthesisBtn);
            this.groupBox1.Controls.Add(this.conditionLeftParenthesisBtn);
            this.groupBox1.Controls.Add(this.conditionFormulaTB);
            this.groupBox1.Controls.Add(this.addConditionFormulaBtn);
            this.groupBox1.Controls.Add(this.conditionFormulaFluentsCmb);
            this.groupBox1.Location = new System.Drawing.Point(15, 193);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 88);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condition";
            // 
            // conditionNotOperatorBtn
            // 
            this.conditionNotOperatorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conditionNotOperatorBtn.Location = new System.Drawing.Point(231, 19);
            this.conditionNotOperatorBtn.Name = "conditionNotOperatorBtn";
            this.conditionNotOperatorBtn.Size = new System.Drawing.Size(59, 23);
            this.conditionNotOperatorBtn.TabIndex = 39;
            this.conditionNotOperatorBtn.Text = "Not";
            this.conditionNotOperatorBtn.UseVisualStyleBackColor = true;
            this.conditionNotOperatorBtn.Click += new System.EventHandler(this.conditionNotOperatorBtn_Click);
            // 
            // conditionOrOperatorBtn
            // 
            this.conditionOrOperatorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conditionOrOperatorBtn.Location = new System.Drawing.Point(360, 19);
            this.conditionOrOperatorBtn.Name = "conditionOrOperatorBtn";
            this.conditionOrOperatorBtn.Size = new System.Drawing.Size(59, 23);
            this.conditionOrOperatorBtn.TabIndex = 37;
            this.conditionOrOperatorBtn.Text = "OR";
            this.conditionOrOperatorBtn.UseVisualStyleBackColor = true;
            this.conditionOrOperatorBtn.Click += new System.EventHandler(this.conditionOrOperatorBtn_Click);
            // 
            // conditionAndOperatorBtn
            // 
            this.conditionAndOperatorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conditionAndOperatorBtn.Location = new System.Drawing.Point(295, 19);
            this.conditionAndOperatorBtn.Name = "conditionAndOperatorBtn";
            this.conditionAndOperatorBtn.Size = new System.Drawing.Size(59, 23);
            this.conditionAndOperatorBtn.TabIndex = 38;
            this.conditionAndOperatorBtn.Text = "AND";
            this.conditionAndOperatorBtn.UseVisualStyleBackColor = true;
            this.conditionAndOperatorBtn.Click += new System.EventHandler(this.conditionAndOperatorBtn_Click);
            // 
            // conditionRemoveFormulaBtn
            // 
            this.conditionRemoveFormulaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conditionRemoveFormulaBtn.Location = new System.Drawing.Point(559, 19);
            this.conditionRemoveFormulaBtn.Name = "conditionRemoveFormulaBtn";
            this.conditionRemoveFormulaBtn.Size = new System.Drawing.Size(94, 23);
            this.conditionRemoveFormulaBtn.TabIndex = 36;
            this.conditionRemoveFormulaBtn.Text = "<<    remove";
            this.conditionRemoveFormulaBtn.UseVisualStyleBackColor = true;
            this.conditionRemoveFormulaBtn.Click += new System.EventHandler(this.conditionRemoveFormulaBtn_Click);
            // 
            // conditionRightParenthesisBtn
            // 
            this.conditionRightParenthesisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conditionRightParenthesisBtn.Location = new System.Drawing.Point(494, 19);
            this.conditionRightParenthesisBtn.Name = "conditionRightParenthesisBtn";
            this.conditionRightParenthesisBtn.Size = new System.Drawing.Size(59, 23);
            this.conditionRightParenthesisBtn.TabIndex = 35;
            this.conditionRightParenthesisBtn.Text = ")";
            this.conditionRightParenthesisBtn.UseVisualStyleBackColor = true;
            this.conditionRightParenthesisBtn.Click += new System.EventHandler(this.conditionRightParenthesisBtn_Click);
            // 
            // conditionLeftParenthesisBtn
            // 
            this.conditionLeftParenthesisBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.conditionLeftParenthesisBtn.Location = new System.Drawing.Point(429, 19);
            this.conditionLeftParenthesisBtn.Name = "conditionLeftParenthesisBtn";
            this.conditionLeftParenthesisBtn.Size = new System.Drawing.Size(59, 23);
            this.conditionLeftParenthesisBtn.TabIndex = 35;
            this.conditionLeftParenthesisBtn.Text = " (";
            this.conditionLeftParenthesisBtn.UseVisualStyleBackColor = true;
            this.conditionLeftParenthesisBtn.Click += new System.EventHandler(this.conditionLeftParenthesisBtn_Click);
            // 
            // conditionFormulaTB
            // 
            this.conditionFormulaTB.BackColor = System.Drawing.Color.White;
            this.conditionFormulaTB.Location = new System.Drawing.Point(14, 58);
            this.conditionFormulaTB.Name = "conditionFormulaTB";
            this.conditionFormulaTB.ReadOnly = true;
            this.conditionFormulaTB.Size = new System.Drawing.Size(693, 20);
            this.conditionFormulaTB.TabIndex = 34;
            // 
            // addConditionFormulaBtn
            // 
            this.addConditionFormulaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addConditionFormulaBtn.Location = new System.Drawing.Point(141, 19);
            this.addConditionFormulaBtn.Name = "addConditionFormulaBtn";
            this.addConditionFormulaBtn.Size = new System.Drawing.Size(84, 23);
            this.addConditionFormulaBtn.TabIndex = 32;
            this.addConditionFormulaBtn.Text = "Add Fluent";
            this.addConditionFormulaBtn.UseVisualStyleBackColor = true;
            this.addConditionFormulaBtn.Click += new System.EventHandler(this.addConditionFormulaBtn_Click);
            // 
            // conditionFormulaFluentsCmb
            // 
            this.conditionFormulaFluentsCmb.FormattingEnabled = true;
            this.conditionFormulaFluentsCmb.Location = new System.Drawing.Point(14, 19);
            this.conditionFormulaFluentsCmb.Name = "conditionFormulaFluentsCmb";
            this.conditionFormulaFluentsCmb.Size = new System.Drawing.Size(121, 21);
            this.conditionFormulaFluentsCmb.TabIndex = 28;
            // 
            // RulesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.tabelDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.effectsCmb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionsCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agentsCmb);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Name = "RulesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rules";
            ((System.ComponentModel.ISupportInitialize)(this.tabelDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ruleEP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.ComboBox agentsCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox actionsCmb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox effectsCmb;
        protected System.Windows.Forms.DataGridView tabelDGV;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.ErrorProvider ruleEP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button rightParenthesisBtn;
        private System.Windows.Forms.Button leftParenthesisBtn;
        private System.Windows.Forms.TextBox formulaTB;
        private System.Windows.Forms.Button addFormulaBtn;
        private System.Windows.Forms.ComboBox formulaFluentsCmb;
        private System.Windows.Forms.Button removeFormulaBtn;
        private System.Windows.Forms.Button orOperatorBtn;
        private System.Windows.Forms.Button andOperatorBtn;
        private System.Windows.Forms.Button notOperatorBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button conditionNotOperatorBtn;
        private System.Windows.Forms.Button conditionOrOperatorBtn;
        private System.Windows.Forms.Button conditionAndOperatorBtn;
        private System.Windows.Forms.Button conditionRemoveFormulaBtn;
        private System.Windows.Forms.Button conditionRightParenthesisBtn;
        private System.Windows.Forms.Button conditionLeftParenthesisBtn;
        private System.Windows.Forms.TextBox conditionFormulaTB;
        private System.Windows.Forms.Button addConditionFormulaBtn;
        private System.Windows.Forms.ComboBox conditionFormulaFluentsCmb;
    }
}