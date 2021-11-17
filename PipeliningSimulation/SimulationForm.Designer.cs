namespace PipeliningSimulation {
    partial class SimulationForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulationForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.configLabel = new System.Windows.Forms.Label();
            this.configListBox = new System.Windows.Forms.ListBox();
            this.delaysLabel = new System.Windows.Forms.Label();
            this.delaysListBox = new System.Windows.Forms.ListBox();
            this.instructLabel = new System.Windows.Forms.Label();
            this.issuesLabel = new System.Windows.Forms.Label();
            this.execLabel = new System.Windows.Forms.Label();
            this.memReadLabel = new System.Windows.Forms.Label();
            this.writeResultLabel = new System.Windows.Forms.Label();
            this.commitsLabel = new System.Windows.Forms.Label();
            this.instructsListBox = new System.Windows.Forms.ListBox();
            this.issuesListBox = new System.Windows.Forms.ListBox();
            this.execListBox = new System.Windows.Forms.ListBox();
            this.readListBox = new System.Windows.Forms.ListBox();
            this.writeListBox = new System.Windows.Forms.ListBox();
            this.commitsListBox = new System.Windows.Forms.ListBox();
            this.configButtion = new System.Windows.Forms.Button();
            this.openFileButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.stepButton = new System.Windows.Forms.Button();
            this.lblCycleCount = new System.Windows.Forms.Label();
            this.referencePageButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.cycleCountLabel = new System.Windows.Forms.Label();
            this.btnRunWithoutPipeline = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(488, 22);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(262, 31);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Pipeline Simulation";
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.Location = new System.Drawing.Point(72, 22);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(140, 25);
            this.configLabel.TabIndex = 36;
            this.configLabel.Text = "Configuration";
            // 
            // configListBox
            // 
            this.configListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configListBox.FormattingEnabled = true;
            this.configListBox.ItemHeight = 16;
            this.configListBox.Location = new System.Drawing.Point(84, 50);
            this.configListBox.Name = "configListBox";
            this.configListBox.Size = new System.Drawing.Size(128, 180);
            this.configListBox.TabIndex = 37;
            // 
            // delaysLabel
            // 
            this.delaysLabel.AutoSize = true;
            this.delaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delaysLabel.Location = new System.Drawing.Point(112, 385);
            this.delaysLabel.Name = "delaysLabel";
            this.delaysLabel.Size = new System.Drawing.Size(78, 25);
            this.delaysLabel.TabIndex = 38;
            this.delaysLabel.Text = "Delays";
            // 
            // delaysListBox
            // 
            this.delaysListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delaysListBox.FormattingEnabled = true;
            this.delaysListBox.ItemHeight = 16;
            this.delaysListBox.Location = new System.Drawing.Point(33, 425);
            this.delaysListBox.Name = "delaysListBox";
            this.delaysListBox.Size = new System.Drawing.Size(254, 68);
            this.delaysListBox.TabIndex = 39;
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLabel.Location = new System.Drawing.Point(380, 95);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(84, 20);
            this.instructLabel.TabIndex = 40;
            this.instructLabel.Text = "Instruction";
            // 
            // issuesLabel
            // 
            this.issuesLabel.AutoSize = true;
            this.issuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesLabel.Location = new System.Drawing.Point(521, 95);
            this.issuesLabel.Name = "issuesLabel";
            this.issuesLabel.Size = new System.Drawing.Size(56, 20);
            this.issuesLabel.TabIndex = 41;
            this.issuesLabel.Text = "Issues";
            // 
            // execLabel
            // 
            this.execLabel.AutoSize = true;
            this.execLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execLabel.Location = new System.Drawing.Point(594, 95);
            this.execLabel.Name = "execLabel";
            this.execLabel.Size = new System.Drawing.Size(75, 20);
            this.execLabel.TabIndex = 42;
            this.execLabel.Text = "Executes";
            // 
            // memReadLabel
            // 
            this.memReadLabel.AutoSize = true;
            this.memReadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memReadLabel.Location = new System.Drawing.Point(685, 75);
            this.memReadLabel.Name = "memReadLabel";
            this.memReadLabel.Size = new System.Drawing.Size(65, 40);
            this.memReadLabel.TabIndex = 43;
            this.memReadLabel.Text = "Memory\n  Read";
            // 
            // writeResultLabel
            // 
            this.writeResultLabel.AutoSize = true;
            this.writeResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeResultLabel.Location = new System.Drawing.Point(768, 76);
            this.writeResultLabel.Name = "writeResultLabel";
            this.writeResultLabel.Size = new System.Drawing.Size(55, 40);
            this.writeResultLabel.TabIndex = 44;
            this.writeResultLabel.Text = "Writes\nResult";
            // 
            // commitsLabel
            // 
            this.commitsLabel.AutoSize = true;
            this.commitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitsLabel.Location = new System.Drawing.Point(838, 95);
            this.commitsLabel.Name = "commitsLabel";
            this.commitsLabel.Size = new System.Drawing.Size(71, 20);
            this.commitsLabel.TabIndex = 45;
            this.commitsLabel.Text = "Commits";
            // 
            // instructsListBox
            // 
            this.instructsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructsListBox.FormattingEnabled = true;
            this.instructsListBox.ItemHeight = 16;
            this.instructsListBox.Location = new System.Drawing.Point(327, 118);
            this.instructsListBox.Name = "instructsListBox";
            this.instructsListBox.Size = new System.Drawing.Size(187, 388);
            this.instructsListBox.TabIndex = 46;
            // 
            // issuesListBox
            // 
            this.issuesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesListBox.FormattingEnabled = true;
            this.issuesListBox.ItemHeight = 16;
            this.issuesListBox.Location = new System.Drawing.Point(513, 118);
            this.issuesListBox.Name = "issuesListBox";
            this.issuesListBox.Size = new System.Drawing.Size(72, 388);
            this.issuesListBox.TabIndex = 47;
            // 
            // execListBox
            // 
            this.execListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execListBox.FormattingEnabled = true;
            this.execListBox.ItemHeight = 16;
            this.execListBox.Location = new System.Drawing.Point(584, 118);
            this.execListBox.Name = "execListBox";
            this.execListBox.Size = new System.Drawing.Size(96, 388);
            this.execListBox.TabIndex = 48;
            // 
            // readListBox
            // 
            this.readListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readListBox.FormattingEnabled = true;
            this.readListBox.ItemHeight = 16;
            this.readListBox.Location = new System.Drawing.Point(678, 118);
            this.readListBox.Name = "readListBox";
            this.readListBox.Size = new System.Drawing.Size(79, 388);
            this.readListBox.TabIndex = 49;
            // 
            // writeListBox
            // 
            this.writeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeListBox.FormattingEnabled = true;
            this.writeListBox.ItemHeight = 16;
            this.writeListBox.Location = new System.Drawing.Point(756, 118);
            this.writeListBox.Name = "writeListBox";
            this.writeListBox.Size = new System.Drawing.Size(79, 388);
            this.writeListBox.TabIndex = 50;
            // 
            // commitsListBox
            // 
            this.commitsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitsListBox.FormattingEnabled = true;
            this.commitsListBox.ItemHeight = 16;
            this.commitsListBox.Location = new System.Drawing.Point(834, 118);
            this.commitsListBox.Name = "commitsListBox";
            this.commitsListBox.Size = new System.Drawing.Size(75, 388);
            this.commitsListBox.TabIndex = 51;
            // 
            // configButtion
            // 
            this.configButtion.Location = new System.Drawing.Point(84, 236);
            this.configButtion.Name = "configButtion";
            this.configButtion.Size = new System.Drawing.Size(128, 51);
            this.configButtion.TabIndex = 52;
            this.configButtion.Text = "Change Configuration";
            this.configButtion.UseVisualStyleBackColor = true;
            this.configButtion.Click += new System.EventHandler(this.configButtion_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(35, 509);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(122, 55);
            this.openFileButton.TabIndex = 53;
            this.openFileButton.Text = "Open Trace File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(621, 548);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(155, 55);
            this.runButton.TabIndex = 54;
            this.runButton.Text = "Run to End";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(163, 509);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 55);
            this.exitButton.TabIndex = 55;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // stepButton
            // 
            this.stepButton.Location = new System.Drawing.Point(447, 548);
            this.stepButton.Name = "stepButton";
            this.stepButton.Size = new System.Drawing.Size(153, 55);
            this.stepButton.TabIndex = 56;
            this.stepButton.Text = "Step";
            this.stepButton.UseVisualStyleBackColor = true;
            this.stepButton.Click += new System.EventHandler(this.stepButton_Click);
            // 
            // lblCycleCount
            // 
            this.lblCycleCount.AutoSize = true;
            this.lblCycleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCycleCount.Location = new System.Drawing.Point(323, 509);
            this.lblCycleCount.Name = "lblCycleCount";
            this.lblCycleCount.Size = new System.Drawing.Size(112, 20);
            this.lblCycleCount.TabIndex = 57;
            this.lblCycleCount.Text = "Current Cycle: ";
            // 
            // referencePageButton
            // 
            this.referencePageButton.Location = new System.Drawing.Point(163, 570);
            this.referencePageButton.Name = "referencePageButton";
            this.referencePageButton.Size = new System.Drawing.Size(124, 55);
            this.referencePageButton.TabIndex = 58;
            this.referencePageButton.Text = "Instruction Reference";
            this.referencePageButton.UseVisualStyleBackColor = true;
            this.referencePageButton.Click += new System.EventHandler(this.referencePageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Cycle Count";
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(33, 570);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(124, 55);
            this.restartButton.TabIndex = 61;
            this.restartButton.Text = "Reset Simulation";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // cycleCountLabel
            // 
            this.cycleCountLabel.AutoSize = true;
            this.cycleCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleCountLabel.Location = new System.Drawing.Point(142, 324);
            this.cycleCountLabel.Name = "cycleCountLabel";
            this.cycleCountLabel.Size = new System.Drawing.Size(32, 36);
            this.cycleCountLabel.TabIndex = 62;
            this.cycleCountLabel.Text = "0";
            // 
            // btnRunWithoutPipeline
            // 
            this.btnRunWithoutPipeline.Location = new System.Drawing.Point(557, 609);
            this.btnRunWithoutPipeline.Name = "btnRunWithoutPipeline";
            this.btnRunWithoutPipeline.Size = new System.Drawing.Size(112, 29);
            this.btnRunWithoutPipeline.TabIndex = 63;
            this.btnRunWithoutPipeline.Text = "Run w/o Pipeline";
            this.btnRunWithoutPipeline.UseVisualStyleBackColor = true;
            this.btnRunWithoutPipeline.Click += new System.EventHandler(this.btnRunWithoutPipeline_Click);
            // 
            // SimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 650);
            this.Controls.Add(this.btnRunWithoutPipeline);
            this.Controls.Add(this.cycleCountLabel);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.referencePageButton);
            this.Controls.Add(this.lblCycleCount);
            this.Controls.Add(this.stepButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.configButtion);
            this.Controls.Add(this.commitsListBox);
            this.Controls.Add(this.writeListBox);
            this.Controls.Add(this.readListBox);
            this.Controls.Add(this.execListBox);
            this.Controls.Add(this.issuesListBox);
            this.Controls.Add(this.instructsListBox);
            this.Controls.Add(this.commitsLabel);
            this.Controls.Add(this.writeResultLabel);
            this.Controls.Add(this.memReadLabel);
            this.Controls.Add(this.execLabel);
            this.Controls.Add(this.issuesLabel);
            this.Controls.Add(this.instructLabel);
            this.Controls.Add(this.delaysListBox);
            this.Controls.Add(this.delaysLabel);
            this.Controls.Add(this.configListBox);
            this.Controls.Add(this.configLabel);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SimulationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pipelining Simulation";
            this.Load += new System.EventHandler(this.SimulationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.ListBox configListBox;
        private System.Windows.Forms.Label delaysLabel;
        private System.Windows.Forms.ListBox delaysListBox;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Label issuesLabel;
        private System.Windows.Forms.Label execLabel;
        private System.Windows.Forms.Label memReadLabel;
        private System.Windows.Forms.Label writeResultLabel;
        private System.Windows.Forms.Label commitsLabel;
        private System.Windows.Forms.ListBox instructsListBox;
        private System.Windows.Forms.ListBox issuesListBox;
        private System.Windows.Forms.ListBox execListBox;
        private System.Windows.Forms.ListBox readListBox;
        private System.Windows.Forms.ListBox writeListBox;
        private System.Windows.Forms.ListBox commitsListBox;
        private System.Windows.Forms.Button configButtion;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button stepButton;
        private System.Windows.Forms.Label lblCycleCount;
        private System.Windows.Forms.Button referencePageButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label cycleCountLabel;
        private System.Windows.Forms.Button btnRunWithoutPipeline;
    }
}

