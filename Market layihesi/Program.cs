﻿using Market_layihesi.Services;
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
            Market market = new Market();
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
                                    case "8":
                                        Console.WriteLine("sistemden cixis");
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
    } 
}


