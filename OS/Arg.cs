using System;
using System.Diagnostics.Contracts;

namespace OS_Lab1
{
    public class Arg
    {
        private String _name { get; }
        private String _type { get; }
        private String _value;
        
        public Arg (String name, String type, String value)
        {
            _name = name;
            _type = type;
            _value = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name of Value: {_name} Type: {_type} ");
        }

        public bool Check(Arg item)
        {
            return (_name == item._name && _type == item._type);
        }
    }
}