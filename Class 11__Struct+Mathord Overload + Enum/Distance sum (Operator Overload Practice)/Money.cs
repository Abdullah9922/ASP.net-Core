using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Distance_sum__Operator_Overload_Practice_
{
    public class Money<T> where T : INumber<T>
    {
        public T Amount { get; set; }

        public Money(T amount)
        {
            Amount = amount;
        }

        public static bool operator >(Money<T> a, Money<T> b)
        {
            return a.Amount > b.Amount;
        }
        public static bool operator <(Money<T> a, Money<T> b)
        {
            return a.Amount < b.Amount;
        }

        public static bool operator ==(Money<T> a, Money<T> b)
        {
            return a.Amount == b.Amount;
        }

        public static bool operator !=(Money<T> a, Money<T> b)
        {
            return a.Amount == b.Amount;
        }

        public static Money<T> operator +(Money<T> a, Money<T> b)
        {
            T c = a.Amount + b.Amount;
            return new Money<T>(c);
        }
    }
}
    
