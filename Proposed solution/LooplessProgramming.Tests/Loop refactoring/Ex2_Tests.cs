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
    public class Ex2_Tests
    {
        private readonly Ex2_Complex Ex2 = new Ex2_Complex();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void AreAllNonEmptyStringsLongerThan5_ReturnsFalseWhenIncorrectStringExists()
        {
            var stringData = new List<string> {null, "", "somethingLonger", "aaaaaaaa", "bbbbbbb", "1234" , "something" };
            var expected = stringData.Where(s => !string.IsNullOrEmpty(s)).All(s => s.Length > 5);
            var result = Ex2.AreAllNonEmptyStringsLongerThan5(stringData);

            result.Should().BeFalse();

        }

        [TestMethod]
        public void AreAllNonEmptyStringsLongerThan5_ReturnsTrueWhenAllStringsSatisfy()
        {
            var stringData = new List<string> { null, "", "somethingLonger", "aaaaaaaa", "bbbbbbb", "something" };
            var expected = stringData.Where(s => !string.IsNullOrEmpty(s)).All(s => s.Length > 5);
            var result = Ex2.AreAllNonEmptyStringsLongerThan5(stringData);

            result.Should().BeTrue();
        }

        [TestMethod]
        public void GetSumOfNumbers_ReturnsCorrectResult()
        {
            var stringData = new List<string> { null, "", "something", "1", "", "15", "-3"};
            var expected =
                stringData
                    .Where(s => !string.IsNullOrEmpty(s))
                    .Select(s => ParsedOrNull(s))
                    .Where(p => p != null)
                    .Sum(p => p.Value);

            var result = Ex2.GetSumOfNumbers(stringData);

            result.Should().Be(expected);
        }

        private int? ParsedOrNull(string s)
        {
            int result = 0;
            return 
                (int.TryParse(s, out result))
                ? new int?(result)
                : null;
        }
    }
}

