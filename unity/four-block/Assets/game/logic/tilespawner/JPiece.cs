using System;
using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class JPiece: ISpawnable
    {

        /// <summary>
        /// Spawns a new tile and returns it.
        /// </summary>
        /// <returns>A new instance of <see cref="ITileable"/> representing a blue tile.</returns>
        /// <remarks>
        /// This method creates a new tile object with a blue color and returns it as an <see cref="ITileable"/> interface.
        /// The method also logs a debug message "J" to indicate that the spawn process has been initiated.
        /// This can be useful for tracking the spawning of tiles during gameplay or debugging.
        /// The returned tile can be used in various game mechanics where tileable objects are required.
        /// </remarks>
        public ITileable Spawn()
        {
            Debug.Log("J");
            return new Tile(Color.blue);
        }
    }
}