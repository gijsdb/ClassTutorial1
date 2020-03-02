using System;
using System.Collections.Generic;

namespace Version_1_C
{
    class clsDateComparer : IComparer<clsWork>
    {
        public int Compare(clsWork x, clsWork y)
        {
            clsWork lcWorkX = x;
            clsWork lcWorkY = y;
            DateTime lcDateX = lcWorkX.GetDate();
            DateTime lcDateY = lcWorkY.GetDate();

            return lcDateX.CompareTo(lcDateY);
        }
    }
}
