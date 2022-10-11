using System;
using System.Collections.Generic;
using System.Linq;
using OS_Lab1.Properties;

namespace OS_Lab1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Kernel kernel = new Kernel();
            kernel.ShowAll();
            Console.WriteLine();
            
            MyStack stack = new MyStack();
            
            stack.Push(new Arg("name_object", "String", "HELLO WORLD"));
            kernel.Call(0, stack);
            kernel.Call(0, stack);
            
            stack.Push(new Arg("name_object", "int", "10"));
            kernel.Call(0, stack);
            
            stack.Push(new Arg("name_object", "String", "HELLO WORLD"));
            stack.Push(new Arg("name_object", "String", "HELLO WORLD"));
            kernel.Call(0, stack);
            
            stack.Push(new Arg("start_point", "String", "Hello"));
            stack.Push(new Arg("end_point", "String", "world"));
            kernel.Call(1, stack);
            
            stack.Push(new Arg("first_value", "int", "2"));
            stack.Push(new Arg("second_value", "int", "3"));
            kernel.Call(2, stack);
            
            stack.Push(new Arg("first_value", "int", "1"));
            stack.Push(new Arg("second_value", "int", "2"));
            stack.Push(new Arg("third_value", "int", "3"));
            kernel.Call(3, stack);
            
            stack.Push(new Arg("values", "List<int>", "[1, 2, 3]"));
            kernel.Call(4, stack);
            
            stack.Push(new Arg("values", "List<int>", "[1, 2, 3]"));
            kernel.Call(5, stack);

            List<String> s = new List<string>();
            s.Add("ds");
            s.Add("DS");
            Console.WriteLine(String.Join(" ", s));

        }
    }
}