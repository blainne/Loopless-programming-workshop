﻿using FluentAssertions;
using LooplessProgramming.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Filtering
{
    [TestClass]
    public class FilteringEx1_Tests
    {
        private readonly Ex1_LoopFiltering Ex1 = new Ex1_LoopFiltering();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetShipsWithYoungCaptainsReturnsCaptainsWithWorkYearsNoMoreThan25()
        {
            var result = Ex1.GetShipsWithYoungCaptains(data);

            result
                .Should()
                .OnlyContain(ship => 
                    ship.Captain.YearsOfService <= 25);
        }

        [TestMethod]
        public void GetShipsWithYoungCaptainsReturnsNoDuplicateShips()
        {
            var result = Ex1.GetShipsWithYoungCaptains(data);

            result
                .Should().OnlyHaveUniqueItems();
        }
    }
}
