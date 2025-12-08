using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Dars4;

internal class Program
{


                          //         FILE  1.4.0



    // 1



    //static int GetCount(int firstIntValue, int secondIntValue)
    //{

    //    var result = firstIntValue + secondIntValue;

    //    return result;


    //}


    static void Main(string[] args)
    {


        //Console.Write(" 1 chi soni kiriting : ");

        //var firstIntValue = int.Parse(Console.ReadLine());


        //Console.Write(" 2 chi soni kiriting : ");

        //var secondIntValue = int.Parse(Console.ReadLine());

        //Console.WriteLine( " Natija = " + GetCount(firstIntValue , secondIntValue));




        // 2


        //static string replace( string s )
        //{

        //    var result = "";


        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == 'x')
        //        {
        //            result += 'y';
        //        }

        //        else if (s[i] == 'y')
        //        {
        //            result += 'z';
        //        }

        //        else
        //        {
        //            result += s[i];
        //        }


        //    }

        //            return result;

        //}


        //Console.Write( " satir kiriting : "); 

        //var s = Console.ReadLine();

        //Console.WriteLine(" Natija : " + replace(s));



        // 3


        //static int GetCout(string s )
        //{

        //    var counter = 0;


        //    for ( int i = 0 ; i < s.Length ; i++ )
        //    {

        //        if (char.IsLower(s[i]))
        //        {
        //            counter++;
        //        }


        //    }
        //    return counter;


        //}


        //Console.Write(" satir kiriting : "); 

        //var s = Console.ReadLine();

        //Console.WriteLine( " Natija = " + GetCout(s));




        // 4


        //static int GetCoutValue( int firstIntValue , int secondIntValue )
        //{

        //    var counter  = 0;

        //    for ( int i = firstIntValue + 1 ; i < secondIntValue; i++ )
        //    {

        //        if ( i % 2 != 0 )
        //        {
        //            counter++;
        //        }

        //    }

        //    return counter;

        //}



        //Console.Write(" 1 soni kiriting : ");

        //var firstIntValue = int.Parse( Console.ReadLine() );    


        //Console.Write(" 2 soni kiriting : ");

        //var secondIntValue = int.Parse( Console.ReadLine() );


        //Console.Write( " Natija = " + GetCoutValue( firstIntValue , secondIntValue));



        // 5



        // 6


        //static bool checkS(string s )
        //{

        //    for ( int i = 0; i < s.Length; i++ )
        //    {

        //        if (!char.IsDigit(s[i]))
        //        {
        //            return false;
        //        }

        //    }

        //    return true;

        //}

        //Console.Write( " 1 ta satir kiriting : ");

        //var s = Console.ReadLine();


        //Console.Write( checkS(s));


        // 7


        //static string cheknum( int num )
        //{

        //    var counter = 0;

        //    for ( int  i = 1; i <= num; i++ )
        //    {

        //        if ( num  % i == 0 )
        //        {
        //            counter++;
        //        }

        //    }

        //    if ( counter == 2 )
        //    {
        //        return " tub son ";
        //    }

        //    return " tub son emas !";

        //}



        //Console.Write( " 1 ta son kiriitng : "); 

        //var num = int.Parse( Console.ReadLine() );


        //Console.Write( cheknum(num));



        // 8


        //static string reverseString( string s)
        //{

        //    var reversed = "";  


        //    for ( int i = s.Length - 1 ; i >= 0; i-- )
        //    {
        //        reversed += s[i];
        //    }

        //    return reversed;

        //}




        //Console.Write( " 1 ta satir kiriting : "); 

        //var s = Console.ReadLine();

        //Console.Write( " Natija = " + reverseString(s));



        // 9


        //static int countSpace (string s)
        //{

        //    var counter = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (char.IsWhiteSpace(s [i]))
        //        {
        //            counter++;
        //        }

        //    }

        //    return counter;


        //}



        //Console.Write( " 1 ta satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( " Natija = " + countSpace(s));


        // 10










        // 11


        //static bool chekS(string s)
        //{

        //    for ( int i = 0 ; i < s.Length; i++ )
        //    {

        //        if (!char.IsDigit(s[i]))
        //        {
        //            return false;
        //        }

        //    }

        //    return true;

        //}


        //Console.Write( " 1 ta satiri kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(chekS(s));


        // 12


        //static int countIsDigit(string s)
        //{

        //    var counter = 0;

        //    for( int i = 0 ; i < s.Length; i++ )
        //    {

        //        if (char.IsDigit(s[i]))
        //        {
        //            counter++;
        //        }

        //    }

        //    return counter;

        //}

        //Console.Write(" 1 ta satir kiriting :");

        //var s = Console.ReadLine();

        //Console.Write( countIsDigit(s));


        // 13


        //static int countIsDigit(string s)
        //{

        //    var counter = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {

        //        if (char.IsUpper(s[i]))
        //        {
        //            counter++;
        //        }

        //    }

        //    return counter;

        //}

        //Console.Write(" 1 ta satir kiriting :");

        //var s = Console.ReadLine();

        //Console.Write(countIsDigit(s));


        // 14


        //static bool checkIsUpper(string s )
        //{

        //    for ( int i =  0; i < s.Length; i++ )
        //    {
        //        if (!char.IsUpper(s[i]))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;

        //}

        //Console.Write(" 1 ta satiri kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(checkIsUpper(s));


        // 15

        //static bool checkIsLower(string s)
        //{

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (!char.IsLower(s[i]))
        //        {
        //            return false;
        //        }
        //    }

        //    return true;

        //}

        //Console.Write(" 1 ta satiri kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(checkIsLower(s));


        // 16


        //static string changeUpper(string s)
        //{

        //    var result = "";

        //    for ( int i  = 0; i < s.Length; i++ )
        //    {
        //        result += char.ToUpper(s[i]);
        //    }
        //    return result;
        //}

        //Console.Write(" 1 ta satiri kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(changeUpper(s));


        // 17


        //static int countOk(string s)
        //{

        //    var counter = 0;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == 'o' && s[i + 1] == 'k')
        //        {
        //            counter++;
        //        }
        //    }
        //    return counter;
        //}

        //Console.Write(" 1 ta satiri kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(countOk(s));




        // 18


        //static string changeC(string s)
        //{

        //    var result = "";

        //    for ( int i  = 0; i < s.Length; i++ )
        //    {

        //        if (char.IsLower(s[i]))
        //        {
        //            result += '*';
        //        }
        //        else
        //        {
        //            result += s[i];
        //        }

        //    }

        //    return result;

        //}


        //Console.Write(" 1 ta satiri kiriting : ");

        //var s  = Console.ReadLine();

        //Console.Write(changeC(s));


        // 19


        //static string changeLower( string s)
        //{

        //    var result = "";

        //    for ( int i = 0; i < s.Length; i++ )
        //    {
        //        result += char.ToLower(s[i]);
        //    }

        //    return result;
        //}

        //Console.Write( " 1 ta satir kiriting : ");

        //var s  = Console.ReadLine();

        //Console.Write(changeLower(s));


        // 20


        //static string changeUpper( string s)
        //{

        //    var result = "";

        //    for ( int i = 0; i < s.Length; i++ )
        //    {
        //        result += char.ToUpper(s[i]);
        //    }

        //    return result;
        //}

        //Console.Write( " 1 ta satir kiriting : ");

        //var s  = Console.ReadLine();

        //Console.Write(changeUpper(s));


        // 21


        //static int countS(string s)
        //{

        //    var counter = 0;

        //    for ( int i =  0; i < s.Length; i++ )
        //    {
        //        if ( s[i] == '@')
        //        {
        //            counter++;
        //        }
        //    }
        //    return counter;
        //}

        //Console.Write(" 1 ta satir kiriting : ");

        //var s  = Console.ReadLine();

        //Console.Write(countS(s));




        //         FILE  1.4.1




        // 1

        //static string helloName(string name)
        //{

        //    return " Hello " + name;

        //}


        //Console.Write(" ism kiriting : ");

        //var name = Console.ReadLine();

        //Console.Write(helloName(name));


        // 2

        //static string makeAbba(string str1 , string str2)
        //{

        //    return str1 + str2 + str2 + str1;

        //}

        //Console.Write(" 1 chi satiri kiriting : ");

        //var str1 = Console.ReadLine();

        //Console.Write(" 2 chi satiri kiriting : ");

        //var str2 = Console.ReadLine();


        //Console.Write(makeAbba(str1 , str2));



        // 3

        //static string makeOutWord(string str1 , string str2)
        //{

        //    return str1.Substring(0 , 2) + str2 + str1.Substring( 2 );

        //}

        //Console.Write(" 1 chi satiri kiriting : ");

        //var str1 = Console.ReadLine();

        //Console.Write(" 2 chi satiri kiriting : ");

        //var str2 = Console.ReadLine();


        //Console.Write(makeOutWord(str1 , str2));


        // 4

        //static string extraEnd(string s)
        //{

        //    if (s.Length < 2)
        //    {
        //        return "Xato: Satr uzunligi kamida 2 bo'lishi kerak!";
        //    }

        //    var lastTwo = s.Substring(s.Length - 2);
        //    return lastTwo + lastTwo + lastTwo;

        //}

        //Console.Write( " kamida 2 ga teng bolgan satir kiriting :");

        //var s = Console.ReadLine();

        //Console.Write(extraEnd(s));


        // 5

        //static string firstTwo(string s)
        //{

        //    if (s.Length < 2)
        //    {
        //        return s;
        //    }


        //    return s.Substring(0, 2);

        //}

        //Console.Write( " kamida 2 ga teng bolgan satir kiriting :");

        //var s = Console.ReadLine();

        //Console.Write(firstTwo(s));


        // 6

        //static string firstHalf(string s)
        //{

        //    if (s.Length % 2 != 0)
        //    {
        //        return " xato : Juft uzunlikdagi satr kiriting: ";
        //    }

        //    var half = s.Length / 2;
        //    return s.Substring(0, half);


        //}

        //Console.Write(" Juft uzunlikdagi satr kiriting :");

        //var s = Console.ReadLine();

        //Console.Write(firstHalf(s));


        // 7

        //static string withoutEnd(string s)
        //{

        //    if (s.Length < 2)
        //    {
        //        return " xato : Satr uzunligi kamida 2 bo'lishi kerak! ";
        //    }

        //    return s.Substring(1, s.Length - 2);
        //}

        //Console.Write(" Kamida 2ta harfdan iborat satr kiriting :");

        //var s = Console.ReadLine();

        //Console.Write(withoutEnd(s));


        // 8

        //static string comboString(string s1 , string s2)
        //{ 

        //    if ( s1 < s2 )
        //    {
        //        return s1 + s2 + s1;
        //    }

        //    else if ( s2 < s1 )
        //    {
        //        return s2 + s1 + s2;
        //    }

        //}

        //Console.Write(" 1 chi satri kiriting :");

        //var s1 = Console.ReadLine();

        //Console.Write(" 2 chi satri kiriting :");

        //var s2 = Console.ReadLine();


        //Console.Write(comboString(s1 , s2));


        // 9


        //static string nonStart(string s1 , string s2)
        //{ 

        //    if ( s1.Length < 1 )
        //    {
        //        return " Xato : Uzunligi kamida 1ga teng boolish kerak ! ";
        //    }

        //    if ( s2.Length < 1 )
        //    {
        //        return " Xato : Uzunligi kamida 1ga teng boolish kerak ! ";
        //    }

        //    return s1.Substring(1) + s2.Substring(1);

        //}

        //Console.Write(" 1 chi satri kiriting :");

        //var s1 = Console.ReadLine();

        //Console.Write(" 2 chi satri kiriting :");

        //var s2 = Console.ReadLine();


        //Console.Write(nonStart(s1 , s2));


        // 10

        //static string left2(string s)
        //{ 

        //    var firstTwo = s.Substring(0, 2);

        //    return s.Substring(2) + firstTwo;

        //}

        //Console.Write(" satr kiriting :");

        //var s = Console.ReadLine();


        //Console.Write(left2(s));



    }
}
