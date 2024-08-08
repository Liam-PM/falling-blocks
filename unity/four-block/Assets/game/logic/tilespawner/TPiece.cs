
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class TPiece: ISpawnable
    {

        /// <summary>
        /// Creates and spawns a new tile with a specified color.
        /// </summary>
        /// <returns>A new instance of <see cref="ITileable"/> representing the spawned tile.</returns>
        /// <remarks>
        /// This method instantiates a new tile object with the color magenta.
        /// The spawned tile can be used in various game or application contexts where a tileable object is required.
        /// The method returns an object that implements the <see cref="ITileable"/> interface, allowing for polymorphic behavior
        /// when working with different types of tileable objects.
        /// The specific implementation of the tile is determined by the constructor of the Tile class.
        /// </remarks>
        public ITileable Spawn()
        {
            return new Tile(Color.magenta);
        }
    }
}