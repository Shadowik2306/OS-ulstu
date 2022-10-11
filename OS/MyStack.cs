using System.Collections.Generic;

namespace OS_Lab1.Properties
{
    public class MyStack

    {
        private List<Arg> _list;

        public MyStack()
        {
            _list = new List<Arg>();
        }

        public void Push(Arg value)
        {
            _list.Add(value);
        }

        public Arg Pop()
        {
            Arg save = _list[0];
            _list.Remove(save);
            return save;
        }

        public void Clear()
        {
            _list = new List<Arg>();
        }

        public int Len()
        {
            return _list.Count;
        }
    }
}