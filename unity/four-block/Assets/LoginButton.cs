using System.Collections;
using System.Collections.Generic;
using game.logic.EventQueue;
using network.user;
using UnityEngine;
using UnityEngine.EventSystems;

public class LoginButton : MonoBehaviour
{
    private EventQueue _eventQueue;

    /// <summary>
    /// Initializes the application or component.
    /// </summary>
    /// <remarks>
    /// This method is typically called when the application or component is starting up.
    /// It may contain code to set up initial states, load necessary resources, or perform
    /// any required configuration before the application begins its main execution.
    /// The method currently does not implement any functionality, but it serves as a
    /// placeholder for future initialization logic.
    /// </remarks>
    void Start()
    {
        
    }

    /// <summary>
    /// Updates the state of the object.
    /// </summary>
    /// <remarks>
    /// This method is intended to be called regularly to refresh or update the internal state of the object.
    /// It may include operations such as refreshing data, recalculating values, or any other necessary updates
    /// that need to occur during the lifecycle of the object. The specific implementation details would depend
    /// on the context in which this method is used. As it currently stands, the method does not perform any actions
    /// since its body is empty.
    /// </remarks>
    void Update()
    {
        
    }

    /// <summary>
    /// Links the specified event queue to the current instance.
    /// </summary>
    /// <param name="eventQueue">The event queue to be linked.</param>
    /// <remarks>
    /// This method assigns the provided <paramref name="eventQueue"/> to the private field <c>_eventQueue</c> of the current instance.
    /// It allows the current object to interact with the specified event queue, enabling event handling and processing.
    /// This method does not return any value and is primarily used for establishing a connection between the current instance and the event queue.
    /// </remarks>
    public void Link(EventQueue eventQueue)
    {
        _eventQueue = eventQueue;
    }

    /// <summary>
    /// Handles the click event by retrieving the user's name and enqueuing a user login event.
    /// </summary>
    /// <remarks>
    /// This method is typically called in response to a user action, such as clicking a button.
    /// It creates an instance of the <see cref="UserService"/> class to access user-related functionality.
    /// The user's name is fetched using the <see cref="UserService.GetUserName"/> method.
    /// After obtaining the username, a new instance of <see cref="UserLoginEvent"/> is created, which encapsulates the event data.
    /// This event is then added to the event queue for further processing, allowing the application to respond to the user login action appropriately.
    /// </remarks>
    public void OnClick()
    {
        UserService userService = new UserService();
        var userName = userService.GetUserName();
        _eventQueue.Enqueue(new UserLoginEvent(this, userName));
    }
}
