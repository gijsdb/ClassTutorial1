using System;
using System.Collections.Generic;

namespace Version_1_C
{
    [Serializable()] 
    public class clsArtistList : SortedList<String, clsArtist>
    {
        private const string fileName = "gallery.xml";

        public void EditArtist(clsArtist prArtist)
        {
            prArtist.EditDetails();
            /* 
            clsArtist lcArtist;
            lcArtist = this[prKey];
            if (lcArtist != null)
                lcArtist.EditDetails();
            else
                MessageBox.Show("Sorry no artist by this name");
            */
        }
       
        public void NewArtist()
        {
            clsArtist lcArtist = new clsArtist(this);
            if (lcArtist.Name != "")
            {
                Add(lcArtist.Name, lcArtist);
            }
            /*
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
            */
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
            catch {}
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

            catch
            {
                lcArtistList = new clsArtistList();
            }
            return lcArtistList;
        }

    }
}
