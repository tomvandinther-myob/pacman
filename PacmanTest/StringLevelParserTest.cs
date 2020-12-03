using System;
using Pacman;
using Xunit;

namespace PacmanTest
{
    public class StringLevelParserTest
    {
        private GameLevel _gameLevel;

        public StringLevelParserTest()
        {
            var stringLevelParser = new StringLevelParser();
            _gameLevel = stringLevelParser.ParseLevelString(LevelTestDataGenerator.GetTestLevelString());
        }
        
        [Fact]
        public void StringParser_Parse_ShouldReturnGameLevel()
        {
            var levelString = LevelTestDataGenerator.GetTestLevelString();
            
            var stringParser = new StringLevelParser();

            var gameLevel = stringParser.ParseLevelString(levelString);

            Assert.IsType<GameLevel>(gameLevel);
        }

        [Theory]
        [MemberData(nameof(LevelTestDataGenerator.GetStringTokenTestSet), MemberType = typeof(LevelTestDataGenerator))]
        public void StringParser_Parse_ShouldParseCorrectCellTypes(CellType expectedCellType, Location expectedLocation)
        {
            var actualCellType = _gameLevel.GetCellType(expectedLocation.X, expectedLocation.Y);

            Assert.Equal(expectedCellType, actualCellType);
        }
    }
}