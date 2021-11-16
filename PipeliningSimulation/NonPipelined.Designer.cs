
namespace PipeliningSimulation {
    partial class NonPipelined {
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
            this.commitsListBox = new System.Windows.Forms.ListBox();
            this.writeListBox = new System.Windows.Forms.ListBox();
            this.readListBox = new System.Windows.Forms.ListBox();
            this.execListBox = new System.Windows.Forms.ListBox();
            this.issuesListBox = new System.Windows.Forms.ListBox();
            this.instructsListBox = new System.Windows.Forms.ListBox();
            this.commitsLabel = new System.Windows.Forms.Label();
            this.writeResultLabel = new System.Windows.Forms.Label();
            this.memReadLabel = new System.Windows.Forms.Label();
            this.execLabel = new System.Windows.Forms.Label();
            this.issuesLabel = new System.Windows.Forms.Label();
            this.instructLabel = new System.Windows.Forms.Label();
            this.lblTotalCycles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // commitsListBox
            // 
            this.commitsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitsListBox.FormattingEnabled = true;
            this.commitsListBox.ItemHeight = 16;
            this.commitsListBox.Location = new System.Drawing.Point(531, 50);
            this.commitsListBox.Name = "commitsListBox";
            this.commitsListBox.Size = new System.Drawing.Size(75, 388);
            this.commitsListBox.TabIndex = 63;
            // 
            // writeListBox
            // 
            this.writeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeListBox.FormattingEnabled = true;
            this.writeListBox.ItemHeight = 16;
            this.writeListBox.Location = new System.Drawing.Point(453, 50);
            this.writeListBox.Name = "writeListBox";
            this.writeListBox.Size = new System.Drawing.Size(79, 388);
            this.writeListBox.TabIndex = 62;
            // 
            // readListBox
            // 
            this.readListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readListBox.FormattingEnabled = true;
            this.readListBox.ItemHeight = 16;
            this.readListBox.Location = new System.Drawing.Point(375, 50);
            this.readListBox.Name = "readListBox";
            this.readListBox.Size = new System.Drawing.Size(79, 388);
            this.readListBox.TabIndex = 61;
            // 
            // execListBox
            // 
            this.execListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execListBox.FormattingEnabled = true;
            this.execListBox.ItemHeight = 16;
            this.execListBox.Location = new System.Drawing.Point(281, 50);
            this.execListBox.Name = "execListBox";
            this.execListBox.Size = new System.Drawing.Size(96, 388);
            this.execListBox.TabIndex = 60;
            // 
            // issuesListBox
            // 
            this.issuesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesListBox.FormattingEnabled = true;
            this.issuesListBox.ItemHeight = 16;
            this.issuesListBox.Location = new System.Drawing.Point(210, 50);
            this.issuesListBox.Name = "issuesListBox";
            this.issuesListBox.Size = new System.Drawing.Size(72, 388);
            this.issuesListBox.TabIndex = 59;
            // 
            // instructsListBox
            // 
            this.instructsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructsListBox.FormattingEnabled = true;
            this.instructsListBox.ItemHeight = 16;
            this.instructsListBox.Location = new System.Drawing.Point(24, 50);
            this.instructsListBox.Name = "instructsListBox";
            this.instructsListBox.Size = new System.Drawing.Size(187, 388);
            this.instructsListBox.TabIndex = 58;
            // 
            // commitsLabel
            // 
            this.commitsLabel.AutoSize = true;
            this.commitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commitsLabel.Location = new System.Drawing.Point(535, 27);
            this.commitsLabel.Name = "commitsLabel";
            this.commitsLabel.Size = new System.Drawing.Size(71, 20);
            this.commitsLabel.TabIndex = 57;
            this.commitsLabel.Text = "Commits";
            // 
            // writeResultLabel
            // 
            this.writeResultLabel.AutoSize = true;
            this.writeResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeResultLabel.Location = new System.Drawing.Point(465, 8);
            this.writeResultLabel.Name = "writeResultLabel";
            this.writeResultLabel.Size = new System.Drawing.Size(55, 40);
            this.writeResultLabel.TabIndex = 56;
            this.writeResultLabel.Text = "Writes\nResult";
            // 
            // memReadLabel
            // 
            this.memReadLabel.AutoSize = true;
            this.memReadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memReadLabel.Location = new System.Drawing.Point(382, 7);
            this.memReadLabel.Name = "memReadLabel";
            this.memReadLabel.Size = new System.Drawing.Size(65, 40);
            this.memReadLabel.TabIndex = 55;
            this.memReadLabel.Text = "Memory\n  Read";
            // 
            // execLabel
            // 
            this.execLabel.AutoSize = true;
            this.execLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execLabel.Location = new System.Drawing.Point(291, 27);
            this.execLabel.Name = "execLabel";
            this.execLabel.Size = new System.Drawing.Size(75, 20);
            this.execLabel.TabIndex = 54;
            this.execLabel.Text = "Executes";
            // 
            // issuesLabel
            // 
            this.issuesLabel.AutoSize = true;
            this.issuesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuesLabel.Location = new System.Drawing.Point(218, 27);
            this.issuesLabel.Name = "issuesLabel";
            this.issuesLabel.Size = new System.Drawing.Size(56, 20);
            this.issuesLabel.TabIndex = 53;
            this.issuesLabel.Text = "Issues";
            // 
            // instructLabel
            // 
            this.instructLabel.AutoSize = true;
            this.instructLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructLabel.Location = new System.Drawing.Point(77, 27);
            this.instructLabel.Name = "instructLabel";
            this.instructLabel.Size = new System.Drawing.Size(84, 20);
            this.instructLabel.TabIndex = 52;
            this.instructLabel.Text = "Instruction";
            // 
            // lblTotalCycles
            // 
            this.lblTotalCycles.AutoSize = true;
            this.lblTotalCycles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCycles.Location = new System.Drawing.Point(222, 454);
            this.lblTotalCycles.Name = "lblTotalCycles";
            this.lblTotalCycles.Size = new System.Drawing.Size(155, 25);
            this.lblTotalCycles.TabIndex = 64;
            this.lblTotalCycles.Text = "Total Cycles: 0";
            // 
            // NonPipelined
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 498);
            this.Controls.Add(this.lblTotalCycles);
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
            this.Name = "NonPipelined";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NonPipelined";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox commitsListBox;
        private System.Windows.Forms.ListBox writeListBox;
        private System.Windows.Forms.ListBox readListBox;
        private System.Windows.Forms.ListBox execListBox;
        private System.Windows.Forms.ListBox issuesListBox;
        private System.Windows.Forms.ListBox instructsListBox;
        private System.Windows.Forms.Label commitsLabel;
        private System.Windows.Forms.Label writeResultLabel;
        private System.Windows.Forms.Label memReadLabel;
        private System.Windows.Forms.Label execLabel;
        private System.Windows.Forms.Label issuesLabel;
        private System.Windows.Forms.Label instructLabel;
        private System.Windows.Forms.Label lblTotalCycles;
    }
}