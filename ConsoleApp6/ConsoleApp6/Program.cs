
using System.Collections;
using System.Runtime.InteropServices;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
          ArrayList  isimler = new ArrayList();
            ArrayList şehirler = new ArrayList();
            int a = 0;
            int b = -1;
            Console.WriteLine("kaç isim girilecek?");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = a * 2; i > isimler.Count; i-=1)
            {
                Console.WriteLine("isim giriniz:");
                string isim = Convert.ToString(Console.ReadLine());
                isimler.Add(isim);
               
            }
            Console.WriteLine("kaç şehir girilecek?");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = a*2; i > şehirler.Count; i -= 1)
            {
                Console.WriteLine("şehir giriniz:");
                string şehir = Convert.ToString(Console.ReadLine());
                şehirler.Add(şehir);
              
            }
            
            for (int i = şehirler.Count * 2; i > şehirler.Count; i-=1)
            {
                 Random rastgelesayi = new Random();
                 int no = rastgelesayi.Next(0, şehirler.Count);
                Console.Write(isimler[b + 1]);
                Console.Write(" / ");
                Console.Write(şehirler[no]);
                Console.WriteLine(" ");
                b += 1;
            }
            Console.WriteLine("bitti");
            Console.ReadLine();
            
            



        }
    }
}