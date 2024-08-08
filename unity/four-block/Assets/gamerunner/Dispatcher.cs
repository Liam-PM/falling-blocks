using System;
using System.Collections.Generic;
using UnityEngine;

namespace gamerunner
{
    public class Dispatcher : MonoBehaviour
    {
        private List<IUpdatable> _updatables;

        /// <summary>
        /// Initializes the list of updatable components when the object is awakened.
        /// </summary>
        /// <remarks>
        /// This method is called when the script instance is being loaded. It sets up the
        /// _updatables list, which is intended to hold references to components that implement
        /// the IUpdatable interface. This allows for efficient management and updating of
        /// these components during the game loop. The Awake method is typically used for
        /// initialization tasks that need to be performed before the game starts or before
        /// any other methods are called on the object.
        /// </remarks>
        private void Awake()
        {
            _updatables = new List<IUpdatable>();
        }

        /// <summary>
        /// Updates all updatable objects in the collection.
        /// </summary>
        /// <remarks>
        /// This method iterates through a collection of updatable objects stored in the private field <paramref name="_updatables"/>.
        /// For each object in the collection, it calls the <c>Update</c> method, allowing each object to perform its own update logic.
        /// This is typically used in game loops or similar scenarios where multiple objects need to be updated each frame.
        /// It ensures that all relevant state changes and logic updates are processed in a single call.
        /// </remarks>
        private void Update()
        {
            foreach (var updatable in _updatables)
            {
                updatable.Update();
            }
        }

        /// <summary>
        /// Adds an updatable object to the collection of updatables.
        /// </summary>
        /// <param name="updatable">The updatable object to be added to the collection.</param>
        /// <remarks>
        /// This method is responsible for adding an instance of an object that implements the
        /// <see cref="IUpdatable"/> interface to the internal collection of updatables.
        /// The collection can then be used to manage and update all added objects during
        /// the update cycle of the application. This allows for a centralized way to handle
        /// updates for multiple objects that require periodic updates, such as game entities
        /// or UI components.
        /// </remarks>
        public void addUpdatable(IUpdatable updatable)
        {
            _updatables.Add(updatable);
        }
    }
}