using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_Assignment_Group10_.Classes
{
    internal class Supplies
    {
        private string itamName;
        private int itamQuantity;
        private decimal itamPrice;

        public Supplies(string itamName, int itamQuantity, decimal itamPrice) 
        {
            this.itamName = itamName;
            this.itamQuantity = itamQuantity;
            this.itamPrice = itamPrice;
        }


    }
}
