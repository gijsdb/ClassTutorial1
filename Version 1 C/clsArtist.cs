using System;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtist
    {
        private string _Name;
        private string _Speciality;
        private string _Phone;
        
        private decimal _TotalValue;

        private clsWorksList _WorksList;
        private clsArtistList _ArtistList;
        
        private static frmArtist artistDialog = new frmArtist();

        public string Name { get => _Name; set => _Name = value; }
        public string Speciality { get => _Speciality; set => _Speciality = value; }
        public string Phone { get => _Phone; set => _Phone = value; }
        public decimal TotalValue { get => _TotalValue;}
        public clsWorksList WorksList { get => _WorksList;}
        public clsArtistList ArtistList { get => _ArtistList;}

        public clsArtist(clsArtistList prArtistList)
        {
            _WorksList = new clsWorksList();
            _ArtistList = prArtistList;
            EditDetails();
        }
        
        public void EditDetails()
        {
            artistDialog.SetDetails(this);
            if (artistDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                _TotalValue = WorksList.GetTotalValue();
            }
        }

        public bool IsDuplicate(string prArtistName) {
            return _ArtistList.ContainsKey(prArtistName);
        }


        public string GetKey()
        {
            return Name;
        }

        public decimal GetWorksValue()
        {
            return TotalValue;
        }
        
    }
}
