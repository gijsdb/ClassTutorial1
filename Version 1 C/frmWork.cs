using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmWork : Form
    {

        protected clsWork _Work;

        public frmWork()
        {
            InitializeComponent();
        }

        protected virtual void updateForm() {
            txtName.Text = _Work.Name;
            txtCreation.Text = _Work.Date.ToShortDateString();
            txtValue.Text = _Work.Value.ToString();
        }

        protected virtual void pushData() {
            _Work.Name = txtName.Text;
            _Work.Date = DateTime.Parse(txtCreation.Text);
            _Work.Value = decimal.Parse(txtValue.Text);
        }

        public void SetDetails(clsWork prWork)
        {
            _Work = prWork;
            updateForm();
            ShowDialog();
        }

        /*
        public void GetDetails(ref string prName, ref DateTime prDate, ref decimal prValue)
        {
            prName = txtName.Text;
            prDate = Convert.ToDateTime(txtCreation.Text);
            prValue = Convert.ToDecimal(txtValue.Text);
        }
        */

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid()) {
                pushData();
                Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        
        public virtual bool isValid()
        {
            return true;
        }

        private void frmWork_Load(object sender, EventArgs e)
        {

        }
    }
}