using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LooplessProgramming.Mapping;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Mapping
{
    [TestClass]
    public class MappingEx3_Tests
    {
        private readonly Ex3_MoreGenericMapping Ex3 = 
            new Ex3_MoreGenericMapping();

        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetFleetsNamesReturnsNamesOfFleets()
        {
            var expected = data.Fleets.Values.Select(f => f.Name);

            var result = Ex3.GetFleetsNames(data);

            result.ShouldAllBeEquivalentTo(expected);
        }

        [TestMethod]
        public void GetShipsCrewsAmountsReturnsAmountsOfCrewMembers()
        {
            var expected = data.Ships.Select(s => s.Crew);

            var result = Ex3.GetShipsCrewsAmounts(data);

            result.ShouldAllBeEquivalentTo(expected);
        }
    }
}
