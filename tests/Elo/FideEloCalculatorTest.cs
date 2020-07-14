using HGV.Divine;
using HGV.Divine.Elo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HGV.Divine.Tests.Elo
{
    [TestClass]
    public class FideEloCalculatorTest
    {        
        [TestMethod]
        public void FideProvisionalEloCalculatorTests()
        {
            // verified against http://ratings.fide.com/calculator_rtd.phtml
            // Indicates someone who has played less than 30 games.
            var calc = new FideEloCalculator(new FideKFactor.Provisional());
            
            EloAssert.AssertChessRating(calc, 1200, 1500, PairwiseComparison.Win, 1221.25, 1478.75);
            EloAssert.AssertChessRating(calc, 1200, 1500, PairwiseComparison.Draw, 1208.75, 1491.25);
            EloAssert.AssertChessRating(calc, 1200, 1500, PairwiseComparison.Lose, 1196.25, 1503.75);
        }

        [TestMethod]
        public void FideNonProvisionalEloCalculatorTests()
        {
            // verified against http://ratings.fide.com/calculator_rtd.phtml
            var calc = new FideEloCalculator();

            EloAssert.AssertChessRating(calc, 1200, 1200, PairwiseComparison.Win, 1207.5, 1192.5);
            EloAssert.AssertChessRating(calc, 1200, 1200, PairwiseComparison.Draw, 1200, 1200);
            EloAssert.AssertChessRating(calc, 1200, 1200, PairwiseComparison.Lose, 1192.5, 1207.5);

            EloAssert.AssertChessRating(calc, 2600, 2500, PairwiseComparison.Win, 2603.6, 2496.4);
            EloAssert.AssertChessRating(calc, 2600, 2500, PairwiseComparison.Draw, 2598.6, 2501.4);
            EloAssert.AssertChessRating(calc, 2600, 2500, PairwiseComparison.Lose, 2593.6, 2506.4);            
        }
    }
}