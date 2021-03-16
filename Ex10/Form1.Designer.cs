namespace Ex10
{
    partial class Form1
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
            this.dgvSample = new System.Windows.Forms.DataGridView();
            this.dgvTwo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSample
            // 
            this.dgvSample.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSample.Location = new System.Drawing.Point(12, 12);
            this.dgvSample.Name = "dgvSample";
            this.dgvSample.Size = new System.Drawing.Size(492, 237);
            this.dgvSample.TabIndex = 0;
            // 
            // dgvTwo
            // 
            this.dgvTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTwo.Location = new System.Drawing.Point(12, 255);
            this.dgvTwo.Name = "dgvTwo";
            this.dgvTwo.Size = new System.Drawing.Size(492, 237);
            this.dgvTwo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 515);
            this.Controls.Add(this.dgvTwo);
            this.Controls.Add(this.dgvSample);
            this.Name = "Form1";
            this.Text = "Example 10";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTwo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSample;
        private System.Windows.Forms.DataGridView dgvTwo;
    }
}

