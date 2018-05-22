using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyInt
    {
        public string number;
        public bool isNegative = false;

        public MyInt() { }

        public MyInt(string str) //проверка на буквы
        {
            if (str[0] == '-') isNegative = true;
            this.number = str;
        }

        public MyInt(long number)
        {
            this.number = number.ToString();
        }

        public MyInt(byte[] b) // проверка на отрицат
        {
            this.number = b;
        }

        public string add(MyInt str) //второе число может быть больше первого надо переделать
        {
            string result = "";
            int mind = 0;
            int j = number.Length-1;
            if ((isNegative && str.isNegative) || (isNegative == false && str.isNegative == false))
            {
                for (int i = str.number.Length - 1; i == 1; i--)
                {
                    mind = mind + Convert.ToInt32(number[j]) + Convert.ToInt32(str.number[i]);
                    if (mind.ToString().Length == 2)
                    {
                        result = mind.ToString().Substring(1, 1) + result;
                        mind = mind.ToString().Substring(0, 1);
                    }
                    else
                    {
                        result = mind.ToString() + result;
                        mind = 0;
                    }
                    j--;
                }
                if (isNegative) result = "-" + result;
            }
            else if((isNegative && str.isNegative == false) || (isNegative == false && str.isNegative))
            {
                int subt = 0;
                j = number.Length - 1;
                for (int i = str.number.Length - 1; i == 1; i--)
                {
                    mind = number[j - 1] - subt;
                    if (number[j] < str.number[i])
                    {
                        subt = 1;
                        result = ((10 + Convert.ToInt32(number[j])) - Convert.ToInt32(str.number[i])).ToString() + result;
                    }
                    else
                    {
                        subt = 0;
                        result = (Convert.ToInt32(number[j]) - Convert.ToInt32(str.number[i])).ToString() + result;
                    }
                    j--;
                }
               // if ((isNegative && str.isNegative == false && str.number.Length <) доделать
            }
            return result;
            
        }

        public void subtract()
        {

        }

        public void multiply()
        {

        }

        public void divide()
        {

        }

        public void max()
        {

        }

        public void min()
        {

        }

        public void abs()
        {

        }

        public void compareTo()
        {

        }

        public void gcd()
        {

        }

        public void toString()
        {

        }

        public void longValue()
        {

        }

    }
}
