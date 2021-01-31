using Dict;
using System;
using System.Collections.Generic;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDict<string, string> userDict = new UserDict<string, string>();

            userDict.Add("1", "Türkçe");
            userDict.Add("2", "English");
            userDict.Add("3", "Deutsche");
            userDict.Add("4", "français");

            userDict.ShowKeysValues();




        }
    }
}