using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
       
        /// <summary>
        /// /*Draw(p1.x, p1.y, p1.sym);*/
        /*int x1 = 1;
        int y1 = 3;
        char sym1 = '*';
        Draw(x1, y1, sym1);*/
        /*int x2 = 4;
        int y2 = 5;
        char sym2 = '#';
        Draw(x2, y2, sym2);*/
        /*p2.x = 4;
           p2.y = 5;
           p2.sym = '#';*/
            /*Draw(p2.x, p2.y, p2.sym);*/
            
            /*List<int> numlist = new List<int>();
            numlist.Add(0);
            numlist.Add(1);
            numlist.Add(2);

            int x = numlist[0];
            int y = numlist[1];
            int z = numlist[2];

            foreach(int i in numlist)
            {
                Console.WriteLine(i);
            }
            numlist.RemoveAt(0);
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);*/
               /*static void Draw(int x, int y, char sym)
        {
             Console.SetCursorPosition(x, y);
                Console.Write(sym);
        }*/
        /// </summary>
        /// <param name="args"></param>
        /// 

        static void Main(string[] args)
            
        {
            Console.SetBufferSize(200, 225);
            Point p1 = new Point(1,3,'*');          
            p1.Draw();     
            Point p2 = new Point(4,5,'#');           
            p2.Draw();

            HorisontLine upline = new HorisontLine(0, 78, 0, '+');
            upline.Drow();
            HorisontLine downline = new HorisontLine(0, 78, 24, '+');
            downline.Drow();
            VertLine leftline = new VertLine(0, 24, 0, '+');
             leftline.Drow();
            VertLine rightline = new VertLine(0, 24, 78, '+');
            rightline.Drow();           


            Console.ReadLine();
        }
         
    }
}
      
        




