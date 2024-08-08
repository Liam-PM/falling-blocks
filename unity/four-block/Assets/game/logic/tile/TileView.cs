using UnityEngine;

namespace game.logic.tile
{
    public class TileView : MonoBehaviour
    {
        public SpriteRenderer TileSprite;
        
        private TileViewModel _tileVM;

        /// <summary>
        /// Initializes the component or system when called.
        /// </summary>
        /// <remarks>
        /// This method is typically used to set up necessary resources, configurations, or states required for the component to function properly.
        /// It may be called at the beginning of a process or when an instance of the class is created.
        /// The method does not take any parameters and does not return any value.
        /// It serves as a starting point for executing further logic within the class.
        /// </remarks>
        private void Start()
        {
        }

        /// <summary>
        /// Links a TileViewModel to the current object and updates its position.
        /// </summary>
        /// <param name="tileVM">The TileViewModel instance containing the position data.</param>
        /// <remarks>
        /// This method assigns the provided <paramref name="tileVM"/> to a private field and updates the position of the current object
        /// in the 3D space based on the X and Y properties of the <paramref name="tileVM"/>. The Z coordinate is set to 0,
        /// effectively placing the object on a 2D plane. This is useful for positioning tiles in a grid or game environment.
        /// </remarks>
        public void Link(TileViewModel tileVM)
        {
            _tileVM = tileVM;
            this.transform.position = new Vector3(tileVM.X, tileVM.Y, 0);
        }

        /// <summary>
        /// Updates the view based on the current state of the tile view model.
        /// </summary>
        /// <remarks>
        /// This method is responsible for refreshing or updating the user interface to reflect any changes
        /// made to the underlying tile view model (_tileVM). It should be called whenever there are updates
        /// to the data that the view is displaying, ensuring that the user sees the most current information.
        /// The implementation details of how the view is updated will depend on the specific UI framework
        /// being used and the structure of the tile view model.
        /// </remarks>
        void Update()
        {
            // Update the view based on the _tileVM here
        }
    }
}
