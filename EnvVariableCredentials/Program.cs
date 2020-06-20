using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvVariableCredentials
{
    class Program
    {
        static void Main(string[] args)
        {

            //get values from user variables, the values need to be present in system.
            var _usr = System.Environment.GetEnvironmentVariable("test_usr", EnvironmentVariableTarget.User);
            var _pwd = System.Environment.GetEnvironmentVariable("test_pwd", EnvironmentVariableTarget.User);

            Console.WriteLine("Username : " +_usr);
            Console.WriteLine("Password : " +_pwd);

        }
    }
}
