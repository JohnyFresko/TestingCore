using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class figure
    {
        protected List<Point> pList;
      
            public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }

        }

        
    }
}
