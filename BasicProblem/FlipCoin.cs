using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class FlipCoin
    {
        const double HEAD = 0.5;
        int HeadCount = 0, TailCount = 0;
        public void CoinFlip()
        {
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                double Num = random.NextDouble();
                if (Num < HEAD)
                {
                    TailCount++;
                }
                else
                {
                    HeadCount++;
                }
            }
            double HeadCountPersentage = HeadCount % 100;
            double TailCountPersentage = TailCount % 100;
            Console.WriteLine("Percenttage of The coin HEAD: " + HeadCountPersentage);
            Console.WriteLine("Percenttage of The coin TAIL: " + TailCountPersentage);

        }
    }
}
