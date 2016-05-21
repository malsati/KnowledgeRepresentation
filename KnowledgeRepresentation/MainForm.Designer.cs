namespace KnowledgeRepresentation
{
    partial class MainForm
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
            this.manageAgentsBtn = new System.Windows.Forms.Button();
            this.manageActionsBtn = new System.Windows.Forms.Button();
            this.manageFluentsBtn = new System.Windows.Forms.Button();
            this.agentsTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.actionsTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fluentsTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rulesMangerBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.rulesDGV = new System.Windows.Forms.DataGridView();
            this.saveBtn = new System.Windows.Forms.Button();
            this.loadBtn = new System.Windows.Forms.Button();
            this.alwaysBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rulesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // manageAgentsBtn
            // 
            this.manageAgentsBtn.Location = new System.Drawing.Point(84, 12);
            this.manageAgentsBtn.Name = "manageAgentsBtn";
            this.manageAgentsBtn.Size = new System.Drawing.Size(120, 40);
            this.manageAgentsBtn.TabIndex = 0;
            this.manageAgentsBtn.Text = "Manage Agents";
            this.manageAgentsBtn.UseVisualStyleBackColor = true;
            this.manageAgentsBtn.Click += new System.EventHandler(this.manageAgentsBtn_Click);
            // 
            // manageActionsBtn
            // 
            this.manageActionsBtn.Location = new System.Drawing.Point(210, 12);
            this.manageActionsBtn.Name = "manageActionsBtn";
            this.manageActionsBtn.Size = new System.Drawing.Size(120, 40);
            this.manageActionsBtn.TabIndex = 1;
            this.manageActionsBtn.Text = "Manage Actions";
            this.manageActionsBtn.UseVisualStyleBackColor = true;
            this.manageActionsBtn.Click += new System.EventHandler(this.manageActionsBtn_Click);
            // 
            // manageFluentsBtn
            // 
            this.manageFluentsBtn.Location = new System.Drawing.Point(336, 12);
            this.manageFluentsBtn.Name = "manageFluentsBtn";
            this.manageFluentsBtn.Size = new System.Drawing.Size(120, 40);
            this.manageFluentsBtn.TabIndex = 2;
            this.manageFluentsBtn.Text = "Manage Fluents";
            this.manageFluentsBtn.UseVisualStyleBackColor = true;
            this.manageFluentsBtn.Click += new System.EventHandler(this.manageFluentsBtn_Click);
            // 
            // agentsTB
            // 
            this.agentsTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.agentsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentsTB.Location = new System.Drawing.Point(84, 58);
            this.agentsTB.Name = "agentsTB";
            this.agentsTB.ReadOnly = true;
            this.agentsTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.agentsTB.Size = new System.Drawing.Size(876, 21);
            this.agentsTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agents:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Actions:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // actionsTB
            // 
            this.actionsTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.actionsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.actionsTB.Location = new System.Drawing.Point(84, 84);
            this.actionsTB.Name = "actionsTB";
            this.actionsTB.ReadOnly = true;
            this.actionsTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.actionsTB.Size = new System.Drawing.Size(876, 21);
            this.actionsTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fluents:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fluentsTB
            // 
            this.fluentsTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.fluentsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.fluentsTB.Location = new System.Drawing.Point(84, 110);
            this.fluentsTB.Name = "fluentsTB";
            this.fluentsTB.ReadOnly = true;
            this.fluentsTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.fluentsTB.Size = new System.Drawing.Size(876, 21);
            this.fluentsTB.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rules:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rulesMangerBtn
            // 
            this.rulesMangerBtn.Location = new System.Drawing.Point(462, 12);
            this.rulesMangerBtn.Name = "rulesMangerBtn";
            this.rulesMangerBtn.Size = new System.Drawing.Size(120, 40);
            this.rulesMangerBtn.TabIndex = 10;
            this.rulesMangerBtn.Text = "Manage Rules";
            this.rulesMangerBtn.UseVisualStyleBackColor = true;
            this.rulesMangerBtn.Click += new System.EventHandler(this.rulesMangerBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(336, 303);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(246, 43);
            this.startBtn.TabIndex = 12;
            this.startBtn.Text = "Start The System";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // rulesDGV
            // 
            this.rulesDGV.AllowUserToAddRows = false;
            this.rulesDGV.AllowUserToDeleteRows = false;
            this.rulesDGV.AllowUserToOrderColumns = true;
            this.rulesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rulesDGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.rulesDGV.ColumnHeadersHeight = 25;
            this.rulesDGV.Location = new System.Drawing.Point(84, 140);
            this.rulesDGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rulesDGV.Name = "rulesDGV";
            this.rulesDGV.ReadOnly = true;
            this.rulesDGV.RowTemplate.Height = 26;
            this.rulesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rulesDGV.Size = new System.Drawing.Size(876, 158);
            this.rulesDGV.TabIndex = 35;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(714, 12);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(120, 40);
            this.saveBtn.TabIndex = 36;
            this.saveBtn.Text = "Save The System";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // loadBtn
            // 
            this.loadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.loadBtn.Location = new System.Drawing.Point(840, 12);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(120, 40);
            this.loadBtn.TabIndex = 37;
            this.loadBtn.Text = "Load The System";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // alwaysBtn
            // 
            this.alwaysBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.alwaysBtn.Location = new System.Drawing.Point(588, 12);
            this.alwaysBtn.Name = "alwaysBtn";
            this.alwaysBtn.Size = new System.Drawing.Size(120, 40);
            this.alwaysBtn.TabIndex = 38;
            this.alwaysBtn.Text = "Always";
            this.alwaysBtn.UseVisualStyleBackColor = true;
            this.alwaysBtn.Click += new System.EventHandler(this.alwaysBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 350);
            this.Controls.Add(this.alwaysBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.rulesDGV);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.rulesMangerBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fluentsTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.actionsTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agentsTB);
            this.Controls.Add(this.manageFluentsBtn);
            this.Controls.Add(this.manageActionsBtn);
            this.Controls.Add(this.manageAgentsBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ara";
            ((System.ComponentModel.ISupportInitialize)(this.rulesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manageAgentsBtn;
        private System.Windows.Forms.Button manageActionsBtn;
        private System.Windows.Forms.Button manageFluentsBtn;
        private System.Windows.Forms.TextBox agentsTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox actionsTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fluentsTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button rulesMangerBtn;
        private System.Windows.Forms.Button startBtn;
        protected System.Windows.Forms.DataGridView rulesDGV;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button alwaysBtn;
    }
}

