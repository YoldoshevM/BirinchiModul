using System.Globalization;

namespace BrinchiModulExam;

internal class Program
{
    static void Main(string[] args)
    {



        // 1


        //List<int> nums = new List<int>();


        //Console.Write( " List lenghizini kiriting : ");

        //var n = int.Parse( Console.ReadLine() );    

        //for ( int i  = 0; i < n; i++ )
        //{

        //    Console.Write( " List elementini kiriting : ");
        //    nums.Add(int.Parse( Console.ReadLine() ));

        //}

        //var counter = 0;

        //foreach ( int num in nums)
        //{

        //    if ( num % 2 == 0 )
        //    {
        //        counter++;
        //    }

        //}

        //Console.Write(counter);




        // 2


        //List<string> nums = new List<string>();


        //Console.Write( " List lenghzini kiriting : ");

        //var s = Console.ReadLine();

        //for ( int i = 0; i < s.Length; i++ )
        //{
        //    Console.Write( "List elementlarini kiriting : ");
        //    nums.Add(Console.ReadLine());
        //}

        //foreach ( var num in nums )
        //{

        //    if ( num.Length > 5 )
        //    {
        //        Console.Write(true);
        //    }

        //    else
        //    {
        //        Console.Write(false); 
        //    }

        //}





        // 3



        //static string qaytar (string s)
        //{

        //    var startThree = s.Substring(0, 3);

        //    return startThree;

        //}

        //Console.Write( " Satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( qaytar(s));




        // 4


        //static bool StartWithPdp( string s )
        //{

        //    var start = s.StartsWith("PDP");

        //    if ( start )
        //    {
        //        return true;
        //    }

        //    return false;


        //}

        //Console.Write( " Satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( StartWithPdp(s));




        // 5


        //static bool Search ( string s )
        //{

        //    for ( int i = 0; i < s.Length; i++ )
        //    {

        //        if ( s[i] == 'G' && s[i + 1] == '1' && s[i + 2] == '3' )
        //        {
        //            return true;
        //        }


        //    }

        //    return false;

        //}

        //Console.Write( " satir kiritig : ");

        //var s = Console.ReadLine();

        //Console.Write( Search(s));




        // 6

            
        List<int> nums = new List<int>();


        Console.Write( " List lenghzini kiriting : ");

        var n = int.Parse( Console.ReadLine() );    

        for (  int i = 0; i < n; i++ )
        {

            Console.Write( " List elementini kiriting : ");
            nums.Add(int.Parse( Console.ReadLine() ));
            
        }

        //Console.WriteLine(nums[0] + nums[1]);


        for ( int i = 0; i < nums.Count ; i++ )
        {

            Console.WriteLine(nums[0] + nums[1]);

        }






    }


    }

