using System;
using System.Collections.Generic;
using System.Linq;
using game.service;
using Unity.VisualScripting;
using Random = System.Random;

namespace game.logic.tilespawner
{
    public class TileSpawnerService: IService
    {
        public delegate ISpawnable CreateTileShapeDelegate();
        
        List<CreateTileShapeDelegate> _pieces = new List<CreateTileShapeDelegate>{
            SpawnIPiece, SpawnJPiece, SpawnLPiece, SpawnOPiece, SpawnSPiece, SpawnTPiece, SpawnZPiece
        };

        public TileSpawnerService()
        {
            Shuffle();
        }

        /// <summary>
        /// Creates and returns a new instance of the IPiece class.
        /// </summary>
        /// <returns>A new instance of <see cref="IPiece"/>.</returns>
        /// <remarks>
        /// This method is responsible for instantiating an object of type <see cref="IPiece"/>.
        /// The <see cref="IPiece"/> class is expected to implement the <see cref="ISpawnable"/> interface,
        /// which defines the necessary behavior for objects that can be spawned in the application.
        /// This method does not take any parameters and provides a straightforward way to obtain a new piece
        /// for use in the game or application context where pieces are required.
        /// </remarks>
        private static ISpawnable SpawnIPiece() => new IPiece();

        /// <summary>
        /// Creates and returns a new instance of the JPiece.
        /// </summary>
        /// <returns>A new instance of <see cref="JPiece"/> that implements the <see cref="ISpawnable"/> interface.</returns>
        /// <remarks>
        /// This method is responsible for instantiating a JPiece object, which is expected to implement the ISpawnable interface.
        /// The JPiece class likely represents a specific type of game piece or object that can be spawned in a game or simulation context.
        /// This method does not take any parameters and directly returns the newly created instance.
        /// </remarks>
        private static ISpawnable SpawnJPiece() => new JPiece();

        /// <summary>
        /// Creates and returns a new instance of the LPiece class.
        /// </summary>
        /// <returns>A new instance of <see cref="LPiece"/> that implements the <see cref="ISpawnable"/> interface.</returns>
        /// <remarks>
        /// This method is responsible for instantiating the LPiece object, which is part of a larger game or application that utilizes
        /// spawnable pieces. The LPiece class likely represents a specific shape or entity that can be used within the context of the
        /// application, such as in a game where different pieces are spawned dynamically. The method ensures that a fresh instance
        /// of LPiece is created each time it is called, allowing for multiple instances to exist independently in the application.
        /// </remarks>
        private static ISpawnable SpawnLPiece() => new LPiece();

        /// <summary>
        /// Creates and returns a new instance of the OPiece class.
        /// </summary>
        /// <returns>A new instance of <see cref="OPiece"/> that implements the <see cref="ISpawnable"/> interface.</returns>
        /// <remarks>
        /// This method is responsible for instantiating an object of type OPiece, which is expected to implement the ISpawnable interface.
        /// The OPiece class represents a specific type of spawnable object in the application, and this method provides a way to create it without exposing the details of its construction.
        /// This encapsulation allows for better maintainability and flexibility in the codebase, as changes to the OPiece class can be made without affecting the consumers of this method.
        /// </remarks>
        private static ISpawnable SpawnOPiece() => new OPiece();

        /// <summary>
        /// Creates and returns a new instance of the SPiece class.
        /// </summary>
        /// <returns>A new instance of <see cref="SPiece"/> that implements the <see cref="ISpawnable"/> interface.</returns>
        /// <remarks>
        /// This method is responsible for instantiating the SPiece object, which is expected to implement the ISpawnable interface.
        /// The SPiece class likely contains specific logic or properties related to its functionality within the application.
        /// This method does not take any parameters and provides a straightforward way to obtain a new SPiece instance whenever needed.
        /// </remarks>
        private static ISpawnable SpawnSPiece() => new SPiece();

        /// <summary>
        /// Creates and returns a new instance of the TPiece class.
        /// </summary>
        /// <returns>A new instance of <see cref="TPiece"/> that implements the <see cref="ISpawnable"/> interface.</returns>
        /// <remarks>
        /// This method is responsible for instantiating a TPiece object, which is typically used in the context of a game or simulation
        /// where different types of pieces need to be spawned. The TPiece class implements the ISpawnable interface, ensuring that it
        /// adheres to the expected contract for spawnable objects. This method does not take any parameters and provides a straightforward
        /// way to obtain a new TPiece instance whenever needed.
        /// </remarks>
        private static ISpawnable SpawnTPiece() => new TPiece();

        /// <summary>
        /// Creates and returns a new instance of the ZPiece.
        /// </summary>
        /// <returns>A new instance of <see cref="ZPiece"/> that implements the <see cref="ISpawnable"/> interface.</returns>
        /// <remarks>
        /// This method is responsible for instantiating a ZPiece object, which is a specific type of spawnable entity in the application.
        /// The ZPiece is typically used in contexts where game pieces or similar objects need to be generated dynamically.
        /// This method ensures that a fresh instance of ZPiece is created each time it is called, allowing for unique instances to be used in gameplay or other logic.
        /// </remarks>
        private static ISpawnable SpawnZPiece() => new ZPiece();

        /// <summary>
        /// Spawns a new tile shape by shuffling the available pieces and returning the first piece.
        /// </summary>
        /// <returns>A delegate representing the first tile shape after shuffling the pieces.</returns>
        /// <remarks>
        /// This method first calls the <see cref="Shuffle"/> method to randomize the order of the available tile pieces.
        /// After shuffling, it retrieves and returns the first piece from the shuffled collection.
        /// This ensures that each call to <see cref="Spawn"/> can yield a different tile shape, enhancing the variability in tile generation.
        /// The returned delegate can be used to create or manipulate the tile shape as needed.
        /// </remarks>
        public CreateTileShapeDelegate Spawn()
        {
            Shuffle();
            return _pieces.First();
        }

        private Random rng = new Random();

        /// <summary>
        /// Shuffles the elements of the collection randomly.
        /// </summary>
        /// <remarks>
        /// This method implements the Fisher-Yates shuffle algorithm to randomly reorder the elements in the
        /// private collection of pieces. It iterates through the collection, selecting a random index and
        /// swapping the current element with the element at that random index. This process continues until
        /// all elements have been processed, resulting in a uniformly shuffled collection.
        /// The original order of the elements is lost after this operation.
        /// </remarks>
        private void Shuffle()  
        {  
            var n = _pieces.Count;  
            while (n > 1) {  
                n--;  
                var k = rng.Next(n + 1);  
                (_pieces[k], _pieces[n]) = (_pieces[n], _pieces[k]);
            }  
        }
    }
}