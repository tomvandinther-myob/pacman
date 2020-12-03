using Pacman;
using Xunit;

namespace PacmanTest
{
    public class GameLevelTest
    {
        [Fact]
        public void GameLevel_FromString_ShouldParseStringIntoGameMap()
        {
            var levelString = LevelTestDataGenerator.GetTestLevelString();

            var gameLevel = GameLevel.FromString(levelString);

            Assert.IsType<GameLevel>(gameLevel);
        }
    }
}