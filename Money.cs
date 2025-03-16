using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClasses
{
    public class Money
    {
        public double Sum { get; set; }



        public static implicit operator Money(double sum)
        {
            return new Money(sum);
        }


        public static Money operator+ (Money num1, Money num2)
        {
            //Money res = num1 + num2;
            //return res;
            return new Money(num1.Sum + num2.Sum);
        }
        public static Money operator +(Money num1, double num2)
        {
            Money res = num1 + num2;
            return res;
        }

        public static Money operator- (Money num1, Money num2)
        {
            Money res = num1 - num2;
            return res;
        }

        public static Money operator- (Money num1, double num2)
        {
            Money res = num1 - num2;
            return res;
        }



        public static Money operator* (Money num1, int num2)
        {
            Money res = num1 * num2;
            return res;
        }

        public static Money operator/ (Money num1, int num2)
        {
            Money res = num1 / num2;
            return res;
        }



        public static Money operator++ (Money sum)
        {
            Money res = sum;
            res += 0.1;
            return res;
        }

        public static Money operator-- (Money sum)
        {
            Money res = sum;
            res -= 0.1;
            return res;
        }



        public static bool operator> (Money num1, Money num2)
        {
            return num1 > num2;
        }

        public static bool operator <(Money num1, Money num2)
        {
            return num1 < num2;
        }

        public static bool operator ==(Money num1, Money num2)
        {
            return num1 == num2;
        }

        public static bool operator !=(Money num1, Money num2)
        {
            return num1 != num2;
        }

        public Money(double sum)
        {
            Sum = sum;
        }



    }
}
