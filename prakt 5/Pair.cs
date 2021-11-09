using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt_5
{
    class Pair
    {
        public Pair(int initFirst, int initSecond)
        {
            First = initFirst;
            Second = initSecond;
        }
        public int First { get; set; }
        public int Second { get; set; }
        public bool Compare()
        {
            if (First == Second) return true;
            else return false;
        }
        public bool Compare(Pair value)
        {
            if (First == value.First && Second == value.Second) return true;
            else return false;
        }
        public bool Compare(Pair second, Pair third)
        {
            if (First == second.First && second.First == third.First && Second == second.Second && second.Second == third.Second) return true;
            else return false;
        }
        public int Multiply()
        {
            return First * Second;
        }
        public Pair Multiply(Pair value)
        {
            return new Pair(First * value.First, Second * value.Second);
        }
        public Pair Multiply(Pair second, Pair third)
        {
            return new Pair(First * second.First * third.First, Second * second.Second * third.Second);
        }
        public int Minus()
        {
            return First - Second;
        }
        public Pair Minus(Pair value)
        {
            return new Pair(First - value.First, Second - value.Second);
        }
        public Pair Minus(Pair second, Pair third)
        {
            return new Pair(First - second.First - third.First, Second - second.Second - third.Second);
        }
    }
}
