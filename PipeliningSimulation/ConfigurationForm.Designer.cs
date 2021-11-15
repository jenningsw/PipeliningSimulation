
namespace PipeliningSimulation
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.fpDivLabel = new System.Windows.Forms.Label();
            this.effLabel = new System.Windows.Forms.Label();
            this.fpAddsLabel = new System.Windows.Forms.Label();
            this.fpMulLabel = new System.Windows.Forms.Label();
            this.fpSubLabel = new System.Windows.Forms.Label();
            this.fpAddLabel = new System.Windows.Forms.Label();
            this.latenciesLabel = new System.Windows.Forms.Label();
            this.fpMulsLabel = new System.Windows.Forms.Label();
            this.intsLabel = new System.Windows.Forms.Label();
            this.reorderLabel = new System.Windows.Forms.Label();
            this.bufferLabel = new System.Windows.Forms.Label();
            this.configLabel = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.fpMulsTextBox = new System.Windows.Forms.NumericUpDown();
            this.fpAddsTextBox = new System.Windows.Forms.NumericUpDown();
            this.intsTextBox = new System.Windows.Forms.NumericUpDown();
            this.effAddrTextBox = new System.Windows.Forms.NumericUpDown();
            this.reorderTextBox = new System.Windows.Forms.NumericUpDown();
            this.fpDivTextBox = new System.Windows.Forms.NumericUpDown();
            this.fpMulTextBox = new System.Windows.Forms.NumericUpDown();
            this.fpSubTextBox = new System.Windows.Forms.NumericUpDown();
            this.fpAddTextBox = new System.Windows.Forms.NumericUpDown();
            this.buffersTextBox = new System.Windows.Forms.ComboBox();
            this.latenciesTextBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fpMulsTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpAddsTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intsTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effAddrTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorderTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpDivTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpMulTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSubTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpAddTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fpDivLabel
            // 
            this.fpDivLabel.AutoSize = true;
            this.fpDivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpDivLabel.Location = new System.Drawing.Point(239, 209);
            this.fpDivLabel.Name = "fpDivLabel";
            this.fpDivLabel.Size = new System.Drawing.Size(56, 18);
            this.fpDivLabel.TabIndex = 23;
            this.fpDivLabel.Text = "FP Div:";
            // 
            // effLabel
            // 
            this.effLabel.AutoSize = true;
            this.effLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.effLabel.Location = new System.Drawing.Point(42, 113);
            this.effLabel.Name = "effLabel";
            this.effLabel.Size = new System.Drawing.Size(64, 18);
            this.effLabel.TabIndex = 22;
            this.effLabel.Text = "Eff Addr:";
            // 
            // fpAddsLabel
            // 
            this.fpAddsLabel.AutoSize = true;
            this.fpAddsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpAddsLabel.Location = new System.Drawing.Point(42, 146);
            this.fpAddsLabel.Name = "fpAddsLabel";
            this.fpAddsLabel.Size = new System.Drawing.Size(68, 18);
            this.fpAddsLabel.TabIndex = 21;
            this.fpAddsLabel.Text = "FP Adds:";
            // 
            // fpMulLabel
            // 
            this.fpMulLabel.AutoSize = true;
            this.fpMulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpMulLabel.Location = new System.Drawing.Point(239, 178);
            this.fpMulLabel.Name = "fpMulLabel";
            this.fpMulLabel.Size = new System.Drawing.Size(59, 18);
            this.fpMulLabel.TabIndex = 20;
            this.fpMulLabel.Text = "FP Mul:";
            // 
            // fpSubLabel
            // 
            this.fpSubLabel.AutoSize = true;
            this.fpSubLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpSubLabel.Location = new System.Drawing.Point(239, 146);
            this.fpSubLabel.Name = "fpSubLabel";
            this.fpSubLabel.Size = new System.Drawing.Size(61, 18);
            this.fpSubLabel.TabIndex = 19;
            this.fpSubLabel.Text = "FP Sub:";
            // 
            // fpAddLabel
            // 
            this.fpAddLabel.AutoSize = true;
            this.fpAddLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpAddLabel.Location = new System.Drawing.Point(239, 113);
            this.fpAddLabel.Name = "fpAddLabel";
            this.fpAddLabel.Size = new System.Drawing.Size(60, 18);
            this.fpAddLabel.TabIndex = 18;
            this.fpAddLabel.Text = "FP Add:";
            // 
            // latenciesLabel
            // 
            this.latenciesLabel.AutoSize = true;
            this.latenciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latenciesLabel.Location = new System.Drawing.Point(239, 81);
            this.latenciesLabel.Name = "latenciesLabel";
            this.latenciesLabel.Size = new System.Drawing.Size(75, 18);
            this.latenciesLabel.TabIndex = 17;
            this.latenciesLabel.Text = "Latencies:";
            // 
            // fpMulsLabel
            // 
            this.fpMulsLabel.AutoSize = true;
            this.fpMulsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpMulsLabel.Location = new System.Drawing.Point(42, 178);
            this.fpMulsLabel.Name = "fpMulsLabel";
            this.fpMulsLabel.Size = new System.Drawing.Size(67, 18);
            this.fpMulsLabel.TabIndex = 16;
            this.fpMulsLabel.Text = "FP Muls:";
            // 
            // intsLabel
            // 
            this.intsLabel.AutoSize = true;
            this.intsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intsLabel.Location = new System.Drawing.Point(42, 209);
            this.intsLabel.Name = "intsLabel";
            this.intsLabel.Size = new System.Drawing.Size(35, 18);
            this.intsLabel.TabIndex = 15;
            this.intsLabel.Text = "Ints:";
            // 
            // reorderLabel
            // 
            this.reorderLabel.AutoSize = true;
            this.reorderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reorderLabel.Location = new System.Drawing.Point(42, 244);
            this.reorderLabel.Name = "reorderLabel";
            this.reorderLabel.Size = new System.Drawing.Size(66, 18);
            this.reorderLabel.TabIndex = 14;
            this.reorderLabel.Text = "Reorder:";
            // 
            // bufferLabel
            // 
            this.bufferLabel.AutoSize = true;
            this.bufferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bufferLabel.Location = new System.Drawing.Point(42, 81);
            this.bufferLabel.Name = "bufferLabel";
            this.bufferLabel.Size = new System.Drawing.Size(59, 18);
            this.bufferLabel.TabIndex = 13;
            this.bufferLabel.Text = "Buffers:";
            // 
            // configLabel
            // 
            this.configLabel.AutoSize = true;
            this.configLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configLabel.Location = new System.Drawing.Point(151, 21);
            this.configLabel.Name = "configLabel";
            this.configLabel.Size = new System.Drawing.Size(176, 31);
            this.configLabel.TabIndex = 12;
            this.configLabel.Text = "Configuration";
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(25, 300);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(105, 57);
            this.openFileButton.TabIndex = 12;
            this.openFileButton.Text = "Load File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(247, 300);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(105, 57);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(358, 300);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(105, 57);
            this.closeButton.TabIndex = 15;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // fpMulsTextBox
            // 
            this.fpMulsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fpMulsTextBox.Location = new System.Drawing.Point(115, 175);
            this.fpMulsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpMulsTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fpMulsTextBox.Name = "fpMulsTextBox";
            this.fpMulsTextBox.Size = new System.Drawing.Size(99, 24);
            this.fpMulsTextBox.TabIndex = 4;
            // 
            // fpAddsTextBox
            // 
            this.fpAddsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fpAddsTextBox.Location = new System.Drawing.Point(115, 143);
            this.fpAddsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpAddsTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fpAddsTextBox.Name = "fpAddsTextBox";
            this.fpAddsTextBox.Size = new System.Drawing.Size(99, 24);
            this.fpAddsTextBox.TabIndex = 3;
            // 
            // intsTextBox
            // 
            this.intsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.intsTextBox.Location = new System.Drawing.Point(115, 206);
            this.intsTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.intsTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.intsTextBox.Name = "intsTextBox";
            this.intsTextBox.Size = new System.Drawing.Size(99, 24);
            this.intsTextBox.TabIndex = 5;
            // 
            // effAddrTextBox
            // 
            this.effAddrTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.effAddrTextBox.Location = new System.Drawing.Point(115, 110);
            this.effAddrTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.effAddrTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.effAddrTextBox.Name = "effAddrTextBox";
            this.effAddrTextBox.Size = new System.Drawing.Size(99, 24);
            this.effAddrTextBox.TabIndex = 2;
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.reorderTextBox.Location = new System.Drawing.Point(115, 241);
            this.reorderTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reorderTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(99, 24);
            this.reorderTextBox.TabIndex = 6;
            // 
            // fpDivTextBox
            // 
            this.fpDivTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fpDivTextBox.Location = new System.Drawing.Point(324, 206);
            this.fpDivTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpDivTextBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fpDivTextBox.Name = "fpDivTextBox";
            this.fpDivTextBox.Size = new System.Drawing.Size(99, 24);
            this.fpDivTextBox.TabIndex = 11;
            // 
            // fpMulTextBox
            // 
            this.fpMulTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fpMulTextBox.Location = new System.Drawing.Point(324, 175);
            this.fpMulTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpMulTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fpMulTextBox.Name = "fpMulTextBox";
            this.fpMulTextBox.Size = new System.Drawing.Size(99, 24);
            this.fpMulTextBox.TabIndex = 10;
            // 
            // fpSubTextBox
            // 
            this.fpSubTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fpSubTextBox.Location = new System.Drawing.Point(324, 143);
            this.fpSubTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpSubTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fpSubTextBox.Name = "fpSubTextBox";
            this.fpSubTextBox.Size = new System.Drawing.Size(99, 24);
            this.fpSubTextBox.TabIndex = 9;
            // 
            // fpAddTextBox
            // 
            this.fpAddTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.fpAddTextBox.Location = new System.Drawing.Point(324, 110);
            this.fpAddTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fpAddTextBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fpAddTextBox.Name = "fpAddTextBox";
            this.fpAddTextBox.Size = new System.Drawing.Size(99, 24);
            this.fpAddTextBox.TabIndex = 8;
            // 
            // buffersTextBox
            // 
            this.buffersTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buffersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buffersTextBox.FormattingEnabled = true;
            this.buffersTextBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.buffersTextBox.Location = new System.Drawing.Point(115, 77);
            this.buffersTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buffersTextBox.Name = "buffersTextBox";
            this.buffersTextBox.Size = new System.Drawing.Size(100, 26);
            this.buffersTextBox.TabIndex = 1;
            // 
            // latenciesTextBox
            // 
            this.latenciesTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.latenciesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latenciesTextBox.FormattingEnabled = true;
            this.latenciesTextBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.latenciesTextBox.Location = new System.Drawing.Point(324, 77);
            this.latenciesTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.latenciesTextBox.Name = "latenciesTextBox";
            this.latenciesTextBox.Size = new System.Drawing.Size(100, 26);
            this.latenciesTextBox.TabIndex = 7;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(136, 300);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(105, 57);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(488, 396);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.latenciesTextBox);
            this.Controls.Add(this.buffersTextBox);
            this.Controls.Add(this.fpAddTextBox);
            this.Controls.Add(this.fpSubTextBox);
            this.Controls.Add(this.fpMulTextBox);
            this.Controls.Add(this.fpDivTextBox);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.effAddrTextBox);
            this.Controls.Add(this.intsTextBox);
            this.Controls.Add(this.fpAddsTextBox);
            this.Controls.Add(this.fpMulsTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.fpDivLabel);
            this.Controls.Add(this.effLabel);
            this.Controls.Add(this.fpAddsLabel);
            this.Controls.Add(this.fpMulLabel);
            this.Controls.Add(this.fpSubLabel);
            this.Controls.Add(this.fpAddLabel);
            this.Controls.Add(this.latenciesLabel);
            this.Controls.Add(this.fpMulsLabel);
            this.Controls.Add(this.intsLabel);
            this.Controls.Add(this.reorderLabel);
            this.Controls.Add(this.bufferLabel);
            this.Controls.Add(this.configLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigurationForm";
            this.Text = "Configuration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigurationForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fpMulsTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpAddsTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intsTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effAddrTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reorderTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpDivTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpMulTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSubTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpAddTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fpDivLabel;
        private System.Windows.Forms.Label effLabel;
        private System.Windows.Forms.Label fpAddsLabel;
        private System.Windows.Forms.Label fpMulLabel;
        private System.Windows.Forms.Label fpSubLabel;
        private System.Windows.Forms.Label fpAddLabel;
        private System.Windows.Forms.Label latenciesLabel;
        private System.Windows.Forms.Label fpMulsLabel;
        private System.Windows.Forms.Label intsLabel;
        private System.Windows.Forms.Label reorderLabel;
        private System.Windows.Forms.Label bufferLabel;
        private System.Windows.Forms.Label configLabel;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.NumericUpDown fpMulsTextBox;
        private System.Windows.Forms.NumericUpDown fpAddsTextBox;
        private System.Windows.Forms.NumericUpDown intsTextBox;
        private System.Windows.Forms.NumericUpDown effAddrTextBox;
        private System.Windows.Forms.NumericUpDown reorderTextBox;
        private System.Windows.Forms.NumericUpDown fpDivTextBox;
        private System.Windows.Forms.NumericUpDown fpMulTextBox;
        private System.Windows.Forms.NumericUpDown fpSubTextBox;
        private System.Windows.Forms.NumericUpDown fpAddTextBox;
        private System.Windows.Forms.ComboBox buffersTextBox;
        private System.Windows.Forms.ComboBox latenciesTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}