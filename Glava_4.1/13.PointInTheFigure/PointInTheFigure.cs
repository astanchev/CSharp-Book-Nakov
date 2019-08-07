using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            int sideH = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool bottomBorder = y == 0 && x >= 0 && x <= (3 * sideH);
            bool leftFirstBorder = x == 0 && y >= 0 && y <= sideH;
            bool leftSecondBorder = x == sideH && y >= sideH && y <= (4*sideH);
            bool rightFirstBorder = x == (3*sideH) && y >= 0 && y <= sideH;
            bool rightSecondBorder = x == (2*sideH) && y >= sideH && y <= (4 * sideH);
            bool firstTopBorder = y == sideH && x >= 0 && x <= sideH;
            bool secondTopBorder = y == (4*sideH) && x >= sideH && x <= (2*sideH);
            bool thirdTopBorder = y == sideH && x >= (2*sideH) && x <= (3*sideH);
            bool inFirstColumn = x > 0 && x < sideH && y > 0 && y < sideH;
            bool inSecondColumn = x > sideH && x < (2*sideH) && y > 0 && y < (4*sideH);
            bool inSecondColumnBorders = x >= sideH && x <= (2 * sideH) && y > 0 && y <= sideH;
            bool inThirdColumn = x > (2*sideH) && x < (3*sideH) && y > 0 && y < sideH;

            if (bottomBorder||leftFirstBorder||leftSecondBorder||rightFirstBorder||rightSecondBorder||firstTopBorder||secondTopBorder||thirdTopBorder)
            {
                Console.WriteLine("border");
            }
            else if (inFirstColumn||inSecondColumn||inThirdColumn||inSecondColumnBorders)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
