using System.Collections.Generic;
using Pacman;

namespace PacmanTest
{
    public class LevelTestDataGenerator
    {
        public static string GetTestLevelString()
        {
            return @"#####
#o..#
#P .#
#x++#
#####";
        }

        public static IEnumerable<object[]> GetStringTokenTestSet()
        {
            yield return new object[]
            {
                CellType.Wall,
                new Location(0, 0)
            };
                
            yield return new object[]
            {
                CellType.Pellet,
                new Location(1, 3)
            };
            
            yield return new object[]
            {
                CellType.PowerPellet,
                new Location(1, 1)
            };
            
            yield return new object[]
            {
                CellType.PacmanSpawn,
                new Location(2, 1)
            };
            
            yield return new object[]
            {
                CellType.Impassable,
                new Location(3, 1)
            };
            
            yield return new object[]
            {
                CellType.GhostSpawn,
                new Location(3, 3)
            };
            
            yield return new object[]
            {
                CellType.Passable,
                new Location(2, 2)
            };
        }
    }
}