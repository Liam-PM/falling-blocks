namespace debugtools
{
    public class VardumpCommand
    {
        private DebugReceiver _receiver;

        public VardumpCommand(DebugReceiver receiver)
        {
            _receiver = receiver;
        }

        /// <summary>
        /// Executes an action by invoking the receiver's method with a specific command.
        /// </summary>
        /// <remarks>
        /// This method calls the <see cref="_receiver.Action"/> method with the command "vardump".
        /// The purpose of this action is to perform a specific operation defined by the receiver,
        /// which may involve dumping variable states or other relevant information for debugging or logging purposes.
        /// The exact behavior of the action depends on the implementation of the receiver.
        /// </remarks>
        public void Execute()
        {
            _receiver.Action("vardump");
        }
    }
}