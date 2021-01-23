using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'decryptPassword' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string decryptPassword(char s)
    {
        s = Console.ReadLine();

        for (int i = 0; i < s; i++)
        {
            bool result;
            result == char.IsLower(s);

            if(s[i] == )


        }




        return s;



    }

}

class Solution
{
    public static void Main(string[] args)
    {
       

        string s = Console.ReadLine();

        string result = Result.decryptPassword(s);

    }
}