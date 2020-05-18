using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss.Test
{
    [TestFixture]
    public class ArrayProcessorTests
    {
        [Test]
        public void ThrowsWIthNull()
        {
            ArrayProcessor processor = new ArrayProcessor();
            Assert.Throws<ArgumentNullException>(() => processor.SortAndFilter(null));
        }
        [Test]
        public void THeOriginalOneShouldRemainTheSame()
        {
            ArrayProcessor processor = new ArrayProcessor();

            double[] array = new double[] { 7, 5, 123, -50 };
            double[] copy = new double[] { 7, 5, 123, -50 };

            double[] newArray = processor.SortAndFilter(array);

            CollectionAssert.AreEqual(array, copy);
        }

        [Test]
        public void NoNegatives()
        {
            ArrayProcessor processor = new ArrayProcessor();

            double[] array = new double[] { 7, 5, 123, -50 };
            double[] newArray = processor.SortAndFilter(array);

            Assert.Throws<InvalidOperationException>(() => newArray.First(item => item < 0));
        }
        [Test]
        public void NoDuplicates()
        {
            ArrayProcessor processor = new ArrayProcessor();


            double[] array = new double[] { 7, 5, 123, -50 };
            double[] newArray = processor.SortAndFilter(array);

            CollectionAssert.AllItemsAreUnique(newArray);
        }

        [Test]
        public void IsOrdered()
        {
            ArrayProcessor processor = new ArrayProcessor();

            double[] array = new double[] { 7, 5, 123, -50 };
            double[] newArray = processor.SortAndFilter(array);

            CollectionAssert.IsOrdered(newArray);
        }
    }
}
