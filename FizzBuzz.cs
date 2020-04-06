using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzCmdLine
{
    public class FizzBuzz
    {
        static IDictionary<string, int> counter = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            CounterSetup();
            BuildString();
        }

        public static void CounterSetup()
        {
            counter.Add(new KeyValuePair<string, int>("fizz", 0));
            counter.Add(new KeyValuePair<string, int>("buzz", 0));
            counter.Add(new KeyValuePair<string, int>("fizzbuzz", 0));
            counter.Add(new KeyValuePair<string, int>("lucky", 0));
            counter.Add(new KeyValuePair<string, int>("integer", 0));
        }

        public static void BuildString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            string trimmedString;

            //iterate through tand pass the current int to the evaluate method building the string
            for (int i = 1; i < 21; i++)
            {
                stringBuilder.Append(Evaluate(i) + " ");
            }
            //trim the white space
            trimmedString = stringBuilder.ToString().TrimEnd() + ": ";

            //append the counter values to the string
            foreach (KeyValuePair<string, int> keyValuePair in counter)
            {
                trimmedString = trimmedString + (keyValuePair.Key + ":" + keyValuePair.Value.ToString() + " ");
            }
            Console.WriteLine(trimmedString);
        }

        public static string Evaluate(int i)
        {
            if (i.ToString().Contains("3"))
            {
                counter["lucky"]++;
                return ("lucky");
            }
            else if ((i % 3 == 0) && (i % 5 == 0))
            {
                counter["fizzbuzz"]++;
                return ("fizzbuzz");
            }
            else if (i % 3 == 0)
            {
                counter["fizz"]++;
                return ("fizz");
            }
            else if (i % 5 == 0)
            {
                counter["buzz"]++;
                return ("buzz");
            }
            else
                counter["integer"]++;
                return (i.ToString());
        }
    }
}

