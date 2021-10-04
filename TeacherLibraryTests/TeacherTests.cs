using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeacherLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherLibrary.Tests
{
    [TestClass()]
    public class TeacherTests
    {
        [TestMethod]
        public void ConstructorTest()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Teacher(null));
            Assert.ThrowsException<ArgumentException>(() => new Teacher(""));
        }

        [TestMethod]
        public void SalaryTest()
        {
            Teacher teacher = new Teacher("Anders");
            teacher.Salary = 100;
            Assert.AreEqual(100, teacher.Salary);

            teacher.Salary = 0;
            Assert.AreEqual(0, teacher.Salary);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => teacher.Salary = -1);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(100)]
        public void SalaryTest2(int sal)
        {
            Teacher teacher = new Teacher("Anders");
            teacher.Salary = sal;
            Assert.AreEqual(sal, teacher.Salary);
        }

        [TestMethod]
        public void NameTest()
        {
            Teacher teacher = new Teacher("Anders");
            //teacher.Name = "Anders";
            Assert.AreEqual("Anders", teacher.Name);

            teacher.Name = "Y";
            Assert.AreEqual("Y", teacher.Name);

            Assert.ThrowsException<ArgumentException>(() => teacher.Name = "");
            Assert.ThrowsException<ArgumentNullException>(() => teacher.Name = null);
        }

        [TestMethod]
        public void TestPi()
        {
            Assert.AreEqual(3.14159265, Teacher.Pi, 0.001);
        }

        [TestMethod()]
        public void ToStringTest()
        {

        }
    }
}