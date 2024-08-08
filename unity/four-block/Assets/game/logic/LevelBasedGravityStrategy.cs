using System;
using gamerunner;
using UnityEngine;

namespace game.logic
{
    [Serializable]
    public class LevelBasedGravityStrategy : IGravityStrategy
    {
        private readonly float _gravityBase = 9.8f;
        private int _level = 1;
        private const float GravityIncreasePerLevel = 0.75f;
    
        public float CurrentGravity => _gravityBase * _level;
        public float Gravity => _gravityBase * _level;

        /// <summary>
        /// Sets the level to the specified value.
        /// </summary>
        /// <param name="level">The level to be set.</param>
        /// <remarks>
        /// This method assigns the provided <paramref name="level"/> value to the private field <c>_level</c>.
        /// It is typically used to update the current level of an object, which may represent a state, rank, or tier
        /// within a system. The method does not perform any validation on the input value, so it is the caller's
        /// responsibility to ensure that the level is appropriate for the context in which it is being set.
        /// </remarks>
        public void SetLevel(int level)
        {
            _level = level;
        }

        /// <summary>
        /// Increases the level of the character or entity by one.
        /// </summary>
        /// <remarks>
        /// This method increments the internal level counter (_level) of the character or entity.
        /// It is typically called when certain conditions are met, such as gaining enough experience points or completing specific objectives.
        /// The level increase may affect the character's abilities, stats, or access to new skills and equipment.
        /// This method does not return any value and directly modifies the state of the object.
        /// </remarks>
        public void LevelUp()
        {
            _level++;
        }

        /// <summary>
        /// Resets the game level to its initial state.
        /// </summary>
        /// <remarks>
        /// This method sets the private field <c>_level</c> to 1, effectively restarting the game level.
        /// It is typically called when a player chooses to restart the game or after completing a level.
        /// This ensures that the game starts from the beginning, allowing players to replay the level or start anew.
        /// </remarks>
        public void ResetLevel()
        {
            _level = 1;
        } 
    }
}
