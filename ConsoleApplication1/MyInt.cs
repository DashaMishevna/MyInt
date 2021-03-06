﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class MyInt
    {
        public string number {get;set;}
        public bool isNegative = false;

        public MyInt() { }

        public MyInt(string str) 
        {
            try
            {
                int value;
                if (str[0].ToString() == "-") isNegative = true;
                for (int i = 1; i < str.Length; i++)
                    value = Convert.ToInt32(str[i].ToString());
                this.number = str; 
            }
            catch 
            {
                Console.WriteLine("Ошибка ввода цифры");  
            }
        }

        public MyInt(long number)
        {
            
            if (number < 0)isNegative = true;
            this.number = number.ToString();
        }

        public MyInt(byte[] b)
        {
            number = "";
            if (b[0] == 1)
            {
                isNegative = true;
                number = "-";
            }
            for (int i = 1; i < b.Length; i++)
            {
                number = number + b[i];
            }
        }

        public MyInt add(MyInt str) 
        {
            if (number.First().ToString() == "-") number = number.Substring(1, number.Length - 1);
            if (str.number.First().ToString() == "-") str.number = str.number.Substring(1, str.number.Length - 1);
            string result = "";
            int mind = 0;
            if (number.Length > str.number.Length) str.number = new String('0', (number.Length - str.number.Length)) + str.number;
            else number = new String('0', (str.number.Length - number.Length)) + number;

            if ((isNegative && str.isNegative) || (isNegative == false && str.isNegative == false))
            {
                result = sum(str, result, mind);
            }
            else if((isNegative && str.isNegative == false) || (isNegative == false && str.isNegative))
            {
                result = sub(str, result, mind);
            }
            str.number = result;
            return str;
        }

        private string sum (MyInt str, string result, int mind)
        {
            
            for (int i = number.Length - 1; i >= 0; i--)
            {
                mind = mind + Convert.ToInt32(number[i].ToString()) + Convert.ToInt32(str.number[i].ToString());
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
            }
            if (mind != 0) result = mind + result;
            if (isNegative) result = "-" + result;
            return result;
        }

        private string sub(MyInt str, string result, int mind)     
        {
            int subt = 0;
            string min = str.number;
            string max = number;
            string negativ = "";
            if (isNegative) negativ = "-";

            if (compare(str) == -1)  
            {
                min = number;
                max = str.number;
                if (str.isNegative) negativ = "-";
                else negativ = "";
            }
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (min[i] > max[i] - subt)
                {
                    result = ((10 + Convert.ToInt32(max[i])-subt) - Convert.ToInt32(min[i])).ToString() + result;
                    subt = 1;
                }
                else
                {
                    result = (Convert.ToInt32(max[i]-subt) - Convert.ToInt32(min[i])).ToString() + result;
                    subt = 0;
                }
            }
            if (result[0].ToString() == "0") result = result.Substring(1,result.Length-1);
            if (compare(str) == -1 && isNegative == false && str.isNegative == false) negativ = "-";
            result = negativ + result;
            return result;
        }

        public MyInt subtract(MyInt str) //Вычитание
        {
            if (number.First().ToString() == "-") number = number.Substring(1, number.Length - 1);
            if (str.number.First().ToString() == "-") str.number = str.number.Substring(1, str.number.Length - 1);
            string result = "";
            int mind = 0;
            MyInt end_result = new MyInt();
            if (number.Length > str.number.Length) str.number = new String('0', (number.Length - str.number.Length)) + str.number;
            else number = new String('0', (str.number.Length - number.Length)) + number;

            if ((isNegative && str.isNegative) || (isNegative == false && str.isNegative == false))
            {
                result = sub(str, result, mind);
            }
            else if ((isNegative && str.isNegative == false) || (isNegative == false && str.isNegative))
            {
                result = sum(str, result, mind);
            }

            while (number[0].ToString() == "0" && number.Length!=1)
            {
                number = number.Substring(1, number.Length-1);
            }

            while (str.number[0].ToString() == "0" && str.number.Length != 1)
            {
                str.number = str.number.Substring(1, str.number.Length - 1);
            }
            end_result.number = result;
            return end_result;
        }

        public MyInt multiply(MyInt str) //Умножение
        {
            if (number.First().ToString() == "-") number = number.Substring(1, number.Length - 1);
            if (str.number.First().ToString() == "-") str.number = str.number.Substring(1, str.number.Length - 1);
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
                try { mind = result.Substring(result.Length - check, check); }
                catch (Exception)
                {
                    result = shift;
                    check--;
                    continue;
                }
                result = result.Substring(0, result.Length - check);
                result = new String('0', (shift.Length - result.Length)) + result;
                sum_shift = "";
                mind_shift = 0;
                for (int i = shift.Length - 1; i >= 0; i--)
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
            if (str.isNegative && isNegative == false || str.isNegative == false && isNegative)
            {
                str.number ="-" + result;
            }
            
            return str;
        }

        public void divide() //Деление
        {

        }

        public MyInt max(MyInt str) 
        {
            if (compareTo(str) == -1)
            {
                if (str.isNegative) str.number = "-" + str.number;
                return str;
            }

            else
            {
                if (isNegative) number = "-" + number;
                str.number = number;
                return str;
            };
        }

        public MyInt min(MyInt str) 
        {
            if (compareTo(str) == -1)
            {
                if (isNegative) number = "-" + number;
                str.number = number;
                return str;
            }

            else
            {
                if (str.isNegative) str.number = "-" + str.number;
                return str;
            }
        }

        private int compare(MyInt str) //Чисто длина
        {

            if (number.Length > str.number.Length) return 1;
       
            else if (number.Length < str.number.Length) return -1;
           
            else
            {
                for (int i= 0; i < number.Length ; i++)
                {
                    if (number[i] > str.number[i])
                    {
                        return 1;
                    }

                    else if (number[i] < str.number[i]) return -1;
                }
                return 0;
            }
        }
  
        public MyInt abs()
        {
            MyInt str = new MyInt(number);
            if (str.number.First().ToString() == "-") str.number = str.number.Substring(1, str.number.Length - 1);
           
            return str;   
        }

        public int compareTo(MyInt str)
        {
            if (number.First().ToString() == "-") number = number.Substring(1, number.Length - 1);
            if (str.number.First().ToString() == "-") str.number = str.number.Substring(1, str.number.Length - 1);
            if (isNegative && str.isNegative == false) return -1;
            if (isNegative==false && str.isNegative) return 1;
            if (isNegative == false && str.isNegative == false) return compare(str);
            else return (compare(str) * (-1));
        }

        public MyInt gcd(MyInt str) // Наибольший общий делитель
        {
            if (number.First().ToString() == "-") number = number.Substring(1, number.Length - 1);
            if (str.number.First().ToString() == "-") str.number = str.number.Substring(1, str.number.Length - 1);
            bool s = str.isNegative;
            MyInt num = new MyInt(number);
            num.isNegative = false;
            str.isNegative = false;

            while (num.compareTo(str) !=0)
            {
                if (num.compareTo(str) == -1)
                {
                    str = str.subtract(num);
                }
                else num = num.subtract(str);
            }
            if (s) str.isNegative = true;
            return str;
           
        }

        public string toString()
        {

            if (number.First().ToString() != "-" && isNegative == true) number = "-" + number;
            return number;
        }

        public long longValue()
        {
            if (number.First().ToString() == "-") number = number.Substring(1, number.Length - 1);
            if (number.Length >= 19)
            {
                string long_num = "9223372036854775807"; 
                string result = "";
                number = number.Substring(0, 19);
                for (int i = 0; i < number.Length; i++)
                {
                    if (isNegative && number[i].ToString() == "8" && i == 18)
                    {
                        result = result + number[i];
                        break;
                    } 
                    if (Convert.ToInt32(number[i]) <= Convert.ToInt32(long_num[i])) result = result + number[i];
                    
                }
                if (result.Length == 19)
                {
                    if (isNegative) result = "-" + result;
                    return Convert.ToInt64(result);
                }

                else
                {
                    if (isNegative)
                    {
                        number = "-" + number;
                        return Convert.ToInt64(number.Substring(0, 20));
                    }
                    return Convert.ToInt64(number.Substring(0, 19));
                }
            }
            if (isNegative) number = "-" + number;
            return Convert.ToInt64(number);
        }

    }
}
