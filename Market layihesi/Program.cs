using Market_layihesi.Models;
using Market_layihesi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_layihesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Market shop = new Market();
            string answer;
            string answer1;
            do
            {

                Console.WriteLine("\n=====================================\n");
                Console.WriteLine("1   Mehsullar uzerinde emeliyyat aparmaq");
                Console.WriteLine("2   Satislar uzerinde emeliyyat aparmaq");
                Console.WriteLine("3   Sistemden cixmaq");
                Console.WriteLine("\n qeyd olunanlardan birini secin\n");
                Console.WriteLine("\n===================================\n");
                answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                            Console.WriteLine("Asagidakilardan birini secin");
                            do
                            {
                                Console.WriteLine("1.1     Yeni mehsul elave et  - userden yeni mehsul yaradilmasi ucun lazim olan melumatlari daxil edilmelidir");
                                Console.WriteLine("1.2     Mehsul uzerinde duzelis et -  duzelis edilecek mehsulun code-u ve duzelis melumatlari daxil edilmelidir");
                                Console.WriteLine("1.3     Mehsulu sil - mehsulu kodu daxil edilmelidir");
                                Console.WriteLine("1.4     Butun mehsullari goster - butun mehsullar gosterilecek (kodu,adi,categoriyasi,sayi,qiymeti)");
                                Console.WriteLine("1.5     Categoriyasina gore mehsullari goster - usere var olan kateqoriyalar gosteilecek ve onlar arasinda bir secim etmelidir ve secilmis kateqoriyadan olan butun mehsullar gosterilir (kodu,adi,categoriyasi,sayi,qiymeti)");
                                Console.WriteLine("1.6     Qiymet araligina gore mehsullari goster - userden minmum ve maximum qiymetleri daxil etmesi istenilir ve hemin qiymet araliginda olan mehsullar gosterilir (kodu, adi,categoriyasi,sayi,qiymeti)");
                                Console.WriteLine("1.7     Mehsullar arasinda ada gore axtaris et - useden text daxil etmesi istenilir ve adinda hemin text olan butun mehsullar gosterilir (kodu, adi,categoriyasi,sayi,qiymeti)");
                                Console.WriteLine("1.8     Geriye qayit");
                                Console.WriteLine("\n===================================\n");
                                answer1 = Console.ReadLine();

                                switch (answer1)
                                {
                                    case "1.1":
                                    AddProduct(shop);
                                    
                                        break;
                                case "1.2":
                                    EditProduct(shop);
                                    break;
                                case "1.3":
                                    Remove(shop);
                                    break;
                                case "1.4":
                                    









                                case "1.7":
                                    Serachproduct(shop);
                                    break;
                                
                                    default:
                                        break;

                                }
                            } while (answer1 != "1.8");
                            break;

                        default:
                            break;
                    }

            } while (answer!="3");
        } 
        static void AddSell(Market m2)
        {
            Console.WriteLine("Mehsulun nomresini daxil edin");
            int sellitemNo = int.Parse(Console.ReadLine());
            Console.WriteLine("mehsulun sayini daxil edin");

            int sellCount = int.Parse(Console.ReadLine());
            m2.AddSell(sellitemNo, sellCount);
        }
        static void EditProduct(Market m3)
        {
            Console.WriteLine("Mehsulun kodunu daxil edin");
            int productcount = int.Parse(Console.ReadLine());
            Console.WriteLine("Mehsulun yeni kodunu daxil edin");
            int newproductcount = int.Parse(Console.ReadLine());
            m3.EditProduct(productcount,  newproductcount);
        }
        //productun silinmesi
        static void Remove(Market m5)
        {
            Console.WriteLine("==============Existing product codes are shown below:==============");
            foreach (var item in m5.Products)
            {
                Console.WriteLine($"code - {item.Code} ({item.Name})");
            }
            Console.WriteLine("Enter the code of the product, please");
            int code;
            string codestr = Console.ReadLine();
            while (!int.TryParse(codestr, out code))
            {
                Console.WriteLine("Insert the code again");
                codestr = Console.ReadLine();
            }
            try
            {
                m5.Remove(code);
                Console.WriteLine("==============Product deleted==============");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong. Try again, please");
                Console.WriteLine(e.Message);
            }
        }
        static  void Serachproduct(Market m6)
        {
            Console.WriteLine("Axtarmaq istediyiniz mehsulun adini daxil edin");
            string productname1 = Console.ReadLine();
            m6.SearchProduct(productname1);
        }
        static void  List<Sell> (Market m7)
        {
             
        }
        static void AddProduct(Market m8)
        {
            Console.WriteLine("Mehsulun Adini daxil edin");
            string name1 = Console.ReadLine();
            Console.WriteLine("mehsullun qiymetini daxil edin");
            double prices = double.Parse(Console.ReadLine());
            Console.WriteLine("Mehsulun katagoriyasini daxil edin");
            string catagory1 = Console.ReadLine();
            Console.WriteLine("Mehsulun kodunu daxil edin");
            string kod = Console.ReadLine();
            m8.AddProduct(name1, prices, catagory1, kod);
            try
            {
                Console.WriteLine("mehsul ugurla elave edildi");
                Console.WriteLine($"mehsulun adi:{name1} / Mehsulun Qiymeti:{prices} AZN/ Mehsulun novu:{catagory1} / Mehsulun kodu:{kod}");
            }
            catch (Exception)
            {

               //if (temp == 0)
                    throw new KeyNotFoundException("There is no such category");
            }
        }
        
    } 
   
}


