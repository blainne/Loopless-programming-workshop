using FluentAssertions;
using LooplessProgramming.Filtering;
using LooplessProgramming.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LooplessProgramming.Tests.Filtering
{
    [TestClass]
    public class FilteringEx4_Tests
    {
        private readonly Ex4_FilterAsExtension.Ex4_FilteringData Ex4 = 
                            new Ex4_FilterAsExtension.Ex4_FilteringData();

        private readonly SampleData data = new SampleData();
        private readonly SampleData originalData = new SampleData();

        [TestMethod]
        public void GetAllBattleshipsReturnsNoDuplicates()
        {
            var result = Ex4.GetAllBattleships(data);

            result.Should().OnlyHaveUniqueItems();
        }


        [TestMethod]
        public void GetAllBattleshipsReturnsOnlyBattleships()
        {
            var result = Ex4.GetAllBattleships(data);
            result
                .Should()
                .OnlyContain(ship => 
                    ship.ShipClass == WarshipClass.Battleship);
        }

        [TestMethod]
        public void GetAllBattleshipsReturnsAllBattleships()
        {
            var result = Ex4.GetAllBattleships(data);
            result.Should().HaveCount(2);
        }


        [TestMethod]
        public void GetAllCommandersOnMReturnsNoDuplicates()
        {
            var result = Ex4.GetCommandersOnM(data);

            result.Should().OnlyHaveUniqueItems();
        }

        [TestMethod]
        public void GetAllCommandersOnMReturnsOnlyCommandersOnM()
        {
            var result = Ex4.GetCommandersOnM(data);

            result
                .Should()
                .OnlyContain(person => 
                    person.Name.ToLower().StartsWith("m"));
        }

        [TestMethod]
        public void GetAllCommandersOnMReturnsAllCommandersOnM()
        {
            var result = Ex4.GetCommandersOnM(data);

            result.Should().HaveCount(3);
        }
    }
}
