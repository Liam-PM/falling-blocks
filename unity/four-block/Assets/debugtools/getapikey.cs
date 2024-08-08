namespace debugtools
{
    public class GetApiKeyCommand
    {
        private DebugReceiver _receiver;

        public VardumpCommand(DebugReceiver receiver)
        {
            _receiver = receiver;
        }

        /// <summary>
        /// Executes the command to retrieve the API command.
        /// </summary>
        /// <remarks>
        /// This method invokes an action on the receiver object, specifically calling the "getapicommand" action.
        /// It is intended to trigger the retrieval of a command from an API, allowing for further processing or handling of the command.
        /// The method does not return any value and is designed to perform its operation without any output.
        /// </remarks>
        public void Execute()
        {
            _receiver.Action("getapicommand");
        }
    }
}
