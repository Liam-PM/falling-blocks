
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class OPiece: ISpawnable
    {

        /// <summary>
        /// Spawns a new tile and returns it.
        /// </summary>
        /// <returns>A new instance of <see cref="ITileable"/> representing a yellow tile.</returns>
        /// <remarks>
        /// This method creates a new tile of type <see cref="Tile"/> with a yellow color.
        /// It logs a message to the debug console indicating that the spawn process has been initiated.
        /// The returned tile can be used in various game scenarios where a tileable object is required.
        /// The method does not take any parameters and always returns a new tile instance.
        /// </remarks>
        public ITileable Spawn()
        {
            Debug.Log("O");
            return new Tile(Color.yellow);
        }
    }
}