using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System.Linq;

namespace LooplessProgramming.Tests
{
    [TestClass]
    public class Ex3_Tests
    {
        private readonly Ex3_MoreGenericFiltering Ex3 = new Ex3_MoreGenericFiltering();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetCaptainsWithMostResponsiblityReturnsNoDuplicates()
        {
            var result = Ex3.GetCaptainsWithMostResponsiblity(data);

            result.Should().OnlyHaveUniqueItems();
        }

        [TestMethod]
        public void GetCaptainsWithMostResponsiblityReturnsCaptainsWithAtLeast1500Subordinates()
        {
            var result = Ex3.GetCaptainsWithMostResponsiblity(data);
            result.Should().OnlyContain(captain => ExistsShipWithEnoughCrewAndThisCaptain(captain));
        }

        private bool ExistsShipWithEnoughCrewAndThisCaptain(Model.Person captain)
        {
            return data.Ships.Any(
                s => 
                    s.Captain.Name == captain.Name
                    && s.Crew >= 1500
            );
        }
    }
}
