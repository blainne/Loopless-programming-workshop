using System.Linq;
using FluentAssertions;
using LooplessProgramming.Filtering;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Filtering
{
    [TestClass]
    public class FilteringEx3_Tests
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
            result
                .Should()
                .OnlyContain(captain => 
                    ExistsShipWithEnoughCrewAndThisCaptain(captain));
        }

        [TestMethod]
        public void GetMultishipFleetsReturnsNoDuplicates()
        {
            var result = Ex3.GetMultishipFleets(data);

            result.Should().OnlyHaveUniqueItems();
        }

        [TestMethod]
        public void GetMultishipFleetsReturnsFleetsWithMoreThanOneShip()
        {
            var result = Ex3.GetMultishipFleets(data);

            result
                .Should()
                .OnlyContain(fleet => 
                    fleet.Ships.Count() > 1);
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
