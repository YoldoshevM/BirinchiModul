using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;

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



        // 11


        //static string theEnd(string s , bool front)
        //{

        //    if (front)
        //    {
        //        return s.Substring(0, 1);
        //    }
        //    else
        //    {
        //        return s.Substring(s.Length - 1);
        //    }


        //}

        //Console.Write( " 1 ta satr kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( " Front (true/false) ni kiriting : ");

        //var front = bool.Parse(Console.ReadLine());


        //Console.Write( " Natija = " + theEnd(s , front));


        // 12


        //static string nTwice(string s, int num)
        //{

        //    string first = s.Substring(0, num);
        //    string second = s.Substring(s.Length - num , num);

        //    return (first + second);

        //}

        //Console.Write(" 1 ta satr kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(" 1 ta son kiriting : ");

        //var num = int.Parse(Console.ReadLine());


        //Console.Write(" Natija = " + nTwice(s, num));


        // 13


        //static string middleThree(string s)
        //{

        //    if ( s.Length % 2 == 0 )
        //    {
        //        Console.Write(" Xato :  Satr toq uzulikda bolishi kerak !");
        //    }

        //    int mid = s.Length / 2;

        //    return s.Substring(mid - 1, 3);

        //}

        //Console.Write(" toq uzunlikdagi satr kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( " Naitja = " + middleThree(s));



        // 14






        // 15


        //static string lastTwo(string s)
        //{

        //    string withoutLastTwo = s.Substring( 0 , s.Length - 2 );
        //    string secondLast = s.Substring(s.Length - 2);
        //    string Last = s.Substring(s.Length - 1);

        //    return withoutLastTwo + Last + secondLast;
        //}

        //Console.Write(" 1 ta satir kiriting :");

        //var s = Console.ReadLine();

        //Console.Write( " Natija = " + lastTwo(s));



        // 16



        //static string seeColor( string s)
        //{

        //    if ( s.Length >= 3 && s.Substring( 0 , 3 ) == "red")
        //        return "red";

        //    if (s.Length >= 4 && s.Substring(0, 4) == "blue")
        //        return " blue";

        //    return "";

        //}


        //Console.Write(" Satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(seeColor(s));



        // 17


        //static bool frontAgain(string s )
        //{

        //    if ( s.Length < 2 )
        //    {
        //        return false;
        //    }


        //    var first2 = s.Substring(0, 2);
        //    var last2 = s.Substring(s.Length - 2 , 2);

        //    return first2 == last2;

        //}


        //Console.Write(" Satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(frontAgain(s));


        // 18








        // 19

        //static string deFront(string s)
        //{


        //    var result = "";

        //    if ( s.Length > 0 &&  s[0] == 'a')
        //    {
        //        result = result + 'a';
        //    }

        //    if ( s.Length > 1 &&  s[1] == 'b')
        //    {
        //        result = result + 'b';
        //    }

        //    if ( s.Length > 2 )
        //    {
        //        result = result + s.Substring(2);
        //    }


        //    return result;

        //}



        //Console.Write(" Satir kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write(deFront(s));




        // 20


        //static string WithouX(string s)
        //{



        //        if (s[0] == 'x' && s[s.Length - 1 ] == 'x')
        //        {
        //            return s.Substring(1, s.Length - 2);
        //        }

        //        if ( s[0] == 'x' )
        //        {
        //            return s.Substring(1);
        //        }

        //        if (s[s.Length - 1] == 'x')
        //        {
        //            return s.Substring(0, s.Length - 1);
        //        }

        //        return s;



        //    }

        //Console.Write(" Satir kiriting : "); 

        //var s = Console.ReadLine();


        //Console.Write(WithouX(s));
        //}






        // 21


        //static string WithoutDigit(string s)
        //{

        //    var res = string.Empty;


        //    for (int i = 0; i < s.Length; i++)
        //    {

        //        if (!char.IsDigit(s[i]))
        //        {

        //            res += s[i];

        //        }

        //    }
        //    return res;

        //}


        //static void Main(string[] args)
        //{

        //    Console.Write(" Satir kiriting : ");

        //    var s = Console.ReadLine();

        //    Console.WriteLine(WithoutDigit(s));



        //}




        // 22


        //static string WithoutIsUpper(string s1)
        //{


        //    var res = string.Empty;

        //    for (int i = 0; i < s1.Length; i++)
        //    {

        //        if (!Char.IsUpper(s1[i]))
        //        {

        //            res += s1[i];

        //        }

        //    }

        //    return res;

        //}


        //    Console.Write(" Satir kiriting : ");

        //    var s1 = Console.ReadLine();

        //    Console.Write(WithoutIsUpper(s1));



        // 23


        //static string WithoutIsLower(string s1)
        //{


        //    var res = string.Empty;

        //    for (int i = 0; i < s1.Length; i++)
        //    {

        //        if (!Char.IsLower(s1[i]))
        //        {

        //            res += s1[i];

        //        }

        //    }

        //    return res;

        //}


        //Console.Write(" Satir kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(WithoutIsLower(s1));



        // 24


        //static string WithoutChar(string s1)
        //{


        //    var res = string.Empty;

        //    for (int i = 0; i < s1.Length; i++)
        //    {

        //        if ( s1[i] != '@')
        //        {

        //            res += s1[i];

        //        }

        //    }

        //    return res;

        //}


        //Console.Write(" Satir kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(WithoutChar(s1));


        // 25

        //static string WithoutChar(string s1)
        //{


        //    var res = string.Empty;

        //    for (int i = 0; i < s1.Length; i++)
        //    {

        //        if (s1[i] != ' ')
        //        {

        //            res += s1[i];

        //        }

        //    }

        //    return res;

        //}


        //Console.Write(" Satir kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(WithoutChar(s1));



        //         FILE  1.4.2



        // 1



        //static string CreateString( int n1 , int n2 , string s1  , string s2 )
        //{

        //    if ( n1 > s1.Length )
        //    {
        //        n1 = s1.Length;
        //    }

        //    if ( n2 > s2.Length )
        //    {
        //        n2 = s2.Length;
        //    }




        //    var part1 = s1.Substring(0, n1);
        //    var part2 = s2.Substring( s2.Length - n2 , n2);

        //    return part1 + part2;
        //}



        //Console.Write( " 1 chi satirni kiriting : ");

        //var s1  = Console.ReadLine();

        //Console.Write( " 2 chi satirni kiriting : ");

        //var s2  = Console.ReadLine();


        //Console.Write( " 1 chi int ni kiriting : "); 

        //var n1 = int.Parse(Console.ReadLine());


        //Console.Write( " 2 chi int ni kiriting : ");

        //var n2 = int.Parse(Console.ReadLine());



        //Console.Write(CreateString(n1, n2, s1, s2));    




        // 2



        //static string DoubleChar(string s , char c )
        //{

        //    var result = string.Empty;

        //    for ( int i = 0; i < s.Length; i++ )
        //    {

        //        if (s[i] == c )
        //        {
        //            result += c.ToString() + c.ToString();
        //        }
        //        else
        //        {
        //            result += s[i];
        //        }

        //    }

        //    return result;
        //}

        //Console.Write( " 1 ta belgi kiriting : ");

        //var c = char.Parse(Console.ReadLine());


        //Console.Write( " Satir kiriting : "); 

        //var s = Console.ReadLine();


        //Console.Write(" Natija : " + DoubleChar(s,c));


        // 3



        //static string InsertBeforeChar(string s1, string s2, char c)
        //{

        //    var result = string.Empty;


        //    for (int i = 0; i < s1.Length; i++)
        //    {

        //        if (s1[i] == c)
        //        {

        //            result += s2;
        //            result += c;

        //        }

        //        else
        //        {
        //            result += s1;
        //        }

        //    }
        //    return result;
        //}


        //Console.Write(" C belgini kiriting : ");

        //var c = char.Parse(Console.ReadLine());

        //Console.Write(" s1 satirini kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(" s2 satirini kiriting : ");

        //var s2 = Console.ReadLine();


        //Console.Write(" Natija : " + InsertBeforeChar(s1, s2, c));



        // 4


        //static string InsertBeforeChar(string s1, string s2, char c)
        //{

        //    var result = string.Empty;


        //    for (int i = 0; i < s1.Length; i++)
        //    {

        //        result += s1[i];

        //        if (s1[i] == c)
        //        {

        //            result += s2;

        //        }

        //        else
        //        {
        //            result += s1;
        //        }

        //    }
        //    return result;
        //}


        //Console.Write(" C belgini kiriting : ");

        //var c = char.Parse(Console.ReadLine());

        //Console.Write(" s1 satirini kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(" s2 satirini kiriting : ");

        //var s2 = Console.ReadLine();


        //Console.Write(" Natija : " + InsertBeforeChar(s1, s2, c));



        // 5


        //static int CountS2 ( string s1 , string s2 )
        //{


        //    var counterS2 = 0;


        //    for( int i = 0; i < s1.Length - s2.Length; i++ )
        //    {

        //        if ( s1.Substring( i , s2.Length) == s2)
        //        {
        //            counterS2++;
        //        }


        //    }

        //    return counterS2;
        //}

        //Console.Write("S1 satrini kiriting: ");
        //string s1 = Console.ReadLine();

        //Console.Write("S2 satrini kiriting: ");
        //string s2 = Console.ReadLine();


        //Console.Write( " Natija : " + CountS2(s1 ,s2));   



        // 6



        //static string RemoveFirstS2( string s1 , string s2 )
        //{


        //    int index = s1.IndexOf(s2);


        //    if ( index == -1 )
        //    {
        //        return s1;

        //    }



        //    return s1.Remove(index , s2.Length );

        //}

        //Console.Write( " 1 satirni kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write( " 2 satirni kiriting : ");

        //var s2 = Console.ReadLine();


        //Console.Write(" Natija : " + RemoveFirstS2(s1 ,s2));




        // 7


        //static string ResmoveLastS2 ( string s1 , string s2 )
        //{

        //    var index = s1.LastIndexOf(s2);


        //    if ( index == -1 )
        //    {
        //        return s1;
        //    }


        //    return s1.Remove(index, s2.Length);

        //}


        //Console.Write( " 1 chi strni kiriting : ");

        //var s1 = Console.ReadLine();


        //Console.Write( " 2 chi strni kiriting : ");

        //var s2 = Console.ReadLine();

        //Console.Write( " Natija  : " + ResmoveLastS2( s1 , s2 ));





        // 8



        //static string RemoveAllS2(string s1 , string s2 )
        //{


        //    return s1.Replace(s2, "");

        //}

        //Console.Write(" 1 chi satirni kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(" 2 chi satirni kiriting : ");

        //var s2 = Console.ReadLine();


        //Console.Write( " Natija : " + RemoveAllS2( s1 ,s2 ));



        // 9


        //static string ReplaceFirstS2 ( string s1 , string s2 , string s3 )
        //{


        //    var index = s1.IndexOf(s2);


        //    if ( index == -1 )
        //    {
        //        return s1;
        //    }



        //    s1 = s1.Remove(index, s2.Length);
        //    s1 = s1.Insert(index, s3);


        //    return s1;


        //}


        // 10

        
        //static string RemoveLastS2( string s1 , string s2 , string s3 )
        //{


        //    var index = s1.LastIndexOf(s2);


        //    if ( index == -1 )
        //    {
        //        return s1;
        //    }


        //    s1 = s1.Remove(index , s2.Length);
        //    s1 = s1.Insert(index, s3);



        //}

        //Console.Write(" 1 chi satirni kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(" 2 chi satirni kiriting : ");

        //var s2 = Console.ReadLine();

        //Console.Write(" 3 chi satirni kiriting : ");

        //var s3 = Console.ReadLine();


        //Console.Write( " Natija = " + RemoveLastS2( s1 , s2  , s3 ));



        // 11


        //static string ReplaceS2ToS3(string s1 , string s2 , string s3 )
        //{


        //    var index = s1.IndexOf(s2);

            
        //    return s1.Replace(s2, s3);




        //}

        //Console.Write(" 1 chi satirni kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write(" 2 chi satirni kiriting : ");

        //var s2 = Console.ReadLine();

        //Console.Write(" 3 chi satirni kiriting : ");

        //var s3 = Console.ReadLine();


        //Console.Write(" Natija = " + ReplaceS2ToS3(s1, s2, s3));



        // 12


        //static string BetweenSpaces(string s)
        //{

        //    var fistSpace = s.IndexOf(" ");
        //    var secondSpace = s.IndexOf(" " , fistSpace + 1);


        //    if (secondSpace == -1)
        //    {
        //        return "";
        //    }

        //    return s.Substring(fistSpace + 1 , secondSpace - fistSpace - 1);


        //}

        //Console.Write( " 1 strni kiriting : ");

        //var s = Console.ReadLine();

        //Console.Write( " Natija : " + BetweenSpaces(s));



        // 13


        //static bool catDog ( string s1)
        //{

        //    var catCount = 0;
        //    var dogCount = 0;


        //    for ( int i = 0; i <= s1.Length - 3; i++ )
        //    {

        //        if (s1[i] == 'c' && s1[i+1] == 'a' && s1[i+2] == 't')
        //        {
        //            catCount++;
        //        }

        //        if (s1[i] == 'd' && s1[i + 1] == 'o' && s1[i + 2] == 'g')
        //        {
        //            dogCount++;
        //        }

        //    }

        //    bool teng = (catCount == dogCount); 

        //    return teng;

        //}

        //Console.Write( " strni kiriting : ");

        //var s1 = Console.ReadLine();

        //Console.Write( " Natija = " + catDog(s1));



        // 14





        // 15



        //static bool EndOther( string a , string b )
        //{


        //    a = a.ToUpper();
        //    b = b.ToUpper();

        //    return a.EndsWith( b );


        //}

        //Console.WriteLine(EndOther("Hiabc", "abc"));  // true
        //Console.WriteLine(EndOther("abc", "Hiabc"));  // false





        // 17



        //static string MixString( string a , string b )
        //{

        //    var res = string.Empty;

        //    var minLength = Math.Min( a.Length, b.Length );


        //    for ( int i = 0; i < minLength; i++ )
        //    {

        //        res += a[i];
        //        res += b[i];

        //    }

        //    if ( a.Length > minLength )
        //    {
        //        res += b.Substring(minLength);
        //    }

        //    if ( b.Length > minLength )
        //    {
        //        res += b.Substring(minLength);
        //    }

        //    return res;

        //}


        //Console.WriteLine(MixString("abc", "xyz"));     // axbycz
        //Console.WriteLine(MixString("Hi", "There"));   // HTihere
        //Console.WriteLine(MixString("xxxx", "There")); // xTxhxexre



        // 18



        //static string RepeatEnd ( string s , int n )
        //{

        //    var res = string.Empty;


        //    var endPart = s.Substring ( s.Length - n );



        //    for ( int i = 0; i < n; i++ )
        //    {

        //        res += endPart;

        //    }
                
        //    return res;

        //}

        //Console.WriteLine(RepeatEnd("Hello", 3)); // llollollo
        //Console.WriteLine(RepeatEnd("Hello", 2)); // lolo
        //Console.WriteLine(RepeatEnd("Hello", 1)); // o



        // 19


        //static string repeatFront( string s , int n )
        //{

        //    var res = string.Empty;

        //    for ( int i = n; i > 0; i-- )
        //    {

        //        res += s.Substring(0, i);

        //    }
        //    return res;

        //}

        //Console.WriteLine(repeatFront("Chocolate" , 4));
        //Console.WriteLine(repeatFront("Chocolate" , 3));



        // 20


        //static string RepeatSeparator ( string word , string sep , int n )
        //{

        //    var res = string.Empty;


        //    for ( int i = 0; i < n; i++ )
        //    {

        //        res += word;

        //        if ( i < n - 1 )
        //        {
        //            res += sep;
        //        }

        //    }

        //    return res;

        //}

        //Console.WriteLine(RepeatSeparator("Word", "X", 3));  // WordXWordXWord
        //Console.WriteLine(RepeatSeparator("This", "And", 2)); // ThisAndThis
        //Console.WriteLine(RepeatSeparator("This", "And", 1)); // This



        // 21


        //static bool PrefixAgain(string s , int n )
        //{

        //    var firtN = s.Substring(0 , n);
        //    var QoganQism = s.Substring(n);


        //    return QoganQism.Contains(firtN);

        //}
        //Console.WriteLine(PrefixAgain("abXYabc", 1)); // true
        //Console.WriteLine(PrefixAgain("abXYabc", 2)); // true
        //Console.WriteLine(PrefixAgain("abXYabc", 3)); // false



        // 22


        //static bool XyzMiddle ( string s )
        //{


        //    var len = s.Length;
        //    var xyzlen = 3;


        //    for ( var i = 0; i <= len - xyzlen; i++ )
        //    {

        //        if ( s.Substring( i , xyzlen) == "xyz")
        //         {

        //            var left = i;

        //            var right = len - ( i + xyzlen );


        //            if ( Math.Abs(left - right) <= 1)
        //            {
        //                return true;
        //            }


        //        }

        //    }
        //        return false;

        //}

        //Console.WriteLine(XyzMiddle("AAxyzBB")); // true
        //Console.WriteLine(XyzMiddle("AxyzBB"));  // true
        //Console.WriteLine(XyzMiddle("AxyzBBB")); // false



        // 23


        //static string GetSandwich(string s)
        //{

        //    var bread = "bread";

        //    var first = s.IndexOf(bread);
        //    var last = s.LastIndexOf(bread);


        //    if (first == -1 || first == last)
        //    {

        //        return "";

        //    }

        //    var start = first + bread.Length; 
        //    var length = last - start; 

        //    return s.Substring(start, length);


        //}

        //Console.WriteLine(GetSandwich("breadjambread"));      // "jam"
        //Console.WriteLine(GetSandwich("xxbreadjambreadyy"));  // "jam"
        //Console.WriteLine(GetSandwich("xxbreadyy"));          // ""



        // 24


        //static bool SameStarChar( string s )
        //{

        //    for ( int i = 1; i < s.Length - 1; i++ ) 
        //    {

        //        if( s[i] == '*' )
        //        {
        //            if( s[i - 1] != s[i + 1] )
        //            {
        //                return false;
        //            }
        //        }


        //    }

        //    return true;

        //}

        //Console.WriteLine(SameStarChar("xy*yzz"));  // true
        //Console.WriteLine(SameStarChar("xy*zzz"));  // false
        //Console.WriteLine(SameStarChar("*xa*az"));  // true




        // 25
























































    }
}

