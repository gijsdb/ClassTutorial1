using System;
//using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Version_1_C
{
    public partial class frmArtist : Form
    {
        public frmArtist()
        {
            InitializeComponent();
        }

        //private clsArtistList ArtistList;
        private clsWorksList WorksList;
        private byte _sortOrder; // 0 = Name, 1 = Date
        private clsArtist _Artist;

        private void UpdateDisplay()
        {
            txtName.Enabled = txtName.Text == "";
            if (_sortOrder == 0)
            {
                WorksList.SortByName();
                rbByName.Checked = true;
            }
            else
            {
                WorksList.SortByDate();
                rbByDate.Checked = true;
            }

            lstWorks.DataSource = null;
            lstWorks.DataSource = WorksList;
            lblTotal.Text = Convert.ToString(WorksList.GetTotalValue());
        }

        private void updateForm()
        {
            txtName.Text = _Artist.Name; //etc. same for all fields. Your turn:
            txtSpeciality.Text = _Artist.Speciality;
            txtPhone.Text = _Artist.Phone;
            //ArtistList = _Artist.ArtistList;
            WorksList = _Artist.WorksList;
        }

        private void pushData() {
            _Artist.Name = txtName.Text; //etc. same for all fields except for the lists! //Your turn:
            _Artist.Speciality = txtSpeciality.Text;
            _Artist.Phone = txtPhone.Text;
        }

        public void SetDetails(clsArtist prArtist) {
            _Artist = prArtist;
            updateForm();
            UpdateDisplay();
            ShowDialog();
        }

        /*
        public void GetDetails(ref string prName, ref string prSpeciality, ref string prPhone)
        {
            prName = txtName.Text;
            prSpeciality = txtSpeciality.Text;
            prPhone = txtPhone.Text;
            _sortOrder = WorksList.SortOrder;
        }
        */

        private void btnDelete_Click(object sender, EventArgs e)
        {
            WorksList.DeleteWork(lstWorks.SelectedIndex);
            UpdateDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            WorksList.AddWork();
            UpdateDisplay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                DialogResult = DialogResult.OK;
            }
        }

        public virtual Boolean isValid()
        {
            if (txtName.Enabled && txtName.Text != "")
                if (_Artist.IsDuplicate(txtName.Text))
                {
                    MessageBox.Show("Artist with that name already exists!");
                    return false;
                }
                else
                    return true;
            else
                return true;
        }

        private void lstWorks_DoubleClick(object sender, EventArgs e)
        {
            int lcIndex = lstWorks.SelectedIndex;
            if (lcIndex >= 0)
            {
                WorksList.EditWork(lcIndex);
                UpdateDisplay();
            }
        }

        private void rbByDate_CheckedChanged(object sender, EventArgs e)
        {
            _sortOrder = Convert.ToByte(rbByDate.Checked);
            UpdateDisplay();
        }

        private void frmArtist_Load(object sender, EventArgs e)
        {

        }
    }
}