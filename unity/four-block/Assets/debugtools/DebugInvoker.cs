namespace debugtools
{
    public class DebugInvoker
    {
        private ICommand _command;

        /// <summary>
        /// Sets the command to be executed.
        /// </summary>
        /// <param name="command">The command to be set.</param>
        /// <remarks>
        /// This method assigns the provided <paramref name="command"/> to the private field <c>_command</c>.
        /// It allows for the dynamic setting of commands that can be executed later.
        /// This is useful in scenarios where the command to be executed may change at runtime,
        /// enabling more flexible and maintainable code architecture.
        /// </remarks>
        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        /// <summary>
        /// Executes the command associated with this instance.
        /// </summary>
        /// <remarks>
        /// This method calls the <see cref="_command.Execute"/> method to perform the action defined by the command.
        /// It is typically used to trigger the execution of a command that encapsulates a specific operation or behavior.
        /// The command may involve various tasks, such as updating a user interface, processing data, or interacting with external systems.
        /// This method does not return any value and is intended to be called when the command needs to be executed.
        /// </remarks>
        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}