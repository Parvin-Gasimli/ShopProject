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
        List<Sell> ReturnSellitem();
         void ReturnSell(int sellNo, string sellitem);
        List<Sell> ReturnAllsell(string selltime, string selltime2);
        List<Sell> ReturnSell(string selltime);
        List<Sell> ReturnValueSell(double value);
        Sell SellReturnNo(int sellNo);
        void AddProduct(string name, double price, string catagory, string code);
        void EditProduct(int productCode,int newProductCode);
        List<Product> ReturnProduct(string catagory);
        List<Product> ReturnValueProducts(double value1, double value2);
        List<Product> SearchProduct(string productName);


    }
}
