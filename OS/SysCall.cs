using System;
using System.Collections.Generic;

namespace OS_Lab1
{
    public class SysCall
    {
        private int _id { get; }
        private String _name { get; }
        private List<Arg> _args { get; }

        public SysCall(int id, String name, List<Arg> args) {
            _id = id;
            _name = name;
            _args = args;
        }

        public int get_id()
        {
            return _id;
        }
        
        public String get_name()
        {
            return _name;
        }
        
        public List<Arg> get_args()
        {
            return _args;
        }
        public void PrintInfo()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"ID: {_id}  Name: {_name}");
            PrintInfoElem();
            Console.WriteLine("--------------------------------");
        }

        private void PrintInfoElem()
        {
            Console.WriteLine($"Count of values: {_args.Count}");
            foreach (var item in _args)
            {
                item.PrintInfo();
            }
        }

        public int Len()
        {
            return _args.Count;
        }
    }
}