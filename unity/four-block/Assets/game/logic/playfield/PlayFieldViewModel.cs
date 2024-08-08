using game.logic.EventQueue;
using game.logic.tile;
using game.service;
using gamerunner;
using UnityEngine;

namespace game.logic.playfield
{
    public class PlayFieldViewModel: IUpdatable
    {
        private PlayField _playField;
        private ServiceLocator _serviceLocator;

        public PlayFieldViewModel(PlayField playField, ServiceLocator serviceLocator)
        {
            _playField = playField;
            _serviceLocator = serviceLocator;
            
            for (int x = 0; x < _playField.Width; x++)
            {
                for (int y = 0; y < _playField.Height; y++)
                {
                    _playField.Field[x, y] = new Tile(Color.black);
                }
            }
        }

        public int Width => _playField.Width;

        public int Height => _playField.Height;

        public ITileable[,] Tiles
        {
            get => _playField.Field;
            set => _playField.Field = value;
        }

        /// <summary>
        /// Retrieves the tile located at the specified coordinates in the play field.
        /// </summary>
        /// <param name="x">The x-coordinate of the tile to retrieve.</param>
        /// <param name="y">The y-coordinate of the tile to retrieve.</param>
        /// <returns>An object implementing the <see cref="ITileable"/> interface representing the tile at the specified coordinates.</returns>
        /// <remarks>
        /// This method accesses the underlying play field's grid structure to return the tile at the given (x, y) position.
        /// It is important to ensure that the provided coordinates are within the bounds of the play field to avoid potential errors.
        /// The returned tile can be used for various operations, such as rendering, interaction, or state management within the game.
        /// </remarks>
        public ITileable GetTile(int x, int y)
        {
            return _playField.Field[x, y];
        }

        /// <summary>
        /// Places a tile at the specified coordinates in the play field.
        /// </summary>
        /// <param name="tile">The tile to be placed in the play field.</param>
        /// <param name="x">The x-coordinate where the tile will be placed.</param>
        /// <param name="y">The y-coordinate where the tile will be placed.</param>
        /// <remarks>
        /// This method assigns the provided <paramref name="tile"/> to the specified position in the play field,
        /// which is represented as a two-dimensional array. The coordinates <paramref name="x"/> and <paramref name="y"/>
        /// must be within the bounds of the play field. If the coordinates are out of bounds, this method may throw an
        /// exception depending on the implementation of the play field. It is important to ensure that the tile being placed
        /// is valid and that the specified location is not already occupied by another tile, if such rules apply to the game logic.
        /// </remarks>
        public void PlaceTile(ITileable tile, int x, int y)
        {
            _playField.Field[x, y] = tile;
        }

        /// <summary>
        /// Updates the game state by processing events from the event queue.
        /// </summary>
        /// <remarks>
        /// This method retrieves the event queue from the service locator and checks for a specific event identified by <c>EventId.SpawnTile</c>.
        /// If a <c>SpawnTileEvent</c> is found, it invokes the delegate to create a tile shape and places the tile at the specified coordinates (0, 0).
        /// This method is typically called during the game loop to ensure that events are processed in a timely manner.
        /// </remarks>
        public void Update()
        {
            var eventQueue = _serviceLocator.GetService<EventQueue.EventQueue>();
            var e = (SpawnTileEvent)eventQueue.Dequeue(EventId.SpawnTile);
            if (e != null)
            {
                var createTileShape = e.CreateTileShapeDelegate;
                var shape = createTileShape();
                PlaceTile(shape.Spawn(), 0, 0);
            }
        }
    }
}