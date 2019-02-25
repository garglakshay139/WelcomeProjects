using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApplication20;

namespace UnitTests2
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestPositive()
        {
            DummyCode dummyCode = new DummyCode();
            dummyCode.CheckPalindrome(5);

          //  DummyCode dummyCode = new DummyCode();
            dummyCode.CheckPalindrome(9);
        }


    }
}
