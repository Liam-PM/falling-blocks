using gamerunner;
using UnityEngine;

namespace game.logic
{
    public class GravityService : IUpdatable, IGravityService
    {
        private IGravityStrategy _gravityStrategy;

        public float CurrentGravity => _gravityStrategy.CurrentGravity;

        public GravityService(IGravityStrategy gravityStrategy)
        {
            _gravityStrategy = gravityStrategy;
        }

        /// <summary>
        /// Updates the current state of the gravity strategy if it implements the IUpdatable interface.
        /// </summary>
        /// <remarks>
        /// This method checks if the current _gravityStrategy instance can be cast to the IUpdatable interface.
        /// If it can, the Update method of the updatable instance is called, allowing for any necessary updates to be performed.
        /// This is useful in scenarios where different gravity strategies may have their own update logic that needs to be executed regularly.
        /// If the _gravityStrategy does not implement IUpdatable, no action is taken.
        /// </remarks>
        public void Update()
        {
            if (_gravityStrategy is IUpdatable updatable)
            {
                updatable.Update();
            }
        }
    }
}
