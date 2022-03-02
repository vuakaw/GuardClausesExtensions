using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ardalis.GuardClauses
{
    public static class NotNumericalGuard
    {
        public static void NotNumerical (this IGuardClause guardClause,
            string input, string parameterName)
        {
            try
            {
                long temporal = Convert.ToInt64(input);
            }
            catch
            {
                throw new ArgumentException("El valor debería ser convertible a número", parameterName);
            }
        }
    }
}
