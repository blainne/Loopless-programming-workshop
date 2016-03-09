using System;
using LooplessProgramming.Mapping;
using System.Linq;
using FluentAssertions;
using LooplessProgramming.Model;
using LooplessProgramming._4_Language_support;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Language_support
{
    [TestClass]
    public class Ex1_Tests
    {
        private readonly Ex1_ExtensionsAsStyle Ex1 = new Ex1_ExtensionsAsStyle();
        private readonly SampleData data = new SampleData();
        private int sumOfDestroyersCrews;

        [TestInitialize]
        public void Setup()
        {
            sumOfDestroyersCrews = 
                data.Ships
                .Where(s => s.ShipClass == WarshipClass.Destroyer)
                .Sum(s => s.Crew);
        }

        [TestMethod]
        public void TotalCrewOnDestroyers_1_ShouldGiveCorrectResult()
        {
            var result = Ex1.TotalCrewOnDestroyers_1(data);

            result.Should().Be(sumOfDestroyersCrews);
        }

        [TestMethod]
        public void TotalCrewOnDestroyers_2_ShouldGiveCorrectResult()
        {
            var result = Ex1.TotalCrewOnDestroyers_2(data);

            result.Should().Be(sumOfDestroyersCrews);
        }

        [TestMethod]
        public void TotalCrewOnDestroyers_3_ShouldGiveCorrectResult()
        {
            var result = Ex1.TotalCrewOnDestroyers_3(data);

            result.Should().Be(sumOfDestroyersCrews);
        }

        [TestMethod]
        public void TotalCrewOnDestroyers_4_ShouldGiveCorrectResult()
        {
            var result = Ex1.TotalCrewOnDestroyers_4(data);

            result.Should().Be(sumOfDestroyersCrews);
        }
    }
}
