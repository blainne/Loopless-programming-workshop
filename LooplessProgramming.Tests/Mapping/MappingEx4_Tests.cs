using System;
using System.Linq;
using FluentAssertions;
using LooplessProgramming.Mapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Mapping
{
    [TestClass]
    public class MappingEx4_Tests
    {
        private readonly Ex4_MappingData Ex4 =
            new Ex4_MappingData();

        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetFleetsCommandersReports_ReturnsCorrectCommanderInfo()
        {
            var expected = 
                data.Fleets.Values
                .Select(f => new Ex4_CommanderInfo(
                                    f.Commander.Name, 
                                    f.Commander.YearsOfService,
                                    f.Ships.Count()));

            var result = Ex4.GetFleetsCommandersReports(data);

            result.ShouldAllBeEquivalentTo(expected);
        }
    }
}
