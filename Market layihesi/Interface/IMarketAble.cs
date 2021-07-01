using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using Market_layihesi.Models;

namespace Market_layihesi.Interface
{
    interface IMarketAble
    {
        List<Sell> Sells { get; set; }
        List<SellItem> sellItems { get; set; }
        void AddSell(int sellItemNo, int sellItemcount);
        SellItem ReturnSellitem(Sell sell);
        Sell ReturnSell(string sellNo, SellItem sellitem);
        List<Sell> ReturnAllsell(string selltime, string selltime2);
        List<Sell> ReturnSell(string selltime);
        List<Sell> ReturnValueSell(double value);
        Sell sellReturnNo(string sellNo);
        void AddProduct(string name, double price, Catagory catagory, string code);
        void EditProduct(string productCode);
        List<Product> ReturnProduct(Catagory catagory);
        List<Product> ReturnValueProducts(double value1, double value2);
        List<Product> SearchProduct(string productName);


    }
}
