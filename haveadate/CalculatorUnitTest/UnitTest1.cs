﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Diagnostics;//导入断言命名空间
using haveadate;//导入命名空间

namespace CalculatorUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Compute compute = new Compute("3+5-2*3");
            string res = compute.run().ToString();
            StringAssert.Contains("2", res);//StringAssert是个类
        }
    }
}
