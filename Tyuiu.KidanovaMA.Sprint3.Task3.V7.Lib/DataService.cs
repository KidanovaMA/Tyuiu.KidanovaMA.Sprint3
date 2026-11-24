using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KidanovaMA.Sprint3.Task3.V7.Lib
{
    public class DataService : ISprint3Task3V7
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string res = "";
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    res += replacement;
                }
                else
                {
                    res += c;
                }
            }
            return res;
        }
    }
}
