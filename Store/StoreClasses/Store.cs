using System;
using System.Collections.Generic;
using System.Text;

namespace StoreClasses
{
    public class Store
    {
        public Store()
        {
            //_products = new Product[0];
        }
        public string Name;
        private int _productLimit;
        private Product[] _products = new Product[0];

        public Product[] Products
        {
            get => _products;
        }
        public int ProductLimit
        {
            get => _productLimit;
            set
            {
                if (value >= 0)
                    _productLimit = value;
            }
        }

        public void AddProduct(Product pr)
        {
            if (_products.Length < ProductLimit)
            {
                Array.Resize(ref _products, _products.Length + 1);
                _products[_products.Length - 1] = pr;
            }
         
        }

        public Product[] GetProductsByCategory(string category)
        {
            Product[] wantedProducts = new Product[0];

            for (int i = 0; i < Products.Length; i++)
            {
                if(Products[i].Category == category)
                {
                    Array.Resize(ref wantedProducts, wantedProducts.Length + 1);
                    wantedProducts[wantedProducts.Length - 1] = _products[i];
                }
            }

            return wantedProducts;
        }




    }
}
