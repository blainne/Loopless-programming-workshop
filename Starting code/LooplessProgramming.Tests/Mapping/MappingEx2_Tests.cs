using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LooplessProgramming.Mapping;
using System.Linq;
using FluentAssertions;

namespace LooplessProgramming.Tests.Mapping
{
    [TestClass]
    public class MappingEx2_Tests
    {
        private readonly Ex2_ExtractedLoop Ex2 = new Ex2_ExtractedLoop();
        
        private readonly SampleData data = new SampleData();


        [TestMethod]
        public void GetShipsCaptainsExperienceReturnsYearsOfServiceOfEachCaptain()
        {
            var expected = data.Ships.Select(s => s.Captain.YearsOfService);

            var result = Ex2.GetShipsCaptainsExperience(data);

            result.ShouldAllBeEquivalentTo(expected);
        }

        [TestMethod]
        public void GetShipsAssignmentInfoReturnsNamesOfShipsAndCaptains()
        {
            var expected = 
                data.Ships.Select(
                    s => 
                        new Ex1_ShipAndCommander
                        {
                                ShipName = s.Name,
                                CaptainName = s.Captain.Name
                        });

            var result = Ex2.GetShipsAssignmentInfo(data);

            result.ShouldAllBeEquivalentTo(expected);
        }
    }
}
