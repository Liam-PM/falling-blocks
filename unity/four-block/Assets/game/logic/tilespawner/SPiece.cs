
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class SPiece: ISpawnable
    {

        /// <summary>
        /// Spawns a new tile with a green color.
        /// </summary>
        /// <returns>A new instance of <see cref="ITileable"/> representing a green tile.</returns>
        /// <remarks>
        /// This method creates a new tile object of type <see cref="Tile"/> and initializes it with a green color.
        /// The method also logs a debug message to indicate that the spawn operation has been initiated.
        /// The returned tile can be used in the game environment where tiles are required.
        /// Note that the actual implementation of the <see cref="Tile"/> class should handle any additional properties or behaviors associated with the tile.
        /// </remarks>
        public ITileable Spawn()
        {
            Debug.Log("S");
            return new Tile(Color.green);
        }
    }
}