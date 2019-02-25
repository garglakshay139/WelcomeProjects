using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        static void Main()
        {

            DummyCode dummyCode = new DummyCode();
            dummyCode.CheckPalindrome(5);
           
        }

    }

    public class DummyCode
    {
        public int Name { get; set; }

        public void CheckPalindrome(int i)
        {
            if (i > 7)
            {
                i = 9;
            }
            else
            {
                i = 0;
            }
        }
    }


}
