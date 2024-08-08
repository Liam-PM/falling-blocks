using System.Collections.Generic;

namespace debugtools
{
    public class DebugReceiver
    {
        private List<string> supportedCommands = new List<string>() { "vardump" };

        /// <summary>
        /// Executes a specified action if it is supported.
        /// </summary>
        /// <param name="action">The action to be executed.</param>
        /// <exception cref="System.NotImplementedException">
        /// Thrown when the specified action is not supported.
        /// </exception>
        /// <remarks>
        /// This method checks if the provided <paramref name="action"/> is contained within the list of supported commands.
        /// If the action is not supported, it throws a <see cref="System.NotImplementedException"/> to indicate that the action cannot be performed.
        /// This is useful for ensuring that only valid actions are processed, preventing potential errors or undefined behavior.
        /// </remarks>
        public void Action(string action)
        {
            if(!(supportedCommands.Contains(action))){
                throw new System.NotImplementedException();
            }
        }
    }
}