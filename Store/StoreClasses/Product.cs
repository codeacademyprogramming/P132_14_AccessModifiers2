using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses
{
    public class Product
    {
        public string Name;
        public string Category;
        private double _price;

        public double Price
        {
            get => _price;
            set
            {
                if(value>=0)
                    _price = value;
            }
        }
    }
}
