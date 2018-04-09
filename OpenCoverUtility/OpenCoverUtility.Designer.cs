namespace OpenCoverUtility
{
    partial class OpenCoverUtility
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDll = new System.Windows.Forms.ComboBox();
            this.btnCodeCoverage = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtScanningDepth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source Directory";
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Location = new System.Drawing.Point(12, 25);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(470, 20);
            this.txtSourceDirectory.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(488, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 22);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Test DLL";
            // 
            // cbDll
            // 
            this.cbDll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDll.FormattingEnabled = true;
            this.cbDll.Location = new System.Drawing.Point(12, 98);
            this.cbDll.Name = "cbDll";
            this.cbDll.Size = new System.Drawing.Size(551, 21);
            this.cbDll.TabIndex = 4;
            // 
            // btnCodeCoverage
            // 
            this.btnCodeCoverage.Location = new System.Drawing.Point(427, 125);
            this.btnCodeCoverage.Name = "btnCodeCoverage";
            this.btnCodeCoverage.Size = new System.Drawing.Size(136, 23);
            this.btnCodeCoverage.TabIndex = 5;
            this.btnCodeCoverage.Text = "Code Coverage";
            this.btnCodeCoverage.UseVisualStyleBackColor = true;
            this.btnCodeCoverage.Click += new System.EventHandler(this.btnCodeCoverage_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(488, 51);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 22);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scanning Depth";
            // 
            // txtScanningDepth
            // 
            this.txtScanningDepth.Location = new System.Drawing.Point(382, 52);
            this.txtScanningDepth.Name = "txtScanningDepth";
            this.txtScanningDepth.Size = new System.Drawing.Size(100, 20);
            this.txtScanningDepth.TabIndex = 8;
            this.txtScanningDepth.Text = "3";
            // 
            // OpenCoverUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 159);
            this.Controls.Add(this.txtScanningDepth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.btnCodeCoverage);
            this.Controls.Add(this.cbDll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtSourceDirectory);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OpenCoverUtility";
            this.Text = "Open Cover Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDll;
        private System.Windows.Forms.Button btnCodeCoverage;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScanningDepth;
    }
}

