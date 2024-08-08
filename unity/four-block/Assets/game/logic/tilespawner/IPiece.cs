
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class IPiece: ISpawnable
    {

        /// <summary>
        /// Spawns a new tile and returns it.
        /// </summary>
        /// <returns>A new instance of <see cref="ITileable"/> representing a tile with a cyan color.</returns>
        /// <remarks>
        /// This method creates a new tile object of type <see cref="Tile"/> with the color set to cyan.
        /// It logs a message to the debug console indicating that a tile is being spawned.
        /// The returned tile can be used in the game environment for various purposes, such as
        /// representing a game object or a visual element in the user interface.
        /// The method does not take any parameters and always returns a new tile instance.
        /// </remarks>
        public ITileable Spawn()
        {
            Debug.Log("I");
            return new Tile(Color.cyan);
        }
    }
}