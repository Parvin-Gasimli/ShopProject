using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_layihesi.Models
{
    class Sell
    {

       
        public static int count;
        public   int SellNo { get; set; }
        public double SellPrice { get; set; }
        public string DateTime { get; set; }
        public SellItem sells { get; set; }
        public List<Product> SoldProduct;
        public Sell(byte day,byte month,int year,List<Product>soldproduct )
        {
            
            count++;
            SellNo = count;
            DateTime = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            soldproduct = new List<Product>();
            
        }

        public Sell(SellItem sellitem1)
        {
            sells = sellitem1;
        }

       
    }
}
