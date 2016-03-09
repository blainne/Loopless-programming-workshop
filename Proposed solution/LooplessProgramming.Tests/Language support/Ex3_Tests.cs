using LooplessProgramming.LanguageSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using LooplessProgramming.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Language_support
{
    [TestClass]
    public class Ex3_Tests
    {
        private readonly Ex3_LinqSupport Ex3 = new Ex3_LinqSupport();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetNamesOfBattleships_ReturnsCorrectResult()
        {
            var expected =
                data.Ships
                    .Where(s => s.ShipClass == WarshipClass.Battleship)
                    .Select(s => s.Name);

            var result = Ex3.GetNamesOfBattleships(data);

            result.ShouldAllBeEquivalentTo(expected);
        }
    }
}
