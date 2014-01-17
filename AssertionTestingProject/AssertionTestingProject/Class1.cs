using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AssertionTestingProject
{
    public class AssertionTestClass
    {
        public int GoingToReturnOne()
        {
            return 1;
        }

        public string GoingToReturnEmptyString()
        {
            return String.Empty;
        }

        public int[] GetIntegerArray()
        {
            return new int[]{1,2,3,4,5};
        }

        public string GetSupermanBatman()
        {
            return "SupermanBatman";
        }
    }
}
