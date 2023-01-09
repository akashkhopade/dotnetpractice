using System.Data.SqlClient;
using System;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //select comment code: ctrl+k+c
            //select comment code: ctrl+k+u

            //SqlConnection connection;
            //SqlCommand statement;
            //SqlDataReader resultset;

            //C# Code

            int i = 100;
            int j = 200;
            int result = i + j;

            Console.WriteLine(result);
            Console.ReadLine(); //proceed when new line character comes up on screen ..i.e. enter

            //Note: On Developer Command Prompt, Use ildasm <EXE path> to see the MSIL Code
            //ildasm means Intermediate Language Dis ASseMbler
        }
    }
}
