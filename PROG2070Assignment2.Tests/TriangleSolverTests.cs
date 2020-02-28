using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace PROG2070Assignment2.Tests
{
    [TestFixture]
    class TriangleSolverTests
    {
        [Test]
        //This will test the first condition in the first if statement
        public void Analyze_Given1and1and9_ResultIsInvalidTriangle()
        {
            Assert.AreEqual("Those Dimensions don't form a valid triangle", TriangleSolver.Analyze(1, 1, 9));
        }
        [Test]
        //This will test the second condition in the first if statement
        public void Analyze_Given9and1and1_ResultIsInvalidTriangle()
        {
            Assert.AreEqual("Those Dimensions don't form a valid triangle", TriangleSolver.Analyze(9, 1, 1));
        }
        [Test]
        //This will test the third condition in the first if statement
        public void Analyze_Given1and9and1_ResultIsInvalidTriangle()
        {
            Assert.AreEqual("Those Dimensions don't form a valid triangle", TriangleSolver.Analyze(1, 9, 1));
        }
        [Test]
        //This will test the first else if statement
        public void Analyze_Given1and1and1_ResultIsEquilateral()
        {
            Assert.AreEqual("Equilateral", TriangleSolver.Analyze(1, 1, 1));
        }
        [Test]
        //This will test the second else if statement
        public void Analyze_Given1and1and2_ResultIsIsosceles()
        {
            Assert.AreEqual("Isosceles", TriangleSolver.Analyze(1, 1, 2));
        }
        [Test]
        //This will test the else statment
        public void Analyze_Given1and2and3_ResultIsScalene()
        {
            Assert.AreEqual("Scalene", TriangleSolver.Analyze(1, 2, 3));
        }
    }
}
