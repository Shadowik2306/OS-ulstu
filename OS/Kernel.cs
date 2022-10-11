using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using OS_Lab1.Properties;

namespace OS_Lab1
{
    public class Kernel
    {
        static List<SysCall> ListSysCall = new List<SysCall>();
        
        public Kernel() {
            ListSysCall.Add(new SysCall(0, "echo", new List<Arg>
            {
                new Arg("name_object", "String", "")
            }));
            ListSysCall.Add(new SysCall(1, "copy", new List<Arg>
            {
                new Arg("start_point", "String", ""),
                new Arg("end_point", "String", "")
            }));
            ListSysCall.Add(new SysCall(2, "sum2", new List<Arg>
            {
                new Arg("first_value", "int", ""),
                new Arg("second_value", "int", "")
            }));
            ListSysCall.Add(new SysCall(3, "sum3", new List<Arg>
            {
                new Arg("first_value", "int", ""),
                new Arg("second_value", "int", ""),
                new Arg("third_value", "int", "")
            }));
            ListSysCall.Add(new SysCall(4, "sum_all", new List<Arg>
            {
                new Arg("values", "List<int>", "")
            }));
        }

        public void ShowAll()
        {
            foreach (var item in ListSysCall)
            {
                item.PrintInfo();
            }
        }

        public void Call(int id, MyStack stack)
        {
            foreach (var call in ListSysCall)
            {
                if (call.get_id() == id)
                {
                    if (stack.Len() != call.Len())
                    {
                        Console.WriteLine("Error: Count of values");
                        stack.Clear();
                        return;
                    }

                    foreach (var arg in call.get_args())
                    {
                        if (!arg.Check(stack.Pop()))
                        {
                            Console.WriteLine("Error: Wrong Values");
                            stack.Clear();

                            return;
                        }
                    }

                    Console.WriteLine($"Commamd {call.get_name()} is completed");
                    stack.Clear();
                    return;
                }
            }
            stack.Clear();
            Console.WriteLine("Command not found");
        }
    }
}