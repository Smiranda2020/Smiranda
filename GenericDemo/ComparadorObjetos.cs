using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class ComparadorObjetos : IComparer<object>
    {
        public int Compare(object x, object y)
        {
            int xhash = x.GetHashCode();
            int yhash = y.GetHashCode();

            if (xhash == yhash)
            {
                return 0;
            }
             if(xhash < yhash)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }
    }
}
