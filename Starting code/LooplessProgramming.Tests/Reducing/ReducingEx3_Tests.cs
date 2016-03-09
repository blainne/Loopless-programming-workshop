using FluentAssertions;
using LooplessProgramming.Reducing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LooplessProgramming.Tests.Reducing
{
    [TestClass]
    public class ReducingEx3_Tests
    {
        private readonly Ex3_ReducingData Ex3 = new Ex3_ReducingData();

        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetCumulativeYearsOfService_ReturnsCorrectValue()
        {
            var expected = data.Ships.Aggregate(0, (acc, s) => acc + s.Captain.YearsOfService);

            var result = Ex3.GetCumulativeYearsOfService(data);

            result.Should().Be(expected);
        }
    }
}
