using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace TestDotNet
{    
    class Program
    {
        static void Main(string[] args)
        {
          
          string[] empNames = {"Ravi","Shiv Kumar","Chandan Mandal","Moosa Khan","Prathap","Krishna"};
          List<string> empFirstNames = new List<string>();

          
          var getAllEmpNamewithoutfullNames =  from name in empNames
                                  where !name.Contains(" ")
                                  select name;

          foreach(var i in getAllEmpNamewithoutfullNames){
            empFirstNames.Add(i);
          }                 

          var getEmpNamewithSpaces =  from name in empNames
                                  where name.Contains(" ")
                                  select name.Split(" ");

          foreach(var i in getEmpNamewithSpaces) {
            int firstnameFlag = 0;
            foreach(var j in i){              
              Console.WriteLine("firstName :" +j);                            
              if(firstnameFlag == 0){
                empFirstNames.Add(j);
                firstnameFlag=1;
              }                            
            }
          }                       

          //Finally print all the first names 
          foreach(var i in empFirstNames){
            Console.WriteLine(i);
          }
                    
          Console.WriteLine("testing");
          Console.ReadLine();
        }       

    }

}

