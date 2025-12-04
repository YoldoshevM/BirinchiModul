namespace Dars1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /// 3 chi fayl 


            /// 1

            Console.Write(" 2 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;

            Console.WriteLine(" birlar honasidagi raqam = " + birlarHonasi);


            /// 2

            Console.Write(" 3 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int onlarHonasi = intValue / 10 % 10;

            Console.WriteLine(" onlar honasidagi raqam = " + onlarHonasi);

            ///3

            Console.Write(" 3 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int yuzlarHonasi = intValue / 100 % 10;

            Console.WriteLine(" yuzlar honasidagi raqam = " + yuzlarHonasi);

            ///4

            Console.Write(" 5 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int minglarHonasi = intValue / 1000;

            Console.WriteLine(" minglar honasidagi raqam = " + minglarHonasi);

            ///5

            Console.Write(" 4 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int yuzlarHonasi = intValue / 100 % 10;

            Console.WriteLine(" yuzlar honasidagi raqam = " + yuzlarHonasi);

            ///6

            Console.Write(" 3 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100 % 10;

            int overall = birlarHonasi + onlarHonasi + yuzlarHonasi;

            Console.WriteLine(" 3 xonali sonlarni raqamlar yigindisi = " + overall);

            ///7

            Console.Write(" 3 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100 % 10;

            int overall = birlarHonasi * onlarHonasi * yuzlarHonasi;

            Console.WriteLine(" 3 xonali sonlarni raqamlar kopaytmasi = " + overall);



            ///8


            Console.Write(" 2 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            ///int yuzlarHonasi = intValue / 100 % 10;

            int overall = birlarHonasi * onlarHonasi;

            Console.WriteLine(" 2 xonali sonlarni raqamlar kopaytmasi = " + overall);


            ///9


            Console.Write(" 5 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100 % 10;
            int minglarHonasi = intValue / 1000 % 10;
            int onMinglarHonasi = intValue / 10000 % 10;

            int overall = birlarHonasi + onlarHonasi + yuzlarHonasi + minglarHonasi + onMinglarHonasi;

            Console.WriteLine(" 5 xonali sonlarni raqamlar yigindisi = " + overall);


            ///10


            Console.Write(" 3 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100 % 10;
        
            int teskari = birlarHonasi * 100 + onlarHonasi * 10 + yuzlarHonasi;

            Console.WriteLine(" Teskari son : " + teskari);


            ///11


            Console.Write(" 4 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100 % 10;
            int minglarHonasi = intValue / 1000 % 10;

            int teskari = minglarHonasi * 1000 + yuzlarHonasi * 100 + birlarHonasi * 10 + onlarHonasi;


            Console.WriteLine(" Natija : " + teskari);



            ///12


            Console.Write(" 3 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100 % 10;
            ///int minglarHonasi = intValue / 1000 % 10;

            int teskari = yuzlarHonasi * 10 + onlarHonasi * 100 + birlarHonasi;


            Console.WriteLine(" Natija : " + teskari);


            ///13


            Console.Write(" 4 honalik son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());

            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100 % 10;
            int minglarHonasi = intValue / 1000 % 10;

            int teskari = onlarHonasi * 1000 + yuzlarHonasi * 100 + minglarHonasi * 10 + birlarHonasi;


            Console.WriteLine(" Natija : " + teskari);



            ///14


            Console.Write(" Gb ni kiriting : ");

            int gb = int.Parse(Console.ReadLine());

            int mb = gb * 1024;

            Console.WriteLine(gb + " gb = " + mb + " mb ");



            ///15


            Console.Write(" Gb ni kiriting : ");

            int gb = int.Parse(Console.ReadLine());

            int bit = gb * 1024 * 1024 * 1024 * 8;

            Console.WriteLine(gb + " gb = " + bit + " bit ");




            ///16


            Console.Write(" Gb ni kiriting : ");

            int gb = int.Parse(Console.ReadLine());

            int tb = gb / 1024;

            Console.WriteLine(gb + " gb = " + tb + " TB ");



            ///17


            Console.Write(" Gb ni kiriting : ");

            int gb = int.Parse(Console.ReadLine());

            int fleshka = gb / 2;

            Console.WriteLine(gb + " gb = " + fleshka + " ta kino sigadi ");


            ///18


            Console.Write(" Gb ni kiriting : ");

            int gb = int.Parse(Console.ReadLine());

            int fleshka = gb / 5;

            Console.WriteLine(gb + " gb = " + fleshka + " ta kino sigadi ");


            ///19


            Console.Write(" 3 honali son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());


            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100;


            int almashish = onlarHonasi * 100 + yuzlarHonasi * 10 + birlarHonasi;

            Console.WriteLine(" Natija = " + almashish);


            ///20


            Console.Write(" 3 honali son kiriting : ");

            int intValue = int.Parse(Console.ReadLine());


            int birlarHonasi = intValue % 10;
            int onlarHonasi = intValue / 10 % 10;
            int yuzlarHonasi = intValue / 100;


            int almashish = birlarHonasi * 100 + onlarHonasi * 10 + yuzlarHonasi;

            Console.WriteLine(" Natija = " + almashish);









            /// 4 chi fayl

















        }
    }
}
