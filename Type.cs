using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class Type
    {
        public void CalculateInterest(IInterest interest)
        {
            interest.CalculateInterest();
        }
    }
}
