using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss
{
    public class ArrayProcessor
    {

        public double[] SortAndFilter(double[] a)
        {
            double[] withoutSameElements = a.Distinct().ToArray();

            for (var i = 0; i < withoutSameElements.Length; i++)
                if (withoutSameElements[i] < 0)
                    withoutSameElements[i] = Math.Abs(withoutSameElements[i]);

            Array.Sort(withoutSameElements);
            return withoutSameElements;
        }
    }
}
