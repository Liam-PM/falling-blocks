using System;
using System.Collections.Generic;

namespace game.service
{
    public class ServiceLocator
    {
        private IDictionary<object, IService> services;

        public ServiceLocator()
        {
            services = new Dictionary<object, IService>();
        }

        /// <summary>
        /// Retrieves a service of the specified type from the service collection.
        /// </summary>
        /// <typeparam name="T">The type of the service to be retrieved.</typeparam>
        /// <returns>An instance of the requested service of type <typeparamref name="T"/>.</returns>
        /// <remarks>
        /// This method attempts to retrieve a service from a collection of registered services using its type as the key.
        /// If the service is found, it is cast to the specified type and returned.
        /// If the service is not registered, a KeyNotFoundException is caught, and an ApplicationException is thrown with a descriptive message.
        /// This allows for better error handling and understanding of the issue when a requested service is not available.
        /// </remarks>
        /// <exception cref="ApplicationException">Thrown when the requested service is not registered in the service collection.</exception>
        public T GetService<T>()
        {
            try
            {
                return (T)services[typeof(T)];
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }

        /// <summary>
        /// Registers a service of type <typeparamref name="T"/> in the service collection.
        /// </summary>
        /// <typeparam name="T">The type of the service to be registered, which must implement the <see cref="IService"/> interface.</typeparam>
        /// <param name="service">The instance of the service to be registered.</param>
        /// <remarks>
        /// This method allows for the registration of services in a service collection, enabling dependency injection
        /// within an application. The generic type parameter <typeparamref name="T"/> ensures that only types that
        /// implement the <see cref="IService"/> interface can be registered. The registered service can later be
        /// resolved and used by other components in the application. This method modifies the internal collection
        /// of services by adding or updating the entry for the specified service type.
        /// </remarks>
        public void RegisterService<T>(T service) where T: IService
        {
            services[typeof(T)] = service;
        }
    }
}