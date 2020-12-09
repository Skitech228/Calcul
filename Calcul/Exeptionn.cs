using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcul
{
    class Exeptionn
    {
        public string Age
        {
            get { return Age; }
            set
            {
       
                if (value.Length > 8)
                {
                    throw new Exception("Колличество байт больше 8");
                }
                else
                {
                    Age = value;
                }
            }
        }
    }
}
