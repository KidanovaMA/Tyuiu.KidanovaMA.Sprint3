using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KidanovaMA.Sprint3.Task7.V10.Lib
{
    public class DataService : ISprint3Task7V10
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len]; 
            int count = 0;
            for (double x = startValue; x <= stopValue; x += 1)
            {
                double denominator = Math.Sin(x) + 3;
                double y;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (5 * x + 2.5) / denominator + 2 * x + Math.Cos(x);
                }
                res[count] = Math.Round(y, 2);
                count++;
            }
            return res;
        }
    }
}
