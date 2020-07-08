using HGV.Divine.TrueSkill;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HGV.Divine.Tests.TrueSkill
{
    [TestClass]
    public class TwoTeamTrueSkillCalculatorTest
    {
        [TestMethod]
        public void TwoTeamTrueSkillCalculatorTests()
        {
            var calculator = new TwoTeamTrueSkillCalculator();

            // This calculator supports up to two teams with many players each
            TrueSkillCalculatorTests.TestAllTwoPlayerScenarios(calculator);
            TrueSkillCalculatorTests.TestAllTwoTeamScenarios(calculator);
        }
    }
}