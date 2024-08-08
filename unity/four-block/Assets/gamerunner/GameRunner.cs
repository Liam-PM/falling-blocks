using System.Collections;
using System.Collections.Generic;
using game.logic;
using game.logic.EventQueue;
using game.logic.tile;
using game.logic.tilespawner;
using game.service;
using gamerunner;
using UnityEngine;

public class GameRunner : IUpdatable
{
    private ServiceLocator _serviceLocator;
    private float _gravitySum = 0.0f;
    private int frames = 0;
    
    public TileSpawnerService.CreateTileShapeDelegate CreateTileShape;

    public GameRunner(ServiceLocator serviceLocator)
    {
        _serviceLocator = serviceLocator;
    }

    /// <summary>
    /// Updates the state of the object by processing gravity and potentially spawning new tiles.
    /// </summary>
    /// <remarks>
    /// This method retrieves the current gravity from the <see cref="GravityService"/> and accumulates it in the <c>_gravitySum</c> variable.
    /// It increments the frame counter and checks if the accumulated gravity exceeds a threshold of 100.0f.
    /// If the threshold is exceeded, it resets the frame counter and the gravity sum, and then it spawns a new tile shape using the <see cref="TileSpawnerService"/>.
    /// The newly created tile shape is then enqueued as a <see cref="SpawnTileEvent"/> in the event queue.
    /// This method relies on a service locator to obtain necessary services and modifies internal state variables accordingly.
    /// </remarks>
    public void Update()
    {
        var gravity = _serviceLocator.GetService<GravityService>();
        _gravitySum += gravity.CurrentGravity;
        frames++;
        if(_gravitySum > 100.0f)
        {
            var spawner = _serviceLocator.GetService<TileSpawnerService>();
            frames = 0;
            _gravitySum = 0.0f;
            if (CreateTileShape == null)
            {
                CreateTileShape = spawner.Spawn();    
            }
            
            var eventQueue = _serviceLocator.GetService<EventQueue>();
            eventQueue.Enqueue(new SpawnTileEvent(this, CreateTileShape));
            
            CreateTileShape = spawner.Spawn();
        }
    }
}
