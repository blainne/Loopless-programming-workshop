using System;
using System.Linq;
using FluentAssertions;
using LooplessProgramming.Reducing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Reducing
{
    [TestClass]
    public class ReducingEx1_Tests
    {
        private readonly Ex1_LoopReducing Ex1 = new Ex1_LoopReducing();

        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetTotalCrewCountsReturnsZeroWhenNoShips()
        {
            data.Ships.Clear();
            var result = Ex1.GetTotalCrew(data);

            result.Should().Be(0);
        }

        [TestMethod]
        public void GetTotalCrewCountsAllCrewmembersInAllShips()
        {
            var expected = data.Ships.Sum(s => s.Crew);
            var result = Ex1.GetTotalCrew(data);

            result.Should().Be(expected);
        }
    }
}
