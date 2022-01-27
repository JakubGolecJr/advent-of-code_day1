using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_advent_day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART 1
            //converting .txt file into string array
            /*
            string[] depthValuesString = File.ReadAllLines(@"C:\Users\kubag\OneDrive\Pulpit\code advent\day 1\input.txt", Encoding.UTF8);

            int[] depthValues = new int[depthValuesString.Length];
            //depthValue[0] = N/A = first measurment

            //converting string tab into int tab
            for (int i = 1; i < depthValues.Length; i++)
            {
                depthValues[i] = int.Parse(depthValuesString[i]);
            }

            int sonarIncreases = 0;

            for (int i = 1; i < depthValues.Length; i++)
            {
                if (depthValues[i] > depthValues[i - 1])
                {
                    sonarIncreases += 1;    
                }

            }

            Console.WriteLine(sonarIncreases);
            */

            //PART 2

            string[] depthValuesString = File.ReadAllLines(@"C:\Users\kubag\OneDrive\Pulpit\code advent\day 1\input.txt", Encoding.UTF8);

            int[] depthValues = new int[depthValuesString.Length];
            //depthValue[0] = N/A = first measurment

            //converting string tab into int tab
            for (int i = 1; i < depthValues.Length; i++)
            {
                depthValues[i] = int.Parse(depthValuesString[i]);
            }

            int trpileIncreases = 0;

            for (int i = 3; i < depthValues.Length; i++)
            {
                if(depthValues[i] + depthValues[i -1] + depthValues[i -2] > depthValues[i -1] + depthValues[i -2] + depthValues[i-3])
                {
                    trpileIncreases++;
                }
            }
            Console.WriteLine(trpileIncreases);
        }
    }
}
