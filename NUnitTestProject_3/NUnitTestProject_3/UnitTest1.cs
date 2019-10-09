using NUnit.Framework;
using System;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Comment1");
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Console.WriteLine("Comment1");
            Assert.Pass();
        }

        [Test]
        public void Test3()
        {
            Console.WriteLine("Comment1");
            Assert.Fail();
        }


    }
}