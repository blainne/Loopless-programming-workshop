using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LooplessProgramming.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests
{
    [TestClass]
    public class Ex2_Tests
    {
        Ex2_ExtractedLoop  Ex2 = new Ex2_ExtractedLoop();
        SampleData data = new SampleData();

        [TestMethod]
        public void GetBigCruisersReturnsCruisersOnly()
        {
            var result = Ex2.GetBigCruisers();

            result
                .Should().OnlyContain(ship => ship.ShipClass == WarshipClass.Cruiser);
        }

        [TestMethod]
        public void GetBigCruisersReturnsShipsWithAtLeast2000CrewMembers()
        {
            var result = Ex2.GetBigCruisers();

            result
                .Should().OnlyContain(ship => ship.Crew >= 2000);
        }

        [TestMethod]
        public void GetBigCruisersReturnsNoDuplicateShips()
        {
            var result = Ex2.GetBigCruisers();

            result
                .Should().OnlyHaveUniqueItems();
        }
    }
}
