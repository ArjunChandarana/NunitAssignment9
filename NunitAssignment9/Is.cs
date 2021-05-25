using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitAssignment9
{
    public class Is : NUnit.Framework.Is
    {
        public static IsCapitalizeConstraint IsCapitalize(string expected)
        {
            return new IsCapitalizeConstraint(expected);
        }

        public static AlmostEqualToConstraint IsAlmostEqualTo(int expected, int percentageTolerance = 5)
        {
            return new AlmostEqualToConstraint(expected, percentageTolerance);
        }

        public static IsPartOfConstraint IsPartOf(int[] expected)
        {
            return new IsPartOfConstraint(expected);
        }
    }
}
