using LooplessProgramming.LanguageSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Language_support
{
    [TestClass]
    public class LanguageEx2_Tests
    {
        private readonly Ex2_AnonymousObjects Ex2 = new Ex2_AnonymousObjects();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void AddRandomNumbersToShipsAndPickPositiveOnes_1_ResultsContainShipNames()
        {
            var result = Ex2.AddRandomNumbersToShipsAndPickPositiveOnes_1(data);

            CheckAllStringsContainValidShipsNames(result)
                .Should().BeTrue();
        }

        [TestMethod]
        public void AddRandomNumbersToShipsAndPickPositiveOnes_1_ResultsContainOnlyPositiveNumbers()
        {
            var result = Ex2.AddRandomNumbersToShipsAndPickPositiveOnes_1(data);

            CheckAllStringsContainPositiveNumbers(result)
                .Should().BeTrue();
        }



        [TestMethod]
        public void AddRandomNumbersToShipsAndPickPositiveOnes_2_ResultsContainShipNames()
        {
            var result = Ex2.AddRandomNumbersToShipsAndPickPositiveOnes_2(data);

            CheckAllStringsContainValidShipsNames(result)
                .Should().BeTrue();
        }


        [TestMethod]
        public void AddRandomNumbersToShipsAndPickPositiveOnes_2_ResultsContainOnlyPositiveNumbers()
        {
            var result = Ex2.AddRandomNumbersToShipsAndPickPositiveOnes_2(data);

            CheckAllStringsContainPositiveNumbers(result)
                .Should().BeTrue();
        }


        private bool CheckAllStringsContainPositiveNumbers(IEnumerable<string> result)
        {
            return result
                .Select(s => s.Split(": ".ToCharArray()).Last())
                .All(text => int.Parse(text) % 2 == 1);
        }

        private bool CheckAllStringsContainValidShipsNames(IEnumerable<string> result)
        {
            return result
                .Select(s => s.Split(":".ToCharArray()).First())
                .All(text => data.Ships.Exists(s => s.Name == text));
        }
    }
}
