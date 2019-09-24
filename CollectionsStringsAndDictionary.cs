using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1 = "ravi";
            string val2 = "sam";
            //string[] str = { "ravi", "ram" };
            string[] str = { val1,val2}; //initialize array elements

            Dictionary<string, string> UserData = new Dictionary<string, string>();
            UserData.Add("val1", "Parnel");
            UserData.Add("val2", "steve");
            UserData.Add("error", null);

            //printContent(str);
            printContent(UserData);

            //str[1] = "hello";
            //foreach (var i in str)
            //{
            //    Console.WriteLine("str content:" + i);
            //}
            Console.ReadLine();
             
        }

        public static void printContent(Dictionary<string,string> usernames)
        {
            /*
             * Both the below foreach would work                         
            */

            //foreach (var i in usernames)
            //{
            //    if (i.Key == "error")
            //    {
            //        if(!string.IsNullOrEmpty(i.Value))
            //        {
            //            Console.WriteLine("Error:" + i.Value);
            //        }
            //    }                  
            //    else
            //    {
            //        //Console.WriteLine("Print All");
            //        Console.WriteLine("key:"+i.Key+ "value:"+i.Value);
            //    }
            //}            

            foreach( KeyValuePair<string,string> kvp in usernames)
            {
                if(kvp.Key == "error")
                {                    
                    if(!string.IsNullOrEmpty(kvp.Value))
                    {
                        Console.WriteLine("Error:" + kvp.Value);
                    }
                }
                else
                {
                     //Console.WriteLine("Print All");
                     Console.WriteLine("key:"+kvp.Key+ "value:"+kvp.Value);
                }
            
            }            
            
        }

    }
}
