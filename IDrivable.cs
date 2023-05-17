using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple
{
    internal interface IDrivable
    {
        int speed { get; set; }
        int fuel { get; set; }

        void Horn();
        void Onward(int speed);
        void Brake();

    }
}
