using game.logic.tile;
using UnityEngine;

namespace game.logic.tilespawner
{
    public class LPiece: ISpawnable
    {

        /// <summary>
        /// Spawns a new tile and returns it.
        /// </summary>
        /// <returns>An instance of <see cref="ITileable"/> representing the newly spawned tile.</returns>
        /// <remarks>
        /// This method creates a new tile with a specific color (orange in this case) and returns it as an object that implements the <see cref="ITileable"/> interface.
        /// The method also logs a message to the debug console for tracking purposes.
        /// The color of the tile is defined using RGB values, where the red component is set to 1, the green component is set to 0.5, and the blue component is set to 0.
        /// This allows for easy customization of the tile's appearance when spawned.
        /// </remarks>
        public ITileable Spawn()
        {
            Debug.Log("L");
            return new Tile(new Color(1f, 0.5f, 0f));
        }
    }
}