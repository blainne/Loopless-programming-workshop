using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests
{
    [TestClass]
    public class Ex1_Tests
    {
        private readonly Ex1_LoopFiltering Ex1 = new Ex1_LoopFiltering();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void AllCaptainsWithExperienceNoGreaterThan25()
        {
            var result = Ex1.GetShipsWithYoungCaptains(data);

            result
                .Should().OnlyContain(ship => ship.Captain.YearsOfService <= 25);
        }

        [TestMethod]
        public void NoDuplicateShips()
        {
            var result = Ex1.GetShipsWithYoungCaptains(data);

            result
                .Should().OnlyHaveUniqueItems();
        }
    }
}
