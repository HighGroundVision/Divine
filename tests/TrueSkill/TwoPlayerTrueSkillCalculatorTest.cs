using HGV.Divine.TrueSkill;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HGV.Divine.Tests.TrueSkill
{
    [TestClass]
    public class TwoPlayerTrueSkillCalculatorTest
    {
        [TestMethod]
        public void TwoPlayerTrueSkillCalculatorTests()
        {
            var calculator = new TwoPlayerTrueSkillCalculator();

            // We only support two players
            TrueSkillCalculatorTests.TestAllTwoPlayerScenarios(calculator);

            // TODO: Assert failures for larger teams
        }    
    }
}