using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Valleys
{
    class Program
    {
        // Complete the countingValleys function below.
        static int countingValleys(int n, string s)
        {

            int level = 0;
            int valleyCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'U')
                {
                    level += 1;
                }
                else if (s[i] == 'D')
                {
                    level -= 1;
                }
                if (level == 0)
                {
                    valleyCount += 1;
                }
            }
            return valleyCount;
        }

        static void Main(string[] args)
        {
            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            string s = Console.ReadLine();

            int result = countingValleys(n, s);

            Console.WriteLine(result);

            //   textWriter.Flush();
            //textWriter.Close();
        }
    }
}
