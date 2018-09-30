using System;

internal class Program
    {
        public static void Main(string[] args)
        {
            MyString.MyString str = new MyString.MyString("Привет ");
            MyString.MyString str1 = new MyString.MyString("как дета");
            str = str + str1;
            str.Replace("ет","ел");
            Console.WriteLine(str);
        }
    }