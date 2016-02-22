using System.Linq;
using FluentAssertions;
using LooplessProgramming.Filtering;
using LooplessProgramming.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Filtering
{
    [TestClass]
    public class FilteringEx2_Tests
    {
        private readonly Ex2_ExtractedLoop  Ex2 = new Ex2_ExtractedLoop();
        private readonly SampleData data = new SampleData();

        [TestMethod]
        public void GetBigCruisersReturnsCruisersOnly()
        {
            var result = Ex2.GetBigCruisers(data);

            result
                .Should().OnlyContain(ship => ship.ShipClass == WarshipClass.Cruiser);
        }

        [TestMethod]
        public void GetBigCruisersReturnsShipsWithAtLeast2000CrewMembers()
        {
            var result = Ex2.GetBigCruisers(data);

            result
                .Should().OnlyContain(ship => ship.Crew >= 2000);
        }

        [TestMethod]
        public void GetBigCruisersReturnsNoDuplicateShips()
        {
            var result = Ex2.GetBigCruisers(data);

            result
                .Should().OnlyHaveUniqueItems();
        }

        [TestMethod]
        public void GetQuickReactingDestroyersReturnsDestroyersOnly()
        {
            var result = Ex2.GetQuickReactingDestroyers(data);

            result
                .Should().OnlyContain(ship => ship.ShipClass == WarshipClass.Destroyer);
        }

        [TestMethod]
        public void GetQuickReactingDestroyersReturnsShipFromQuickReactionFleetOnly()
        {
            var result = Ex2.GetQuickReactingDestroyers(data);

            result.Should().OnlyContain(
                    ship => 
                        data.Fleets["Quick reaction fleet"].Ships.Contains(ship));
                
        }

        [TestMethod]
        public void GetQuickReactingDestroyersReturnsNoDuplicateShips()
        {
            var result = Ex2.GetQuickReactingDestroyers(data);

            result.Should().OnlyHaveUniqueItems();
        }
    }
}
