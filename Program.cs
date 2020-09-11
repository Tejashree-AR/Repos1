using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack my = new Stack();
            my.Push("--------------->Sunday"); 
            my.Push("--------------->Monday");
            my.Push("--------------->Tuesday");
            my.Push("--------------->Wedenesday");
            my.Push("--------------->Thuresday");
            my.Push("--------------->Friday");
            my.Push("--------------->Satuerday");
                   
            Console.WriteLine($"Leangth of the Stack is= { my.Count}");
            Console.WriteLine("**************Items in Stack Are as Follows************");
            Console.WriteLine($"Peek of the Stack is= { my.Peek()}"); //Always Give Element at the Top.
            
            foreach (var item in my)
            {
                Console.WriteLine(item);
               
            }
            Console.WriteLine($"Stack Has Friday? =>{my.Contains("--------------->Friday")}");
           Console.WriteLine($" 1st Pop Up ={my.Pop()}");
            Console.WriteLine($" 2st Pop Up ={my.Pop()}");
            Console.WriteLine($" 3st Pop Up ={my.Pop()}");



            Console.WriteLine($"Length of the Stack after Pop ={my.Count}");
            Console.WriteLine($"Stack Has Friday? =>{my.Contains("--------------->Friday")}");
           // Console.WriteLine($"Stack Has Sunday=>{my.Contains("Sunday")}");



           
            my.Clear();
            Console.WriteLine("STACK IS EMPTY");
            Console.ReadKey();


        }
       

        
    }
}
