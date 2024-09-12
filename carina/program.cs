using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLi_1
{
    class Program
    {
        static void Main(string[] args)
        {
             try
            {
                var user = args[0];
                var pwd = Encrypt(args[1]);
            }
            catch  
            {

                Console.WriteLine("An error has occurred !!");
            } 
			
		Console.WriteLine("An error has occurred !!");
            
        }

         private static  string Encrypt(string plain)
        {
            return plain;
        } 
 	    
    }
}
