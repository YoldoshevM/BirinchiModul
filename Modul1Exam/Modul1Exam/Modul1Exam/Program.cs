using System.ComponentModel.DataAnnotations;

namespace Modul1Exam;

internal class Program
{
    static void Main(string[] args)
    {


        // 1.4.1


        // 1


        //static string helloName(string name )
        //{

        //    return " hello " + name;


        //}

        //Console.Write(" ism kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write(helloName(s));



        // 2


        //static string makeAbba(string a, string b)
        //{

        //    return a + b + b + a;

        //}

        //Console.Write(" a satirini kiriting : ");

        //var a = Console.ReadLine();

        //Console.Write(" b satirini kiriting : ");

        //var b = Console.ReadLine();


        //Console.Write( makeAbba(a,b));



        // 3


        //static string makeOutWord ( string a , string b )
        //{

        //    var start = a.Substring(0, 2);
        //    var end = a.Substring(2,2);

        //    return start + b + end;


        //}

        //Console.Write(" a satirini kiriting : ");

        //var a = Console.ReadLine();

        //Console.Write(" b satirini kiriting : ");

        //var b = Console.ReadLine();


        //Console.Write(makeOutWord(a, b));




        // 4



        //static string extraEnd ( string s )
        //{

        //    if ( s.Length < 2 )
        //    {
        //        return " Satir kamida 2 ga teng bolish kerak ! ";
        //    }


        //    var lastTwo = s.Substring(s.Length - 2 , 2 );


        //    return lastTwo + lastTwo + lastTwo;

        //}

        //Console.Write(" s satirini kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write(extraEnd(s));




        // 5


        //static string firstTwo(string s)
        //{

        //    if (s.Length < 2)
        //    {
        //        return s;
        //    }


        //    var firstTwo = s.Substring(0,2);


        //    return firstTwo;

        //}

        //Console.Write(" s satirini kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write(firstTwo(s));



        // 6


        //static string firstHalf ( string s)
        //{

        //    return s.Substring(0, s.Length / 2);

        //}

        //Console.Write(" s satirini kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write(firstHalf(s));




        // 7

        //static string withoutEnd(string s)
        //{

        //    return s.Substring(1, s.Length - 2);

        //}

        //Console.Write(" s satirini kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write(withoutEnd(s));



        // 8


        //static string comboString ( string a , string b )
        //{

        //    if ( a.Length > b.Length)
        //    {
        //        return b + a + b;
        //    }

        //    else
        //    {
        //        return a + b + a;
        //    }


        //}

        //Console.Write(" a satirini kiriting : ");

        //var a = Console.ReadLine();

        //Console.Write(" b satirini kiriting : ");

        //var b = Console.ReadLine();


        //Console.Write(comboString(a, b));



        // 9

        //static string nonStart(string a, string b)
        //{

        //    var newA = a.Substring(1);
        //    var newB = b.Substring(1);

        //    return newA + newB;

        //}

        //Console.Write(" a satirini kiriting : ");

        //var a = Console.ReadLine();

        //Console.Write(" b satirini kiriting : ");

        //var b = Console.ReadLine();


        //Console.Write(nonStart(a, b));




        // 10


        //static string nonStart(string a)
        //{

        //    var firstTwo = a.Substring(0,2);  
        //    var next = a.Substring(2);

        //    return next + firstTwo;

        //}

        //Console.Write(" a satirini kiriting : ");

        //var a = Console.ReadLine();


        //Console.Write(nonStart(a));




        // 11 


        //static string theEnd ( string s , bool front )
        //{

        //    if ( front )
        //    {
        //        return s.Substring(0, 1);
        //    }
        //    else
        //    {
        //        return s.Substring(s.Length - 1);
        //    }

        //}

        //Console.Write( " satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write("Front true yoki false kiriting: ");

        //bool front = bool.Parse(Console.ReadLine())


        //Console.Write( theEnd(s,front));



        // 12


        //static string nTwice ( string s , int n )
        //{

        //    var first = s.Substring( 0, n );
        //    var second = s.Substring( s.Length - n );

        //    return first + second;

        //}

        //Console.Write(" satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( " raqam kiriting : ");

        //var n = int.Parse( Console.ReadLine() );


        //Console.Write( nTwice(s,n));




        // 13


        //static string middleThree ( string s)
        //{

        //    var mid = s.Length / 2;

        //    return s.Substring(mid - 1, 3);


        //}

        //Console.Write(" satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( middleThree(s));



        // 14

        //static string conCat ( string a , string b )
        //{


        //    if ( a[a.Length - 1] == b[0] )
        //    {
        //        b = b.Substring(1);
        //    }

        //    return a + b;

        //}

        //Console.Write(" a satirini kiriting : ");

        //var a = Console.ReadLine();

        //Console.Write(" b satirini kiriting : ");

        //var b = Console.ReadLine();


        //Console.Write(conCat(a, b));



        // 15


        //static string lastTwo ( string s )
        //{

        //    var withoutLastTwo = s.Substring(0, s.Length - 2);

        //    var secondLast = s.Substring(s.Length - 2);
        //    var Last = s.Substring(s.Length - 1);

        //    return withoutLastTwo + Last + secondLast;

        //}

        //Console.Write( " satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( lastTwo(s));



        // 16


        //static string seeColor ( string s )
        //{

        //    if ( s.StartsWith("red"))
        //    {
        //        return "red";
        //    }
        //    else if ( s.StartsWith("blue"))
        //    {
        //        return "blue";
        //    }

        //    return "";

        //}

        //Console.Write( " satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( seeColor(s));



        // 17



        //static bool frontAgain( string s )
        //{

        //    if ( s.EndsWith(s.Substring (0, 2)))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //}
        //Console.Write(" satirn kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( frontAgain(s));




        // 18



        //static string minCat( string a , string b)
        //{


        //    int minLen = Math.Min(a.Length, b.Length);


        //    var aPart = a.Substring( a.Length - minLen );

        //    var bPart = b.Substring(b.Length - minLen);


        //    return aPart + bPart;


        //}

        //Console.Write(" a satirini kiriting : ");

        //var a = Console.ReadLine();

        //Console.Write(" b satirini kiriting : ");

        //var b = Console.ReadLine();


        //Console.Write(minCat(a, b));





        // 19



        //static string deFront(string s)
        //{

        //    var result = string.Empty;

        //    if ( s.Length > 0 && s[0] == 'a')
        //    {
        //        result = result + 'a';
        //    }

        //    if ( s.Length > 1 && s[1] == 'b')
        //    {
        //        result = result + 'b'; 
        //    }


        //    if ( s.Length > 2 )
        //    {

        //        result = result + s.Substring(2);

        //    }


        //    return result;

        //}

        //Console.Write(" s satirini kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write(deFront(s));






        // 20



        //static string withoutX( string s )
        //{


        //    if (s[0] == 'x' || s[s.Length - 1] == 'x' )
        //    {
        //        return s.Substring(1, s.Length - 2);
        //    }


        //    if (s[0] == 'x')
        //    {
        //        return s.Substring(1)
        //    } 

        //    if (s[s.Length - 1] == 'x')
        //    {
        //        return s.Substring(0, s.Length - 1);
        //    } 


        //    return s;

        //}

        //Console.Write(" s satirini kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write(withoutX(s));






        // 1.5.1


        // 1




        //Console.Write( " List lengthini kiriting : ");

        //var n = int.Parse( Console.ReadLine() );    

        //List<int> nums = new List<int>();


        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write( " List elementini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}

        //var counter = 0;

        //foreach ( int num in nums)
        //{
        //    if ( num >= 100 && num <= 999)
        //    {
        //        counter++;
        //    }
        //}

        //Console.Write(counter);




        // 2



        //Console.Write( " List lengthini kiriting : ");

        //var n = int.Parse( Console.ReadLine() );    

        //List<int> nums = new List<int>();


        //for ( int i = 0; i < n; i++ )
        //{

        //    Console.Write( " List lenghini kiriting");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //var counter  = 0;

        //foreach ( int num in nums )
        //{

        //    if ( num % 2 == 0 )
        //    {
        //        counter++;
        //    }
        //}

        //Console.Write(counter);





        // 3


        //List<int> nums = new List<int>();

        //Console.Write(" List lenghtini kiriting : ");
        //int n = int.Parse(Console.ReadLine());


        //for (int i = 0; i < n; i++)
        //{

        //    Console.Write(" List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));

        //}


        //var toqyigindi = 0;


        //foreach (int num in nums)
        //{

        //    if (num % 2 != 0)
        //    {
        //        toqyigindi += num;
        //    }

        //}
        //Console.Write(toqyigindi);



        // 6


        //Console.Write("List leghtini kiriting : ");

        //var n = int.Parse(Console.ReadLine());  

        //List<int> nums = new List<int>();   


        //for ( int i = 0; i < n; i++ )
        //{
        //    Console.Write(" List elementini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));
        //}


        //if ( n >= 2 )
        //{

        //    int temp = nums[0];

        //    nums[0] = nums[n - 1];

        //    nums[n - 1] = temp;


        //}

        //Console.Write( " Almashtirilgan list = "); 

        //foreach ( int num in nums )
        //{
        //    Console.Write( "" + num);
        //} 




        // 7


        //List<int> nums = new List<int>();

        //Console.Write(" listni lenghzini kiriting : ");

        //var n = int.Parse(Console.ReadLine());

        //for ( int i = 0; i< n; i++ )
        //{
        //    Console.Write( " List elementlarini kiriting : ");
        //    nums.Add(int.Parse(Console.ReadLine()));
        //}

        //var yigindi = 0;


        //for ( int i = 0; i < n && i < 3; i++ )
        //{
        //    yigindi += nums[i];
        //}

        //Console.Write( " boshidegi 3 ta belgi yigindisi : " + yigindi);






        
    }
}
