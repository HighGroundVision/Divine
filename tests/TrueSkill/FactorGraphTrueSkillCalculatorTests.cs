using HGV.Divine.TrueSkill;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HGV.Divine.Tests.TrueSkill
{
    [TestClass]
    public class FactorGraphTrueSkillCalculatorTests
    {
        [TestMethod]
        public void FullFactorGraphCalculatorTests()
        {
            var calculator = new FactorGraphTrueSkillCalculator();

            // We can test all classes 
            TrueSkillCalculatorTests.TestAllTwoPlayerScenarios(calculator);
            TrueSkillCalculatorTests.TestAllTwoTeamScenarios(calculator);
            TrueSkillCalculatorTests.TestAllMultipleTeamScenarios(calculator);

            TrueSkillCalculatorTests.TestPartialPlayScenarios(calculator);
        }
    }
}