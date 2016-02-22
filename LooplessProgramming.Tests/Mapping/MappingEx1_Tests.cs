using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LooplessProgramming.Mapping;
using System.Linq;
using FluentAssertions;

namespace LooplessProgramming.Tests.Mapping
{
    [TestClass]
    public class MappingEx1_Tests
    {
        private readonly Ex1_LoopMapping Ex1 = new Ex1_LoopMapping();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetAllShipsNamesReturnsNamesOfShips()
        {
            var namesOfShips = data.Ships.Select(s => s.Name);

            var result = Ex1.GetAllShipNames(data);

            result.ShouldAllBeEquivalentTo(namesOfShips);
        }
    }
}
