namespace Version_1_C
{
    partial class frmSculpture
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
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(194, 267);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(188, 31);
            this.txtMaterial.TabIndex = 5;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(18, 273);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(112, 31);
            this.Label5.TabIndex = 56;
            this.Label5.Text = "Material";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(194, 206);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(188, 31);
            this.txtWeight.TabIndex = 4;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(18, 212);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(112, 31);
            this.Label4.TabIndex = 54;
            this.Label4.Text = "Weight";
            // 
            // frmSculpture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(704, 348);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtMaterial);
            this.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            this.Name = "frmSculpture";
            this.Text = "Sculpture";
            this.Load += new System.EventHandler(this.frmSculpture_Load);
            this.Controls.SetChildIndex(this.txtMaterial, 0);
            this.Controls.SetChildIndex(this.Label5, 0);
            this.Controls.SetChildIndex(this.Label4, 0);
            this.Controls.SetChildIndex(this.txtWeight, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtMaterial;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtWeight;
        internal System.Windows.Forms.Label Label4;
    }
}
