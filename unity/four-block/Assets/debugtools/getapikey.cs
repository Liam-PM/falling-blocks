namespace debugtools
{
    public class GetApiKeyCommand
    {
        private DebugReceiver _receiver;

        public VardumpCommand(DebugReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.Action("getapicommand");
        }
    }
}
