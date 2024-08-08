using System;

namespace documentation_evaluation.person
{
    public class PersonView
    {
        private PersonViewModel _viewModel;

        public PersonView(PersonViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        /// <summary>
        /// Displays the name and age of the view model.
        /// </summary>
        /// <remarks>
        /// This method outputs the properties <paramref name="_viewModel.Name"/> and <paramref name="_viewModel.Age"/>
        /// to the console in a formatted string. It is primarily used for debugging or logging purposes
        /// to provide a quick overview of the current state of the view model.
        /// The method does not return any value and does not modify the state of the view model.
        /// </remarks>
        public void Display()
        {
            Console.WriteLine($"Name: {_viewModel.Name}, Age: {_viewModel.Age}");
        }

        /// <summary>
        /// Updates the name property of the view model with user input.
        /// </summary>
        /// <remarks>
        /// This method prompts the user to enter a new name via the console.
        /// It reads the input from the console and assigns it to the Name property of the
        /// associated view model. This allows for dynamic updates to the name based on user interaction.
        /// Note that this method does not perform any validation on the input,
        /// so it is assumed that the user will provide a valid name.
        /// </remarks>
        public void UpdateName()
        {
            Console.Write("Enter a new name: ");
            _viewModel.Name = Console.ReadLine();
        }

        /// <summary>
        /// Updates the age property of the view model based on user input.
        /// </summary>
        /// <remarks>
        /// This method prompts the user to enter a new age and reads the input from the console.
        /// It then parses the input string into an integer and assigns it to the Age property of the
        /// associated view model. This method does not return any value and directly modifies the
        /// state of the view model. It is important to ensure that the input is a valid integer,
        /// as invalid input may result in a runtime exception.
        /// </remarks>
        public void UpdateAge()
        {
            Console.Write("Enter a new age: ");
            _viewModel.Age = int.Parse(Console.ReadLine());
        }
    }
}