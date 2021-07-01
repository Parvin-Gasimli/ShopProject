using Market_layihesi.Interface;
using Market_layihesi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_layihesi.Services
{
    class Market : IMarketAble
    {
        public List<Sell> Sells { get; set; }
        public List<SellItem> sellItems { get; set; }
        public List<Product> Products { get; set; }
        public Market()
        {
            Products = new List<Product>();
            Sells = new List<Sell>();
            sellItems = new List<SellItem>();
        }

        public void AddSell(int sellitemNo, int sellitemcount)
        {

            var sellitem = sellItems.Find(s => s.SellItemNo == sellitemNo && s.sellItemCount == sellitemcount);
            if (sellitemcount <= 0 || sellitemcount <= 0)
                throw new ArgumentNullException("sellitem not found");
            else
            {
                Sell sell1 = new Sell(sellitem);
                Sells.Add(sell1);
            }




        }

        public SellItem ReturnSellitem(Sell sell)
        {
            throw new NotImplementedException();
        }

        public void ReturnSell(string sellNo, SellItem sellitem)
        {
            throw new ArgumentNullException();

        }
        public List<Sell> ReturnAllsell(string selltime, string selltime2)
        {
            throw new NotImplementedException();
        }

        public List<Sell> ReturnSell(string selltime)
        {
            throw new NotImplementedException();
        }

        public List<Sell> ReturnValueSell(double value)
        {
            throw new NotImplementedException();
        }

        public Sell sellReturnNo(string sellNo)
        {
            throw new NotImplementedException();
        }

        public void AddProduct(string name, double price, Catagory catagory, string code)
        {
            Product product1 = new Product(name, price, catagory, code);
            Products.Add(product1);
            
        }

        public void EditProduct(string productCode)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnProduct(Catagory catagory)
        {
            throw new NotImplementedException();
        }

        public List<Product> ReturnValueProducts(double value1, double value2)
        {
            throw new NotImplementedException();
        }

        public List<Product> SearchProduct(string productName)
        {
            throw new NotImplementedException();
        }
    }
}
