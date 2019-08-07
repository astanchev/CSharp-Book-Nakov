using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stop
{
    class Stop
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n + 1;
            int underscopes = 2 * n + 1;
            Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('_', underscopes));
            underscopes -= 2;
            dots--;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', underscopes));
                underscopes += 2;
                dots--;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (underscopes - 5) / 2));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', i), new string('_', underscopes));
                underscopes -= 2;
            }
        }
    }
}
