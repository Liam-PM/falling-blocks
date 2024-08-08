using UnityEngine;

namespace game.logic.playfield
{
    public class PlayFieldView : MonoBehaviour
    {
        public Transform TileAnchor;
        
        private PlayFieldViewModel _playFieldVM;

        /// <summary>
        /// Initializes the component when the application starts.
        /// </summary>
        /// <remarks>
        /// This method is called when the application is starting up. It is typically used to set up any necessary
        /// resources, initialize variables, or perform any setup tasks required before the application begins its main execution.
        /// Since this method is private, it is intended for use only within the class it is defined in.
        /// </remarks>
        private void Start()
        {
        }

        /// <summary>
        /// Links the provided PlayFieldViewModel to the current instance.
        /// </summary>
        /// <param name="playFieldVM">The PlayFieldViewModel instance to be linked.</param>
        /// <remarks>
        /// This method assigns the provided <paramref name="playFieldVM"/> to the private field
        /// <c>_playFieldVM</c>. This allows the current instance to maintain a reference to the
        /// specified PlayFieldViewModel, enabling further interactions or updates to the view model
        /// as needed. It is important to ensure that the <paramref name="playFieldVM"/> is not null
        /// before calling this method to avoid potential null reference issues.
        /// </remarks>
        public void Link(PlayFieldViewModel playFieldVM)
        {
            _playFieldVM = playFieldVM;
        }

        /// <summary>
        /// Updates the state of the object.
        /// </summary>
        /// <remarks>
        /// This method is intended to be called regularly to update the internal state of the object.
        /// It may include logic for refreshing data, processing input, or performing other necessary updates.
        /// The specific implementation details depend on the context in which this method is used.
        /// It does not return any value and does not take any parameters.
        /// </remarks>
        void Update()
        {
        
        }
    }
}
