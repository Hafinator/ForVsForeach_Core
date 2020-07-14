using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace ForVsForeach_Core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of program");
            Stopwatch s = new Stopwatch();
            Random r = new Random();
            decimal[] data = new decimal[100000000];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = r.Next();
            }

            Console.WriteLine("Data ready!");

            ForeachTest(s, data);
            ForArrayTest(s, data);

            ForeachTest(s, data);
            ForArrayTest(s, data);

            Console.WriteLine("Array test done!");
            Console.WriteLine();

            IEnumerable<decimal> enumrableData = data.AsEnumerable();

            ForeachTest(s, enumrableData);
            ForArrayTest(s, enumrableData);

            ForeachTest(s, enumrableData);
            ForArrayTest(s, enumrableData);
            Console.WriteLine("IEnumerable test done!");
            Console.WriteLine();
            enumrableData = null;


            List<decimal> listData = data.ToList();
            ForeachTest(s, listData);
            ForArrayTest(s, listData);
            ForeachTest(s, listData);
            ForArrayTest(s, listData);
            Console.WriteLine("List test done!");
            Console.WriteLine();
            listData.Clear();

            ICollection<decimal> collectionData = data;
            ForeachTest(s, collectionData);
            ForArrayTest(s, collectionData);
            ForeachTest(s, collectionData);
            ForArrayTest(s, collectionData);
            Console.WriteLine("ICollection test done!");
            Console.WriteLine();
            listData.Clear();

            Console.WriteLine("Program finished");
            Console.ReadLine();
        }

        #region Array
        private static void ForeachTest(Stopwatch s, decimal[] data)
        {
            decimal sum = 0;
            s.Start();
            foreach (int item in data)
            {
                if (item > 1000)
                {
                    sum += item;
                }
            }
            s.Stop();
            Console.WriteLine("The foreach operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }

        private static void ForArrayTest(Stopwatch s, decimal[] data)
        {
            decimal sum = 0;
            s.Start();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > 1000)
                {
                    sum += data[i];
                }
            }
            s.Stop();
            Console.WriteLine("The for operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }
        #endregion

        #region IEnumerable
        private static void ForeachTest(Stopwatch s, IEnumerable<decimal> data)
        {
            decimal sum = 0;
            s.Start();
            foreach (int item in data)
            {
                if (item > 1000)
                {
                    sum += item;
                }
            }
            s.Stop();
            Console.WriteLine("The foreach operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }

        private static void ForArrayTest(Stopwatch s, IEnumerable<decimal> data)
        {
            decimal sum = 0;
            s.Start();
            for (int i = 0; i < data.Count(); i++)
            {
                decimal val = data.ElementAt(i);
                if (val > 1000)
                {
                    sum += val;
                }
            }
            s.Stop();
            Console.WriteLine("The for operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }
        #endregion

        #region List
        private static void ForeachTest(Stopwatch s, List<decimal> data)
        {
            decimal sum = 0;
            s.Start();
            foreach (int item in data)
            {
                if (item > 1000)
                {
                    sum += item;
                }
            }
            s.Stop();
            Console.WriteLine("The foreach operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }

        private static void ForArrayTest(Stopwatch s, List<decimal> data)
        {
            decimal sum = 0;
            s.Start();
            for (int i = 0; i < data.Count(); i++)
            {
                decimal val = data.ElementAt(i);
                if (val > 1000)
                {
                    sum += val;
                }
            }
            s.Stop();
            Console.WriteLine("The for operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }
        #endregion

        #region ICollection
        private static void ForeachTest(Stopwatch s, ICollection<decimal> data)
        {
            decimal sum = 0;
            s.Start();
            foreach (int item in data)
            {
                if (item > 1000)
                {
                    sum += item;
                }
            }
            s.Stop();
            Console.WriteLine("The foreach operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }

        private static void ForArrayTest(Stopwatch s, ICollection<decimal> data)
        {
            decimal sum = 0;
            s.Start();
            for (int i = 0; i < data.Count(); i++)
            {
                decimal val = data.ElementAt(i);
                if (val > 1000)
                {
                    sum += val;
                }
            }
            s.Stop();
            Console.WriteLine("The for operation took: " + s.ElapsedMilliseconds + " milliseconds");
            s.Reset();
        }
        #endregion
    }
}
