using Pacman;
using Xunit;

namespace PacmanTest
{
    public class NavGraphTest
    {
        private NavGraph _navGraph;

        public NavGraphTest()
        {
            var gameLevel = LevelTestDataGenerator.GetTestGameLevel();
            _navGraph = NavGraph.FromGameLevel(gameLevel);
        }
        
        [Fact]
        public void NavGraph_FromGameLevel_ShouldReturnNavGraph()
        {
            var gameLevel = LevelTestDataGenerator.GetTestGameLevel();
            var navGraph = NavGraph.FromGameLevel(gameLevel);

            Assert.IsType<NavGraph>(navGraph);
        }

        [Fact]
        public void NavGraph_GetNode_Exists_ShouldReturnValidNode()
        {
            var node = _navGraph.GetNode(new Location(1, 1));


            Assert.IsType<Node>(node);
        }
        
        [Fact]
        public void NavGraph_GetNode_NotExists_ShouldReturnNull()
        {
            var node = _navGraph.GetNode(new Location(0, 0));
            
            Assert.Null(node);
        }
    }
}