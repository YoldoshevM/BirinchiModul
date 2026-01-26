using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _2._10_Dars.Extensions;

public class StringExtensions
{

    public static (char, char , int , string , string) GetString(this string text)
    {


        var findFirst = text.Substring(0);

        var findLast = text.Substring(text.Length - 1, 1);

        var Lenght = text.Length;

        var FirstThree = text.Substring(0, 3);

        var LastThree = text.Substring(text.Length - 3, 3);


    }



}
