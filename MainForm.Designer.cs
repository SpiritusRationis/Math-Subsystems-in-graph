namespace SystemAnalysis_part2
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.OutPanel = new System.Windows.Forms.Panel();
            this.OutBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubsystemsBox = new System.Windows.Forms.TextBox();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.ComputingButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveRowButton = new System.Windows.Forms.Button();
            this.CountBox = new System.Windows.Forms.TextBox();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.OutPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.OutPanel);
            this.MainPanel.Controls.Add(this.BottomPanel);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.InputPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(704, 321);
            this.MainPanel.TabIndex = 0;
            // 
            // OutPanel
            // 
            this.OutPanel.Controls.Add(this.OutBox);
            this.OutPanel.Controls.Add(this.label3);
            this.OutPanel.Controls.Add(this.label2);
            this.OutPanel.Controls.Add(this.SubsystemsBox);
            this.OutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OutPanel.Location = new System.Drawing.Point(200, 50);
            this.OutPanel.Name = "OutPanel";
            this.OutPanel.Size = new System.Drawing.Size(504, 221);
            this.OutPanel.TabIndex = 11;
            // 
            // OutBox
            // 
            this.OutBox.BackColor = System.Drawing.Color.White;
            this.OutBox.Location = new System.Drawing.Point(286, 18);
            this.OutBox.Multiline = true;
            this.OutBox.Name = "OutBox";
            this.OutBox.ReadOnly = true;
            this.OutBox.Size = new System.Drawing.Size(200, 200);
            this.OutBox.TabIndex = 3;
            this.OutBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Множество левых инциденций";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Подсистемы графа";
            // 
            // SubsystemsBox
            // 
            this.SubsystemsBox.BackColor = System.Drawing.Color.White;
            this.SubsystemsBox.Location = new System.Drawing.Point(9, 18);
            this.SubsystemsBox.Multiline = true;
            this.SubsystemsBox.Name = "SubsystemsBox";
            this.SubsystemsBox.ReadOnly = true;
            this.SubsystemsBox.Size = new System.Drawing.Size(200, 200);
            this.SubsystemsBox.TabIndex = 0;
            this.SubsystemsBox.TabStop = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.ComputingButton);
            this.BottomPanel.Controls.Add(this.ClearButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(200, 271);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(504, 50);
            this.BottomPanel.TabIndex = 10;
            // 
            // ComputingButton
            // 
            this.ComputingButton.Location = new System.Drawing.Point(286, 6);
            this.ComputingButton.Name = "ComputingButton";
            this.ComputingButton.Size = new System.Drawing.Size(100, 32);
            this.ComputingButton.TabIndex = 8;
            this.ComputingButton.Text = "Выполнить";
            this.ComputingButton.UseVisualStyleBackColor = true;
            this.ComputingButton.Click += new System.EventHandler(this.ComputingButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(392, 6);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(100, 32);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.RemoveRowButton);
            this.TopPanel.Controls.Add(this.CountBox);
            this.TopPanel.Controls.Add(this.AddRowButton);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(504, 50);
            this.TopPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Количество вершин графа: ";
            // 
            // RemoveRowButton
            // 
            this.RemoveRowButton.Location = new System.Drawing.Point(458, 27);
            this.RemoveRowButton.Name = "RemoveRowButton";
            this.RemoveRowButton.Size = new System.Drawing.Size(20, 20);
            this.RemoveRowButton.TabIndex = 6;
            this.RemoveRowButton.Text = "-";
            this.RemoveRowButton.UseVisualStyleBackColor = true;
            this.RemoveRowButton.Click += new System.EventHandler(this.RemoveRowButton_Click);
            // 
            // CountBox
            // 
            this.CountBox.BackColor = System.Drawing.Color.White;
            this.CountBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBox.Location = new System.Drawing.Point(392, 7);
            this.CountBox.Name = "CountBox";
            this.CountBox.ReadOnly = true;
            this.CountBox.Size = new System.Drawing.Size(60, 40);
            this.CountBox.TabIndex = 5;
            this.CountBox.TabStop = false;
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(458, 7);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(20, 20);
            this.AddRowButton.TabIndex = 7;
            this.AddRowButton.Text = "+";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // InputPanel
            // 
            this.InputPanel.AutoScroll = true;
            this.InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.InputPanel.Location = new System.Drawing.Point(0, 0);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(200, 321);
            this.InputPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 321);
            this.Controls.Add(this.MainPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 360);
            this.MinimumSize = new System.Drawing.Size(720, 360);
            this.Name = "MainForm";
            this.Text = "Subsystem descrimination";
            this.MainPanel.ResumeLayout(false);
            this.OutPanel.ResumeLayout(false);
            this.OutPanel.PerformLayout();
            this.BottomPanel.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Button ComputingButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveRowButton;
        private System.Windows.Forms.TextBox CountBox;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.Panel OutPanel;
        private System.Windows.Forms.TextBox SubsystemsBox;
        private System.Windows.Forms.TextBox OutBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}