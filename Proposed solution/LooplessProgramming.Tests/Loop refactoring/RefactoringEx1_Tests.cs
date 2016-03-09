using LooplessProgramming.LoopRefactoring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Loop_refactoring
{
    [TestClass]
    public class RefactoringEx1_Tests
    {
        private readonly Ex1_Simple Ex1 = new Ex1_Simple();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetShipsWithYoungCaptains_ReturnsCorrectResult()
        {
            var expected = data.Ships.Where(s => s.Captain.YearsOfService <= 25);
            var result = Ex1.GetShipsWithYoungCaptains(data);

            result.ShouldAllBeEquivalentTo(expected);
        }

        [TestMethod]
        public void GetNonNullNorEmptyStrings_ReturnsCorrectResult()
        {
            var stringData = new List<string> {null, "", "test", "test2", "", "something", null, " "};

            var expected = stringData.Where(s => !string.IsNullOrEmpty(s));
            var result = Ex1.GetNonNullNorEmptyStrings(stringData);

            result.ShouldAllBeEquivalentTo(expected);
        }

        [TestMethod]
        public void GetSquares_ReturnsSquaresOfInputNumbers()
        {
            var data = Enumerable.Range(-15, 33);
            var expected = data.Select(x => x*x);
            var result = Ex1.GetSquares(data.ToList());

            result.ShouldAllBeEquivalentTo(expected);
        }

        [TestMethod]
        public void AreAllStringsLongerThan5_ReturnsFalseWhenTooShortStringExists()
        {
            var stringData = new List<string> {"somethingLonger", "aaaaaaaa", "bbbbbbb", "", "something", "4444"};
            var expected = stringData.All(s => s.Length > 5);
            var result = Ex1.AreAllStringsLongerThan5(stringData);

            result.Should().BeFalse();

        }

        [TestMethod]
        public void AreAllStringsLongerThan5_ReturnsTrueWhenAllStringsSatisfy()
        {
            var stringData = new List<string> { "somethingLonger", "aaaaaaaa", "bbbbbbb", "something" };
            var expected = stringData.All(s => s.Length > 5);
            var result = Ex1.AreAllStringsLongerThan5(stringData);

            result.Should().BeTrue();

        }
    }
}
