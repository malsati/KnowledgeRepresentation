namespace KnowledgeRepresentation.Forms
{
    partial class QueriesForm
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
            this.graphViewer = new Microsoft.Glee.GraphViewerGdi.GViewer();
            this.setInitStateBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.actionsCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agentsCmb = new System.Windows.Forms.ComboBox();
            this.addActionBtn = new System.Windows.Forms.Button();
            this.queryTB = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeActionBtn = new System.Windows.Forms.Button();
            this.queryEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.testQueryBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.initStateTB = new System.Windows.Forms.TextBox();
            this.resultTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.possiblyRB = new System.Windows.Forms.RadioButton();
            this.necessaryRB = new System.Windows.Forms.RadioButton();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryEP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // graphViewer
            // 
            this.graphViewer.AsyncLayout = false;
            this.graphViewer.AutoScroll = true;
            this.graphViewer.BackwardEnabled = false;
            this.graphViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphViewer.ForwardEnabled = false;
            this.graphViewer.Graph = null;
            this.graphViewer.Location = new System.Drawing.Point(0, 266);
            this.graphViewer.MouseHitDistance = 0.05D;
            this.graphViewer.Name = "graphViewer";
            this.graphViewer.NavigationVisible = true;
            this.graphViewer.PanButtonPressed = false;
            this.graphViewer.SaveButtonVisible = true;
            this.graphViewer.Size = new System.Drawing.Size(768, 352);
            this.graphViewer.TabIndex = 0;
            this.graphViewer.ZoomF = 1D;
            this.graphViewer.ZoomFraction = 0.5D;
            this.graphViewer.ZoomWindowThreshold = 0.05D;
            // 
            // setInitStateBtn
            // 
            this.setInitStateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setInitStateBtn.Location = new System.Drawing.Point(12, 12);
            this.setInitStateBtn.Name = "setInitStateBtn";
            this.setInitStateBtn.Size = new System.Drawing.Size(117, 23);
            this.setInitStateBtn.TabIndex = 1;
            this.setInitStateBtn.Text = "Set Initial State";
            this.setInitStateBtn.UseVisualStyleBackColor = true;
            this.setInitStateBtn.Click += new System.EventHandler(this.setInitStateBtn_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(188, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 21);
            this.label2.TabIndex = 27;
            this.label2.Text = "Action:";
            // 
            // actionsCmb
            // 
            this.actionsCmb.FormattingEnabled = true;
            this.actionsCmb.Location = new System.Drawing.Point(239, 19);
            this.actionsCmb.Name = "actionsCmb";
            this.actionsCmb.Size = new System.Drawing.Size(121, 21);
            this.actionsCmb.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Agent:";
            // 
            // agentsCmb
            // 
            this.agentsCmb.FormattingEnabled = true;
            this.agentsCmb.Location = new System.Drawing.Point(61, 19);
            this.agentsCmb.Name = "agentsCmb";
            this.agentsCmb.Size = new System.Drawing.Size(121, 21);
            this.agentsCmb.TabIndex = 24;
            // 
            // addActionBtn
            // 
            this.addActionBtn.Location = new System.Drawing.Point(375, 17);
            this.addActionBtn.Name = "addActionBtn";
            this.addActionBtn.Size = new System.Drawing.Size(75, 23);
            this.addActionBtn.TabIndex = 29;
            this.addActionBtn.Text = "Add";
            this.addActionBtn.UseVisualStyleBackColor = true;
            this.addActionBtn.Click += new System.EventHandler(this.addActionBtn_Click);
            // 
            // queryTB
            // 
            this.queryTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.queryTB.Location = new System.Drawing.Point(6, 54);
            this.queryTB.Name = "queryTB";
            this.queryTB.ReadOnly = true;
            this.queryTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.queryTB.Size = new System.Drawing.Size(702, 20);
            this.queryTB.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.removeActionBtn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addActionBtn);
            this.groupBox2.Controls.Add(this.actionsCmb);
            this.groupBox2.Controls.Add(this.queryTB);
            this.groupBox2.Controls.Add(this.agentsCmb);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(726, 83);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // removeActionBtn
            // 
            this.removeActionBtn.Location = new System.Drawing.Point(456, 17);
            this.removeActionBtn.Name = "removeActionBtn";
            this.removeActionBtn.Size = new System.Drawing.Size(75, 23);
            this.removeActionBtn.TabIndex = 30;
            this.removeActionBtn.Text = "Remove";
            this.removeActionBtn.UseVisualStyleBackColor = true;
            this.removeActionBtn.Click += new System.EventHandler(this.removeActionBtn_Click);
            // 
            // queryEP
            // 
            this.queryEP.ContainerControl = this;
            // 
            // testQueryBtn
            // 
            this.testQueryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testQueryBtn.Location = new System.Drawing.Point(19, 221);
            this.testQueryBtn.Name = "testQueryBtn";
            this.testQueryBtn.Size = new System.Drawing.Size(116, 23);
            this.testQueryBtn.TabIndex = 31;
            this.testQueryBtn.Text = "Test Query";
            this.testQueryBtn.UseVisualStyleBackColor = true;
            this.testQueryBtn.Click += new System.EventHandler(this.testQueryBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Initial State: ";
            // 
            // initStateTB
            // 
            this.initStateTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.initStateTB.Location = new System.Drawing.Point(204, 14);
            this.initStateTB.Name = "initStateTB";
            this.initStateTB.ReadOnly = true;
            this.initStateTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.initStateTB.Size = new System.Drawing.Size(480, 20);
            this.initStateTB.TabIndex = 38;
            // 
            // resultTB
            // 
            this.resultTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.resultTB.Location = new System.Drawing.Point(446, 223);
            this.resultTB.Name = "resultTB";
            this.resultTB.ReadOnly = true;
            this.resultTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultTB.Size = new System.Drawing.Size(244, 20);
            this.resultTB.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(384, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "Result: ";
            // 
            // possiblyRB
            // 
            this.possiblyRB.AutoSize = true;
            this.possiblyRB.Location = new System.Drawing.Point(233, 227);
            this.possiblyRB.Name = "possiblyRB";
            this.possiblyRB.Size = new System.Drawing.Size(63, 17);
            this.possiblyRB.TabIndex = 43;
            this.possiblyRB.Text = "Possibly";
            this.possiblyRB.UseVisualStyleBackColor = true;
            // 
            // necessaryRB
            // 
            this.necessaryRB.AutoSize = true;
            this.necessaryRB.Checked = true;
            this.necessaryRB.Location = new System.Drawing.Point(152, 225);
            this.necessaryRB.Name = "necessaryRB";
            this.necessaryRB.Size = new System.Drawing.Size(75, 17);
            this.necessaryRB.TabIndex = 42;
            this.necessaryRB.TabStop = true;
            this.necessaryRB.Text = "Necessary";
            this.necessaryRB.UseVisualStyleBackColor = true;
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
            this.groupBox3.Location = new System.Drawing.Point(13, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 88);
            this.groupBox3.TabIndex = 44;
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
            // QueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 618);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.possiblyRB);
            this.Controls.Add(this.necessaryRB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.resultTB);
            this.Controls.Add(this.initStateTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.testQueryBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.setInitStateBtn);
            this.Controls.Add(this.graphViewer);
            this.Name = "QueriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queries ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryEP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Glee.GraphViewerGdi.GViewer graphViewer;
        private System.Windows.Forms.Button setInitStateBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox actionsCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox agentsCmb;
        private System.Windows.Forms.Button addActionBtn;
        private System.Windows.Forms.TextBox queryTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button removeActionBtn;
        private System.Windows.Forms.ErrorProvider queryEP;
        private System.Windows.Forms.Button testQueryBtn;
        private System.Windows.Forms.TextBox initStateTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resultTB;
        private System.Windows.Forms.RadioButton possiblyRB;
        private System.Windows.Forms.RadioButton necessaryRB;
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
    }
}