using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_layihesi.Models
{
    class SellItem
    {
        public int SellItemNo { get; set; }
        public string SellitemName { get; set; }
        public  int sellItemCount { get; set; }
        public static int Count { get; set; }
        public SellItem( int sellitemNo,string sellItemName)
        {
            Count++;
            sellItemCount += Count;

        }
        public SellItem(int sellItemno, int sellItemcount)
        {
            SellItemNo = sellItemno;
            sellItemCount = sellItemcount;
        }
        public override string ToString()
        {
            return $"sellItemNomesi:{SellItemNo}/   sellitemproduct{SellitemName}";
        }
    } 

}
