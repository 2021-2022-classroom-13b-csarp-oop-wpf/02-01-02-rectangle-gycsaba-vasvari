using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


using CircleProject;
using CircleProject.Models;

namespace CircleProject.Tests
{
    [TestClass()]
    public class Tests2
    {
        [TestMethod()]
        public void TestCircle()
        {
            Circle c1 = new Circle(2);
            Assert.ThrowsException<ExceptionCircleRadiusNegativOrZero>(() => c1.Radius=-2 );

            try
            {
                Circle c2 = new Circle(-2);
            }
            catch (ExceptionCircleRadiusNegativOrZero)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Circle konstruktora nem a megfelelő kivételt dobja!\n"+e.Message);
            }
            Assert.Fail("A Circle konstruktora negatív sugár esetén nem dob kivételt!");


            try
            {
                Circle c2 = new Circle(0);
            }
            catch (ExceptionCircleRadiusNegativOrZero)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("Circle konstruktora nem a megfelelő kivételt dobja!\n" + e.Message);
            }
            Assert.Fail("A Circle konstruktora nulla sugarú kör esetén nem dob kivételt!");
        }
    }
}