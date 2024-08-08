using System;
using gamerunner;
using UnityEngine;

namespace game.logic
{
    [Serializable]
    public class TimeBasedGravityStrategy : IUpdatable, IGravityStrategy
    {
        private float _gravityBase = 9.8f;
        private float _gravityScale = 1.0f;
        private float _gravityIncreasePerSecond = 0.1f;
    
        public float CurrentGravity => _gravityBase * _gravityScale;
        public float Gravity => _gravityBase * _gravityScale;

        /// <summary>
        /// Updates the gravity scale based on the elapsed time since the last frame.
        /// </summary>
        /// <remarks>
        /// This method adjusts the gravity scale by incrementing it with a value that is calculated
        /// from the predefined gravity increase per second multiplied by the time elapsed since the
        /// last frame (Time.deltaTime). This allows for a smooth and gradual change in gravity over time.
        /// The method does not return any value and is intended to be called once per frame to ensure
        /// that the gravity scale is updated continuously during the game's runtime.
        /// </remarks>
        public void Update()
        {
            setGravityScale(_gravityScale + _gravityIncreasePerSecond * Time.deltaTime);
        }

        /// <summary>
        /// Sets the gravity scale to the specified value.
        /// </summary>
        /// <param name="gravityScale">The new gravity scale value to be set.</param>
        /// <remarks>
        /// This method updates the private field <c>_gravityScale</c> with the provided value.
        /// The gravity scale is typically used in physics simulations to adjust the strength of gravitational effects
        /// on objects within the simulation. By calling this method, you can modify how gravity influences the behavior
        /// of objects, allowing for more realistic or exaggerated effects as needed for the application.
        /// </remarks>
        public void setGravityScale(float gravityScale)
        {
            _gravityScale = gravityScale;
        }
    }
}
