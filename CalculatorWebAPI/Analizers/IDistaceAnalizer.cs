using CalculatorWebAPI.Models;

namespace CalculatorWebAPI.Analizers{
    public interface IDistaceAnalizer
    {
        public double GetDistace(Point point1, Point point2);
    }
}
