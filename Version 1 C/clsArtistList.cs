using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtistList : SortedList<String, clsArtist>
    {
        private const string fileName = "gallery.xml";

        public void EditArtist(string prKey)
        {
            clsArtist lcArtist;
            lcArtist = this[prKey];
            if (lcArtist != null)
                lcArtist.EditDetails();
            else
                MessageBox.Show("Sorry no artist by this name");
        }
       
        public void NewArtist()
        {
            clsArtist lcArtist = new clsArtist(this);
            try
            {
                if (lcArtist.GetKey() != "")
                {
                    Add(lcArtist.GetKey(), lcArtist);
                    MessageBox.Show("Artist added!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Duplicate Key!");
            }
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsArtist lcArtist in Values)
            {
                lcTotal += lcArtist.GetWorksValue();
            }
            return lcTotal;
        }

        public void Save()
        {
            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Create);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcFormatter.Serialize(lcFileStream, this);
                lcFileStream.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "File Save Error");
            }
        }

        public static clsArtistList Retrieve()
        {
            clsArtistList lcArtistList;

            try
            {
                System.IO.FileStream lcFileStream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
                System.Runtime.Serialization.Formatters.Soap.SoapFormatter lcFormatter =
                    new System.Runtime.Serialization.Formatters.Soap.SoapFormatter();

                lcArtistList = (clsArtistList)lcFormatter.Deserialize(lcFileStream);
                lcFileStream.Close();
            }

            catch (Exception e)
            {
                lcArtistList = new clsArtistList();
                MessageBox.Show(e.Message, "File Retrieve Error");
            }
            return lcArtistList;
        }

    }
}
