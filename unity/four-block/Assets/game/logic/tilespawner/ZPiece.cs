
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class ZPiece: ISpawnable
    {

        /// <summary>
        /// Spawns a new tile and returns it.
        /// </summary>
        /// <returns>A new instance of <see cref="ITileable"/> representing a red tile.</returns>
        /// <remarks>
        /// This method is responsible for creating a new tile object of type <see cref="Tile"/> with a red color.
        /// It logs a message to the debug console indicating that the spawn process has started.
        /// The newly created tile can be used in the game environment where tiles are needed.
        /// This method does not take any parameters and directly returns the newly created tile instance.
        /// </remarks>
        public ITileable Spawn()
        {
            Debug.Log("Z");
            return new Tile(Color.red);
        }
    }
}