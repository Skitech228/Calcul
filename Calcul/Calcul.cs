using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    class Calcul
    {
        int str;
        public string Name
        {
            get { return str.ToString(); }
            set
            {
                while (true)
                {
                    if (!int.TryParse(value, out str))
                        value = Console.ReadLine();
                    else
                        break;
                }

            }
        }
        public Calcul() { }
        public Calcul(string n)
        {
            this.Name = n;
        }
        public string GetIntBinaryString(string name)
        {
            this.Name = name;
            int n = str;
            int znach = 0;
            for (int j = 0; j < 1000; j++)
            {
                if (Math.Pow(2, j) >= n)
                {
                    znach = j;
                    break;
                }
            }
            char[] b = new char[znach];
            int pos = znach - 1;
            int i = 0;

            if (Math.Pow(2, znach) > n)
            {
                while (i < znach)
                {
                    if ((n & (1 << i)) != 0)
                    {
                        b[pos] = '1';
                    }
                    else
                    {
                        b[pos] = '0';
                    }
                    pos--;
                    i++;
                }
                //Exeptionn ex = new Exeptionn();
                //try
                //{
                //    Console.WriteLine(new string(b));
                //    ex.Age = new string(b);
                //}
                //catch (PersonException exep)
                //{
                //    Console.WriteLine(exep.Message);
                //}
                if (new string(b).Length > 8)
                    Console.WriteLine("dsgfdsgds 8");
                return new string(b);
            }
            else
            {
                b = new char[znach+1];
                pos = znach;
                while (i < znach+1)
                {                   
                    if ((n & (1 << i)) != 0)
                    {
                        b[pos] = '1';
                    }
                    else
                    {
                        b[pos] = '0';
                    }
                    pos--;
                    i++;
                }
                //Exeptionn ex = new Exeptionn();
                //try
                //{
                //    ex.Age = new string(b);
                //}
                //catch(PersonException exep)
                //{
                //    Console.WriteLine(exep.Message);
                //}
                if (new string(b).Length > 8)
                    Console.WriteLine("dfdsfdfs 8");
                return new string(b);
            }
        }
        public string GetIntBinaryString()
        {
            int n = str;
            int znach = 0;
            for (int j = 0; j < 1000; j++)
            {
                if (Math.Pow(2, j) >= n)
                {
                    znach = j;
                    if (znach > 8)
                        Console.WriteLine("Разряд больше 8");
                    break;
                }
            }
            char[] b = new char[znach];
            int pos = znach - 1;
            int i = 0;

            if (Math.Pow(2, znach) > n)
            {
                while (i < znach)
                {
                    if ((n & (1 << i)) != 0)
                    {
                        b[pos] = '1';
                    }
                    else
                    {
                        b[pos] = '0';
                    }
                    pos--;
                    i++;
                }
                return new string(b);
            }
            else
            {
                b = new char[znach + 1];
                pos = znach;
                while (i < znach + 1)
                {
                    if ((n & (1 << i)) != 0)
                    {
                        b[pos] = '1';
                    }
                    else
                    {
                        b[pos] = '0';
                    }
                    pos--;
                    i++;
                }
                return new string(b);
            }
        }
        public string mul(string str1, string str2)
        {
            Name = Convert.ToString(Convert.ToInt32(str1, 2) * Convert.ToInt32(str2, 2));
            return GetIntBinaryString();
        }
        public string sub(string str1, string str2)
        {
            Name = Convert.ToString(Convert.ToInt32(str1, 2) - Convert.ToInt32(str2, 2));
            return GetIntBinaryString();
        }
        public string add(string str1, string str2)
        {
            Name = Convert.ToString(Convert.ToInt32(str1, 2) + Convert.ToInt32(str2, 2));
            return GetIntBinaryString();
        }
        public string div(string str1, string str2)
        {
            Name = Convert.ToString(Convert.ToInt32(str1, 2) / Convert.ToInt32(str2, 2));
            return GetIntBinaryString();
        }
    }
}
