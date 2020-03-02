using System;
using System.Collections.Generic;

namespace Version_1_C
{
    class clsNameComparer : IComparer<clsWork>
    {
        public int Compare(clsWork x, clsWork y)
        {
            clsWork workClassX = x;
            clsWork workClassY = y;
            string lcNameX = workClassX.GetName();
            string lcNameY = workClassY.GetName();

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
