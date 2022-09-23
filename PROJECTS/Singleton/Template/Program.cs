using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ScoringAlgoritma algoritma;
            Console.WriteLine("Mans");
            algoritma = new MenScore();
            Console.WriteLine(algoritma.GenerateScore(8,new TimeSpan(0,2,34)));

            Console.WriteLine("Women");
            algoritma = new WomanScore();
            Console.WriteLine(algoritma.GenerateScore(8, new TimeSpan(0,2,34)));

            Console.WriteLine("Child");
            algoritma = new ChildScore();
            Console.WriteLine(algoritma.GenerateScore(8, new TimeSpan(0,2,34)));

            Console.ReadLine();
        }
    }
    abstract class ScoringAlgoritma
    {
        public int GenerateScore (int hits,TimeSpan time)
        {
            int score = CalculateBaseScore(hits);
            int reduction = CalculateReduction(time);
            return CAlculateOverallScore(score, reduction);
        }

        public abstract int CAlculateOverallScore(int score, int reduction); // değişkenlik göstericek bunlar
        public abstract int CalculateReduction(TimeSpan time);
        public abstract int CalculateBaseScore(int hits);
    }
    class MenScore : ScoringAlgoritma
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CAlculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 5;
        }
    }
    class WomanScore : ScoringAlgoritma
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CAlculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 3;
        }
    }
    class ChildScore : ScoringAlgoritma
    {
        public override int CalculateBaseScore(int hits)
        {
            return hits * 100;
        }

        public override int CAlculateOverallScore(int score, int reduction)
        {
            return score - reduction;
        }

        public override int CalculateReduction(TimeSpan time)
        {
            return (int)time.TotalSeconds / 2;
        }
    }
}
