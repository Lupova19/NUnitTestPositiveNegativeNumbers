using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveNegativeNumbers
{
    public class Numbers
    {
        public bool IsPositive(double number)
        {
            if (number < 0)
            {
                return false;
            }
            else if (number > 0)
            {
                return true;
            }
            else if (number == 0)
            {
                throw new ArgumentException("Не може да е 0!!!");
            }
            return false;
        }
    }
}
