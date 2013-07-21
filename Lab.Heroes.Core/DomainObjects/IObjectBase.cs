using System.Collections.Generic;
using Lab.Heroes.Core.DomainObjects.Serialization;

namespace Lab.Heroes.Core.DomainObjects
{
    public interface IObjectBase : IJsonSerializable
    {
        /// <summary>
        ///     Returns the value of given property casted to TResult.
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="property"></param>
        /// <returns></returns>
        TResult Get<TResult>(string property) where TResult : class;

        /// <summary>
        ///     Set a new value for given property.
        /// </summary>
        /// <param name="property"></param>
        /// <param name="value"></param>
        void Set(string property, object value);

        /// <summary>
        ///     Returns all values of current object that are stored with Set method.
        /// </summary>
        /// <returns></returns>
        IDictionary<string, object> GetValues();
    }
}