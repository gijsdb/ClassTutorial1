using System;
using System.Collections.Generic;

namespace Version_1_C
{
    [Serializable()] 
    public class clsWorksList : List<clsWork>
    {
        private static clsNameComparer _NameComparer = new clsNameComparer();
        private static clsDateComparer _DateComparer = new clsDateComparer();

        private byte _SortOrder;

        public byte SortOrder { get => _SortOrder; set => _SortOrder = value; }

        public void AddWork()
        {
            clsWork lcWork = clsWork.NewWork();
            if (lcWork != null)
            {
                Add(lcWork);
            }
        }
       
        public void DeleteWork(int prIndex)
        {
            RemoveAt(prIndex);
            /*
            if (prIndex >= 0 && prIndex < this.Count)
            {
                if (MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.RemoveAt(prIndex);
                }
            }
            */
        }
        
        public void EditWork(int prIndex)
        {
            clsWork lcWork = this[prIndex];
            lcWork.EditDetails();
            /*
            if (prIndex >= 0 && prIndex < this.Count)
            {
                clsWork lcWork = (clsWork)this[prIndex];
                lcWork.EditDetails();
            }
            else
            {
                MessageBox.Show("Sorry no work selected #" + Convert.ToString(prIndex));
            }
            */
        }

        public decimal GetTotalValue()
        {
            decimal lcTotal = 0;
            foreach (clsWork lcWork in this)
            {
                lcTotal += lcWork.GetValue();
            }
            return lcTotal;
        }

         public void SortByName()
         {
             Sort(_NameComparer);
         }
    
        public void SortByDate()
        {
            Sort(_DateComparer);
        }
    }
}
