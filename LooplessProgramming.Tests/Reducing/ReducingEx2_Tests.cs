using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LooplessProgramming.Reducing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace LooplessProgramming.Tests.Reducing
{
    [TestClass]
    public class ReducingEx2_Tests
    {
        private readonly Ex2_ExtractedGenericLoop Ex2 = new Ex2_ExtractedGenericLoop();

        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetSmallestShipReturnsCrewWithLeastCrew()
        {
            var expected = data.Ships.OrderBy(s => s.Crew).First();

            var result = Ex2.GetSmallestShip(data);

            result.Should().Be(expected);
        }

        [TestMethod]
        public void GetCommaSeparatedCommandersNamesReturnsCorrectValue()
        {
            var expected = 
                data.Commanders
                    .Aggregate("", (acc, comm) => acc + comm.Name + ",");

            var result = Ex2.GetCommaSeparatedCommandersNames(data);

            result.Should().Be(expected);
        }
    }
}