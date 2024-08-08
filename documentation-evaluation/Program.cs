using System;
using documentation_evaluation.person;

namespace documentation_evaluation
{
    internal class Program
    {

        /// <summary>
        /// The entry point of the application that demonstrates the use of the Person, PersonViewModel, and PersonView classes.
        /// </summary>
        /// <param name="args">An array of command-line arguments passed to the application. This parameter is not used in this method.</param>
        /// <remarks>
        /// This method serves as the main execution point for the application. It begins by printing "Hello World" to the console.
        /// Then, it creates an instance of the <see cref="Person"/> class with a name and age, which is subsequently wrapped in a <see cref="PersonViewModel"/>.
        /// A <see cref="PersonView"/> instance is created using the view model, allowing for interaction with the person data.
        /// The view is responsible for displaying the person's information, updating the name and age, and displaying the updated information again.
        /// Finally, it waits for a key press before closing, allowing the user to see the output before the application exits.
        /// </remarks>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            
            Person person = new Person { Name = "John Doe", Age = 30 };
            PersonViewModel viewModel = new PersonViewModel(person);
            PersonView view = new PersonView(viewModel);

            view.Display();
            view.UpdateName();
            view.UpdateAge();
            view.Display();

            Console.ReadKey();
        }
    }
}