using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Text.RegularExpressions;

namespace SubSonic.Tests.Unit.Extensions
{
    public static class AssertExtensions
    {
        public static void WhitespaceAgnosticEquals(string expected, string actual)
        {
            
            string strippedExpected = Regex.Replace(expected,"\\s+", " ");
            string strippedActual = Regex.Replace(actual, "\\s+", " ");
            if (!strippedExpected.Equals(strippedActual))
                throw new Xunit.Sdk.AssertException("Expected \n" + strippedExpected + "\n but got \n" + strippedActual);
        }
    }
}
