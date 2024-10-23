using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstraxtBaseClass
{
    interface IHaveDiameter
    {
        double GetDiameter();
        void DrawDiameter(System.Windows.Forms.PaintEventArgs e);
    }
}
