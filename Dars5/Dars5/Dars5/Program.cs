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


        //List<int> nums = new List<int>();

        //Console.Write("List lengthini kiriting: ");

        //int n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{
        //    Console.Write("List elementini kiriting: ");

        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //bool hammasikarali = true;

        //foreach (int num in nums)
        //{

        //    if ( num % 5 != 0 )
        //    {
        //        hammasikarali = false;
        //        break;
        //    }

        //}

        //Console.Write(hammasikarali);




        // 12




        //List<int> nums = new List<int>();

        //Console.Write(" List lenghizini kiriting : "); 

        //var n = int.Parse(Console.ReadLine());

        //for ( int i = 0; i < n; i++ )
        //{

        //    Console.Write( " List elementini kiriting : "); 
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}

        //bool res = FirstThreeTwoDigits(nums);
        //Console.WriteLine(res);


        //static bool FirstThreeTwoDigits(List<int> nums)
        //{

        //    if ( nums.Count < 3 )
        //    {
        //        return false;
        //    }

        //    for ( int i = 0; i < 3 ; i++ )
        //    {
        //        if (nums[i] < 10 || nums[i] > 99 )
        //        {
        //            return false;
        //        }
        //    }  

        //    return true;

        //}




        // 13


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghizini kiriting : "); 

        //var n = int.Parse(Console.ReadLine());

        //for ( int i = 0; i < n; i++ )
        //{

        //    Console.Write( " List elementini kiriting : "); 
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}

        //bool res = CheckList(nums);
        //Console.WriteLine(res);


        //static bool CheckList(List<int> nums)
        //{

        //    if ( nums[0] % 2 != 0 || nums[1] % 2 != 0 )
        //    {
        //        return false; 
        //    }


        //    var n = nums.Count;

        //    if (nums[ n - 2 ] % 2 == 0 || nums[n - 1] % 2 == 0)
        //    {
        //        return false; 
        //    }


        //    return true;

        //}


        // 14


        //List<int> nums = new List<int>();

        //Console.Write( " List lenghini kiriting : ");

        //var n = int.Parse( Console.ReadLine() );    

        //for ( int i = 0; i < n; i++ )
        //{

        //    Console.Write( " List elementlarini kiriting : ");
        //    nums.Add(int.Parse( Console.ReadLine() ));

        //}


        //var min = nums[0];

        //for ( int i = 1; i < nums.Count; i++ )
        //{

        //    if ( nums[i] < min )
        //    {
        //        min = nums[i];
        //    }

        //}

        //Console.Write(" Eng kicik element : " + min);



        // 15


        //List<int> nums = new List<int>();

        //Console.Write( " List lenghini kiriting : ");

        //var n = int.Parse( Console.ReadLine() );    

        //for ( int i = 0; i < n; i++ )
        //{

        //    Console.Write( " List elementlarini kiriting : ");
        //    nums.Add(int.Parse( Console.ReadLine() ));

        //}


        //var min = nums[0];

        //for ( int i = 1; i < nums.Count; i++ )
        //{

        //    if ( nums[i] < min )
        //    {
        //        min = nums[i];
        //    }

        //}


        //var max = nums[0];

        //for ( int i = 1; i < nums.Count; i++ )
        //{

        //    if ( nums[i] > max )
        //    {
        //        max = nums[i];
        //    }

        //}


        //var result = min + max; 



        //Console.Write(" Eng kicik va katta elementlarni yigindisi : " + result);



        // 16


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //for (int i = 0; i < nums.Count; i++)
        //{

        //    if (nums[i] >= 10 && nums[i] <= 99)
        //    {

        //        nums[i] += 100;

        //    }


        //}


        //Console.Write(" Yangi list : ");

        //foreach (int num in nums)
        //{

        //    Console.Write( " " + num );

        //}



        // 17


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //var countPosittive = 0;
        //var countNegative = 0;


        //foreach (int nums in nums)
        //{

        //    if ( nums > 0)
        //    {
        //        countPosittive++;
        //    }

        //    else if ( nums < 0)
        //    {
        //        countNegative++; 
        //    }


        //}

        //Console.Write( " Musbat sonlarni soni : " + countPosittive);
        //Console.Write( " Manfiy sonlarni soni : " + countNegative);



        // 18



        //List<int> nums = new List<int>();

        //Console.Write(" List lenghini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //var counter = 0;

        //for ( int i = 0; i < nums.Count; i++)
        //{

        //    if (nums[i] < nums[0] )
        //    {
        //        counter++;
        //    }

        //}

        //Console.Write(" 1 chi elementidan kichik bo‘lgan elementlarni miqdori : " + counter);


        // 19


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}

        //var yigindi = 0;

        //for ( int i = 0; i < nums.Count; i++)
        //{

        //    if (nums[i] > nums[nums.Count - 1] )
        //    {
        //        yigindi += nums[i];
        //    }

        //}

        //Console.Write(" Oxirgi elementidan katta bo‘lgan elementlarni yigindisi : " + yigindi); 



        // 20


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //bool allDivisable = true;

        //foreach (var num in nums)
        //{
            
        //    if (num % 4 != 0 || num % 3 != 0)
        //    {

        //        allDivisable =  false;
        //        break;

        //    }

        //}

        //if (allDivisable)
        //{
        //    Console.Write( " hello ");
        //}
        //else
        //{
        //    Console.Write( " salom ");
        //}


    }
}
