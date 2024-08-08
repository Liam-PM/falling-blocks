using System.Collections.Generic;
using game.service;

namespace game.logic.EventQueue
{
    public class EventQueue: IService
    {
        private Dictionary<EventId, Queue<IEvent>> _queues;
        
        public EventQueue()
        {
            _queues = new Dictionary<EventId, Queue<IEvent>>();
        }

        /// <summary>
        /// Adds an event to the corresponding queue based on its identifier.
        /// </summary>
        /// <param name="e">The event to be added to the queue.</param>
        /// <remarks>
        /// This method checks if a queue for the given event's identifier already exists in the internal dictionary.
        /// If it does not exist, a new queue is created for that identifier. The event is then enqueued into the appropriate queue.
        /// This allows for organizing events by their identifiers, enabling efficient processing of events associated with the same identifier.
        /// The method does not return any value and modifies the internal state of the queues.
        /// </remarks>
        public void Enqueue(IEvent e)
        {
            if(!_queues.ContainsKey(e.Id))
            {
                _queues[e.Id] = new Queue<IEvent>();
            }
            _queues[e.Id].Enqueue(e);
        }

        /// <summary>
        /// Checks if there is at least one event associated with the specified event identifier.
        /// </summary>
        /// <param name="id">The identifier of the event to check.</param>
        /// <returns>True if there is at least one event associated with the specified <paramref name="id"/>; otherwise, false.</returns>
        /// <remarks>
        /// This method verifies the presence of an event in the internal collection of events, represented by the dictionary <paramref name="_queues"/>.
        /// It first checks if the dictionary contains the specified event identifier. If it does, it then checks if the associated list of events has any elements.
        /// This is useful for determining whether any events are queued for processing for a given event identifier.
        /// </remarks>
        public bool HasEvent(EventId id) => _queues.ContainsKey(id) && _queues[id].Count > 0;

        /// <summary>
        /// Dequeues an event from the specified event queue identified by its ID.
        /// </summary>
        /// <param name="id">The identifier of the event queue from which to dequeue the event.</param>
        /// <returns>
        /// The dequeued event if it exists; otherwise, returns null.
        /// </returns>
        /// <remarks>
        /// This method checks if there is an event associated with the given <paramref name="id"/>.
        /// If an event exists, it dequeues the event from the corresponding queue and returns it.
        /// If no event is found for the specified ID, the method returns null, indicating that there are no events to dequeue.
        /// This method is useful for managing events in a queue-based system, allowing for efficient retrieval of events as needed.
        /// </remarks>
        public IEvent Dequeue(EventId id)
        {
            if (HasEvent(id))
            {
                return _queues[id].Dequeue();
            }
            return null;
        }
    }
}