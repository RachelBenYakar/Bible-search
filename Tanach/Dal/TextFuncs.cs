using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal class TextFuncs
    {
        public static string[] readLines()
        {
            string path = "S:\\משותף כללי\\הנדסאים שנה ב\\תלמידות המדהימות\\רחלי בן יקר\\C#\\פרויקט תנך\\Tanach\\Dal\\tora.txt";
            return File.ReadAllLines(path);
        }
    }
}
