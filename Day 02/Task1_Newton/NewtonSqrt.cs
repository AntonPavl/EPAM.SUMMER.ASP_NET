using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Newton
{
    /// <summary>
    /// Evaluate square root by Newton's method
    /// </summary>
    public class NewtonSqrt
    {
        /// <summary>
        /// Get num^(1/n)
        /// </summary>
        /// <param name="num">Number under the root</param>
        /// <param name="n">Root level</param>
        /// <param name="eps">Epsilon of result</param>
        /// <returns>Returns num^(1/n)</returns>
        public static double Sqrt(double num, int n, double eps)
        {
            double res = num;
            double prev = 0;
            if (n < 2) return Double.NaN;
            if (n % 2 == 0 && num < 0) return Double.NaN;
            while (Math.Abs(prev-res)>=eps)
            {
                prev = res;
                res = (1.0 / n) * ((n - 1) * res + num / (Math.Pow(res, n - 1)));
            }           
            return res;
        }
    }
}
