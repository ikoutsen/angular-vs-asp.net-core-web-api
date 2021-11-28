using CalculatorWebAPI.Models;
using System;

namespace CalculatorWebAPI.Analizers
{
    public class DistanceCalculator : IDistaceAnalizer
    {
        public double GetDistace(Point point1, Point point2)
        {
            try
            {
                return Math.Sqrt((point1.X - point2.X) * (point1.X - point2.X)
                         + (point1.Y - point2.Y) * (point1.Y - point2.Y));
            }
            catch
            {
                return 0;
            }
        }
    }
}
