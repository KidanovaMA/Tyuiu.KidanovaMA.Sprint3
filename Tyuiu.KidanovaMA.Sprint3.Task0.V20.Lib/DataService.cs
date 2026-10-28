using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KidanovaMA.Sprint3.Task0.V20.Lib
{
    public class DataService : ISprint3Task0V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double multSeries = 1;
            int i;
            for (i = startValue; i <= stopValue; i++)
            {
                multSeries *= (Math.Cos(value) + Math.Pow((double)i / 8.0, 3));
            }
            return Math.Round(multSeries, 3);
        }
    }
}
