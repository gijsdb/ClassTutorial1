namespace Version_1_C
{
    partial class frmArtist
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.optSort = new System.Windows.Forms.GroupBox();
            this.rbByDate = new System.Windows.Forms.RadioButton();
            this.rbByName = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.lstWorks = new System.Windows.Forms.ListBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtSpeciality = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.optSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(310, 448);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(144, 31);
            this.lblTotal.TabIndex = 27;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(150, 448);
            this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(128, 31);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Total Value";
            // 
            // optSort
            // 
            this.optSort.Controls.Add(this.rbByDate);
            this.optSort.Controls.Add(this.rbByName);
            this.optSort.Location = new System.Drawing.Point(198, 156);
            this.optSort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.optSort.Name = "optSort";
            this.optSort.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.optSort.Size = new System.Drawing.Size(272, 92);
            this.optSort.TabIndex = 25;
            this.optSort.TabStop = false;
            this.optSort.Text = "Sort By";
            // 
            // rbByDate
            // 
            this.rbByDate.Location = new System.Drawing.Point(160, 31);
            this.rbByDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbByDate.Name = "rbByDate";
            this.rbByDate.Size = new System.Drawing.Size(96, 46);
            this.rbByDate.TabIndex = 1;
            this.rbByDate.Text = "Date";
            this.rbByDate.CheckedChanged += new System.EventHandler(this.rbByDate_CheckedChanged);
            // 
            // rbByName
            // 
            this.rbByName.Location = new System.Drawing.Point(16, 31);
            this.rbByName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbByName.Name = "rbByName";
            this.rbByName.Size = new System.Drawing.Size(112, 46);
            this.rbByName.TabIndex = 0;
            this.rbByName.Text = "Name";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(342, 494);
            this.btnClose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 62);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(182, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 62);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(22, 494);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 62);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(22, 233);
            this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 31);
            this.Label4.TabIndex = 21;
            this.Label4.Text = "Works";
            // 
            // lstWorks
            // 
            this.lstWorks.ItemHeight = 25;
            this.lstWorks.Location = new System.Drawing.Point(22, 263);
            this.lstWorks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstWorks.Name = "lstWorks";
            this.lstWorks.Size = new System.Drawing.Size(444, 154);
            this.lstWorks.TabIndex = 20;
            this.lstWorks.DoubleClick += new System.EventHandler(this.lstWorks_DoubleClick);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(150, 110);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(316, 31);
            this.txtPhone.TabIndex = 19;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(22, 110);
            this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(128, 31);
            this.Label3.TabIndex = 18;
            this.Label3.Text = "Contact Ph";
            // 
            // txtSpeciality
            // 
            this.txtSpeciality.Location = new System.Drawing.Point(150, 63);
            this.txtSpeciality.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSpeciality.Name = "txtSpeciality";
            this.txtSpeciality.Size = new System.Drawing.Size(316, 31);
            this.txtSpeciality.TabIndex = 17;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(22, 63);
            this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 31);
            this.Label2.TabIndex = 16;
            this.Label2.Text = "Speciality";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(150, 17);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(316, 31);
            this.txtName.TabIndex = 15;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(22, 17);
            this.Label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(128, 31);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Name";
            // 
            // frmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 575);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.optSort);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.lstWorks);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtSpeciality);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmArtist";
            this.Text = "frmArtist";
            this.Load += new System.EventHandler(this.frmArtist_Load);
            this.optSort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox optSort;
        internal System.Windows.Forms.RadioButton rbByDate;
        internal System.Windows.Forms.RadioButton rbByName;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.ListBox lstWorks;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtSpeciality;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
    }
}