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
        public void SalaryTest()
        {
            Teacher teacher = new Teacher();
            teacher.Salary = 100;
            Assert.AreEqual(100, teacher.Salary);

        }

        [TestMethod()]
        public void ToStringTest()
        {
                
        } 
    }
}