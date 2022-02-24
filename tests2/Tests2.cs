using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using RectangleProject;
using RectangleProject.Models;

namespace RectangleProject.Tests
{
    [TestClass()]
    public class Tests2
    {
        [TestMethod()]
        public void TestRectangleException()
        {
            Rectangle r = new Rectangle(4.25, 7.34);
            Assert.ThrowsException<RectangleSideIsNullOrZero>(() => r.SideA=-2 );
            Assert.ThrowsException<RectangleSideIsNullOrZero>(() => r.SideB =-2);
            Assert.ThrowsException<RectangleSideIsNullOrZero>(() => r.SideA = 0);
            Assert.ThrowsException<RectangleSideIsNullOrZero>(() => r.SideB = 0);

            try
            {
                Rectangle r1 = new Rectangle(-4.25, 7.34);
            }
            catch (RectangleSideIsNullOrZero)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("A négyzet konstruktora nem a megfelelő kivételt dobja!\n"+e.Message);
            }
            Assert.Fail("A négyzet konstruktora negatív oldal esetén nem dob kivételt!");

            try
            {
                Rectangle r1 = new Rectangle(4.25, -7.34);
            }
            catch (RectangleSideIsNullOrZero)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("A négyzet konstruktora nem a megfelelő kivételt dobja!\n" + e.Message);
            }
            Assert.Fail("A négyzet konstruktora negatív oldal esetén nem dob kivételt!");


            try
            {
                Rectangle r1 = new Rectangle(0, 7.34);
            }
            catch (RectangleSideIsNullOrZero)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("A négyzet konstruktora nem a megfelelő kivételt dobja!\n" + e.Message);
            }
            Assert.Fail("A négyzet konstruktora nulla oldalhossz esetén nem dob kivételt!");

            try
            {
                Rectangle r1 = new Rectangle(1, 0);
            }
            catch (RectangleSideIsNullOrZero)
            {
                return;
            }
            catch (Exception e)
            {
                Assert.Fail("A négyzet konstruktora nem a megfelelő kivételt dobja!\n" + e.Message);
            }
            Assert.Fail("A négyzet konstruktora nulla oldalhossz esetén nem dob kivételt!");
        }
    }
}