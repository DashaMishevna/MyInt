using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyInt
    {
        public string number {get;set;}
        public bool isNegative = false;

        public MyInt() { }

        public MyInt(string str) // отрезпать - и переделать
        {
            try
            {
                int value;
                for (int i = 1; i < str.Length; i++)
                    value = Convert.ToInt32(str[i]);
                if (str[0] == '-') isNegative = true;
                this.number = str;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка ввода цифры");
            }
        }

        public MyInt(long number)
        {
            if (number < 0) isNegative = true;
            this.number = number.ToString();
        }

        public MyInt(byte[] b) // проверка на отрицат такая?
        {
            number = "";
            if (b[0] == 0) isNegative = true;
            foreach (var x in b)
            {
                number = number + x;
            }
        }

        public MyInt add(MyInt str) //второе число может быть больше первого надо переделать 
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
                        mind = Convert.ToInt32(mind.ToString().Substring(0, 1));
                    }
                    else
                    {
                        result = mind.ToString() + result;
                        mind = 0;
                    }
                    j--;
                }
                if (isNegative) str.isNegative = true;
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
            str.number = result;
            return str;
        }

        public void subtract()
        {

        }

        public MyInt multiply(MyInt str)
        {
            string result = "";
            string sum_shift = "";
            string shift = "";
            int mind_shift = 0;
            string mind = "0";
            int check = 0;
            foreach (char x in str.number.Reverse())
            {
                check++;
                shift = "";
                mind = "0";
                foreach (char y in number.Reverse())
                {
                    mind = (Convert.ToInt32(mind) + Convert.ToInt32(x.ToString()) * Convert.ToInt32(y.ToString())).ToString();
                    if (mind.Length == 2)
                    {
                        shift = mind.Substring(1, 1) + shift;
                        mind = mind.Substring(0, 1);
                    }
                    else
                    {
                        shift = mind + shift;
                        mind = "0";
                    }
                }
                if (mind != "0") shift = mind + shift;
                try { mind = result.Substring(result.Length-check,check);  }
                catch (Exception)
                {
                    result = shift;
                    check--;
                    continue;
                }
                result = result.Substring(0,result.Length-check); // число без последней цифры
                result = new String('0', (shift.Length - result.Length)) + result;
                sum_shift = "";
                mind_shift = 0;
                for (int i = shift.Length-1; i >= 0; i--)
                {
                    mind_shift = mind_shift + (Convert.ToInt32(result[i].ToString()) + Convert.ToInt32(shift[i].ToString()));
                    if (mind_shift.ToString().Length == 2)
                    {
                        sum_shift = mind_shift.ToString().Substring(1, 1) + sum_shift;
                        mind_shift = Convert.ToInt32(mind_shift.ToString().Substring(0, 1));
                    }
                    else
                    {
                        sum_shift = mind_shift.ToString() + sum_shift;
                        mind_shift = 0;
                    }
                }
                if (mind_shift != 0) sum_shift = mind_shift + sum_shift;
                result = sum_shift + mind;
            }
            str.number = result;
            return str;
        }

        public void divide()
        {

        }

        public MyInt max(MyInt str)
        {
            if (number.Length > str.number.Length)
            {
                str.number = number;
                return str;
            }
            else if (number.Length < str.number.Length) return str;
            else
            {
                //for ()
                //{ }
                return str;
            }
        }

        public void min()
        {

        }

        public string abs()
        {
            if (isNegative) number.Substring(1, number.Length - 1);
            return number;
        }

        public void compareTo()
        {

        }

        public void gcd()
        {

        }

        public string toString()
        {
            return number;
        }

        public long longValue()
        {
            if (number.Length >= 19)
            {
                string long_num = "9223372036854775807"; 
                string result = "";
                number = number.Substring(0, 19);
                for (int i = 0; i < number.Length; i++)
                {
                    if (isNegative && number[i] <= 8 && i == 19)
                    {
                        result = result + number[i];
                        break;
                    } 
                    if (Convert.ToInt32(number[i]) <= Convert.ToInt32(long_num[i])) result = result + number[i];
                    
                }
                if (result.Length == 19) return Convert.ToInt64(result);
                else { return Convert.ToInt64(number.Substring(0,18)); }
            }
            return Convert.ToInt64(number);
        }

    }
}
