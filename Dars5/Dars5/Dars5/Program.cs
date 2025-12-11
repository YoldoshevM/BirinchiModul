using System.Diagnostics.Metrics;

namespace Dars5;

internal class Program
{
    static void Main(string[] args)
    {

        // 1.5.1


        // 1



        //Console.Write(" List lengthini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //List<int> nums = new List<int>();


        //for ( int i = 0; i < n; i++ )
        //{


        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //var count = 0;


        //foreach(int num in nums )
        //{
        //    if ( num >= 100 && num <= 999 )
        //    {
        //        count++;
        //    }
        //}

        //Console.Write(count);


        // 2


        //List<int> nums = new List<int>();


        //Console.Write(" Listni lenghtini kiriting : ");

        //var  n = int.Parse(Console.ReadLine());    


        //for ( int i = 0; i < n ; i++ )
        //{
        //    Console.Write( " list elementini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //var countjuft = 0;


        //foreach ( int num in nums )
        //{
        //    if (num % 2 == 0)
        //    {
        //        countjuft++; 
        //    }
        //}

        //Console.Write(countjuft);


        // 3


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghtini kiriting : ");
        //int n = int.Parse(Console.ReadLine());


        //for ( int i = 0; i < n; i++ )
        //{

        //    Console.Write( " List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //var toqyigindi = 0;


        //foreach ( int num in nums )
        //{

        //    if ( num % 2 != 0 )
        //    {
        //        toqyigindi += num;
        //    }

        //}
        //Console.Write(toqyigindi);




        // 4


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghtini kiriting : ");

        //var n = int.Parse(Console.ReadLine());  

        //for ( int i = 0; i < n; i++ )
        //{

        //    Console.Write( " List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //var count = 0;


        //foreach ( int num in nums )
        //{

        //    if ( num % 3 == 0 && num % 7 == 0 )
        //    {
        //        count++;
        //    }

        //}
        //Console.Write(count);


        // 5

        //List<int> nums = new List<int>();

        //Console.Write(" List lenghtini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //var yigindi = 0;
        //var count = 0;


        //foreach (int num in nums)
        //{

        //    if ( num >= 10 && num <= 99 && num % 2 != 0 )
        //    {
        //        count++;
        //        yigindi += num;
        //    }

        //}
        //Console.Write(" Miqdori = " + count);
        //Console.Write(" Yigindisi = " + yigindi);



        // 6

        //List<int> nums = new List<int>();

        //Console.Write("List lengthini kiriting: ");

        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("List elementini kiriting: ");

        //    nums.Add(int.Parse(Console.ReadLine()));
        //}

        //if ( n >= 2 )
        //{

        //    int temp = nums[0];

        //    nums[0] = nums[n - 1];

        //    nums[n - 1] = temp;

        //}

        //Console.WriteLine( " Almashtirilgan list = " );

        //foreach ( int num in nums )
        //{
        //    Console.Write( " " + num );
        //}


        // 7


        //List<int> nums = new List<int>();

        //Console.Write("List lengthini kiriting: ");

        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("List elementini kiriting: ");

        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //int yigindi = 0;


        //for ( int i = 0; i < n && i < 3; i++ )
        //{
        //    yigindi += nums[i]; 
        //}

        //Console.Write(" Boshidegi 3 tasini yigidisi : "  + yigindi);


        // 8

        //List<int> nums = new List<int>();

        //Console.Write("List lengthini kiriting: ");

        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("List elementini kiriting: ");

        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //int yigindi = 0;


        //for ( int i = n - 3; i < n ; i++ )
        //{
        //    yigindi += nums[i]; 
        //}

        //Console.Write(" Oxirgi 3 tasini yigidisi : "  + yigindi);



        // 9


        //List<int> nums = new List<int>();

        //Console.Write("List lengthini kiriting: ");

        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("List elementini kiriting: ");

        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //int toqcont = 0;
        //int juftcont = 0;


        //foreach (int num in nums)
        //{

        //    if ( num % 2 != 0 )
        //    {
        //        toqcont++;
        //    }

        //    if ( num % 2 == 0 )
        //    {
        //        juftcont++;
        //    }

        //}

        //if ( toqcont > juftcont  )
        //{
        //    Console.WriteLine(true);
        //}
        //else
        //{
        //    Console.WriteLine(false);
        //}



        // 10


        //List<int> nums = new List<int>();

        //Console.Write("List lengthini kiriting: ");

        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("List elementini kiriting: ");

        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //for ( int i = 0;i < nums.Count;i++)
        //{

        //    if ( nums[i] % 2 == 0 )
        //    {
        //        nums[i] *= 3;
        //    }

        //}

        //Console.Write( " Yangilangan list : ");


        //foreach ( int num in nums )
        //{
        //    Console.Write( " " + num);
        //}




        // 11


        List<int> nums = new List<int>();

        Console.Write("List lengthini kiriting: ");

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("List elementini kiriting: ");

            nums.Add(int.Parse(Console.ReadLine()));
        }


        bool hammasikarali = true;

        foreach (int num in nums)
        {

            if ( num % 5 != 0 )
            {
                hammasikarali = false;
                break;
            }

        }

        Console.Write(hammasikarali);

    }
}
