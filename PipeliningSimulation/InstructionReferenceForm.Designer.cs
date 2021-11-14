
namespace PipeliningSimulation
{
    partial class InstructionReferenceForm
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
            this.formLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.instructTypeLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.formatLabel = new System.Windows.Forms.Label();
            this.intructTypeListBox = new System.Windows.Forms.ListBox();
            this.instructListBox = new System.Windows.Forms.ListBox();
            this.formatListBox = new System.Windows.Forms.ListBox();
            this.descriptionListBox = new System.Windows.Forms.ListBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formLabel
            // 
            this.formLabel.AutoSize = true;
            this.formLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formLabel.Location = new System.Drawing.Point(193, 38);
            this.formLabel.Name = "formLabel";
            this.formLabel.Size = new System.Drawing.Size(202, 29);
            this.formLabel.TabIndex = 0;
            this.formLabel.Text = "Reference Page";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(168, 112);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(67, 16);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Instruction";
            // 
            // instructTypeLabel
            // 
            this.instructTypeLabel.AutoSize = true;
            this.instructTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructTypeLabel.Location = new System.Drawing.Point(46, 112);
            this.instructTypeLabel.Name = "instructTypeLabel";
            this.instructTypeLabel.Size = new System.Drawing.Size(102, 16);
            this.instructTypeLabel.TabIndex = 2;
            this.instructTypeLabel.Text = "Instruction Type";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.Location = new System.Drawing.Point(416, 112);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(76, 16);
            this.descLabel.TabIndex = 3;
            this.descLabel.Text = "Description";
            // 
            // formatLabel
            // 
            this.formatLabel.AutoSize = true;
            this.formatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formatLabel.Location = new System.Drawing.Point(272, 112);
            this.formatLabel.Name = "formatLabel";
            this.formatLabel.Size = new System.Drawing.Size(50, 16);
            this.formatLabel.TabIndex = 4;
            this.formatLabel.Text = "Format";
            // 
            // intructTypeListBox
            // 
            this.intructTypeListBox.FormattingEnabled = true;
            this.intructTypeListBox.Location = new System.Drawing.Point(43, 133);
            this.intructTypeListBox.Name = "intructTypeListBox";
            this.intructTypeListBox.Size = new System.Drawing.Size(105, 316);
            this.intructTypeListBox.TabIndex = 5;
            // 
            // instructListBox
            // 
            this.instructListBox.FormattingEnabled = true;
            this.instructListBox.Location = new System.Drawing.Point(147, 133);
            this.instructListBox.Name = "instructListBox";
            this.instructListBox.Size = new System.Drawing.Size(100, 316);
            this.instructListBox.TabIndex = 6;
            // 
            // formatListBox
            // 
            this.formatListBox.FormattingEnabled = true;
            this.formatListBox.Location = new System.Drawing.Point(246, 133);
            this.formatListBox.Name = "formatListBox";
            this.formatListBox.Size = new System.Drawing.Size(102, 316);
            this.formatListBox.TabIndex = 7;
            // 
            // descriptionListBox
            // 
            this.descriptionListBox.FormattingEnabled = true;
            this.descriptionListBox.Location = new System.Drawing.Point(347, 133);
            this.descriptionListBox.Name = "descriptionListBox";
            this.descriptionListBox.Size = new System.Drawing.Size(212, 316);
            this.descriptionListBox.TabIndex = 8;
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(210, 469);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(155, 41);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // InstructionReferenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 535);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.descriptionListBox);
            this.Controls.Add(this.formatListBox);
            this.Controls.Add(this.instructListBox);
            this.Controls.Add(this.intructTypeListBox);
            this.Controls.Add(this.formatLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.instructTypeLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.formLabel);
            this.Name = "InstructionReferenceForm";
            this.Text = "Reference Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label formLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label instructTypeLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label formatLabel;
        private System.Windows.Forms.ListBox intructTypeListBox;
        private System.Windows.Forms.ListBox instructListBox;
        private System.Windows.Forms.ListBox formatListBox;
        private System.Windows.Forms.ListBox descriptionListBox;
        private System.Windows.Forms.Button closeButton;
    }
}