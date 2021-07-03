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

        public List<Sell> ReturnSellitem()
        {
            return Sells.ToList();
        }

        public void ReturnSell(int sellNo, string sellitemname)
        {
            var sell1 = sellItems.Find(a => a.SellItemNo == sellNo && a.SellitemName == sellitemname);
            Console.WriteLine(sell1.SellitemName,sell1.SellItemNo);
        }
        public List<Sell> ReturnAllsell(string selltime, string selltime2)
        {
            Sell sell5 = Sells.Find(s => s.DateTime == selltime && s.DateTime == selltime2);
            return ReturnAllsell(selltime, selltime2);
        }

        public List<Sell> ReturnSell(string selltime)
        {
            Sell sell4 = Sells.Find(a => a.DateTime == selltime);
            return ReturnSell(selltime);
        }

        public List<Sell> ReturnValueSell(double value)
        {
            var sell3 = Sells.Find(a => a.SellPrice == value); 

            return Sells.ToList();
        }

        public Sell SellReturnNo(int sellNo)
        {
            var sell1 = Sells.Find(a => a.SellNo == sellNo);
            return sell1;

                
        }

        public void AddProduct(string name, double price, string catagory, string code)
        {
            int temp = 0;
            var categories = Enum.GetValues(typeof(Catagory));
            foreach (var category in categories)
            {
                if (catagory.ToLower() == category.ToString().ToLower())
                {
                    temp = 1;
                    break;
                }
            }
            if (temp == 0)
                throw new KeyNotFoundException("There is no such category");
            Product product1 = new Product(name, price, catagory, code);
            Products.Add(product1);

        }
        // changes the productCodde
        public void EditProduct(int productcode, int newproductCode)
        {
            var product1 = Products.Find(a => a.Code == productcode);
            if (product1.Code == productcode)
            {
                productcode = newproductCode;

            }
            else
            {
                throw new ArgumentNullException("wrong ProductCode");
            }
        }   


        public List<Product> ReturnProduct(string catagory)
        {
            var product = Products.Find(d => d.Catagories == catagory);
            return ReturnProduct(catagory);
        }

        public List<Product> ReturnValueProducts(double value1, double value2)
        {
           Product produc= Products.Find(s => s.Price == value1&&s.Price==value2 );
            return ReturnValueProducts(value1, value2);
        }

        public List<Product> SearchProduct(string productName)
        {
            var product = Products.Find(d => d.Name == productName);
            return SearchProduct(productName);
            
        }
        //additional Method
        public void Remove(int productCode)
        {
            if ( productCode<= 1000) throw new ArgumentOutOfRangeException("product Code");
            if (Products == null) 
            throw new KeyNotFoundException("There are no products with the given code");
            Product product = Products.Find(s => s.Code == productCode);
            Products.Remove(product);
        }
        public List<Sell> SearchByOnlyDate(DateTime day)
        {
            //Bu metod sadece bir tarixe gore satishi axtarir. Hemin tarixde(yani hemin gunde) heyata kechirilmish satishlari List kimi gorsedecey.
            
              //if (res == null)
                throw new KeyNotFoundException("There were no inoices on this day");
           // return res.ToList();
        }
    }
}
