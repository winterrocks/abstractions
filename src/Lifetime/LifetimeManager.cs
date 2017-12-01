﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace Unity.Lifetime
{
    /// <summary>
    /// Base class for Lifetime managers - classes that control how
    /// and when instances are created by the Unity container.
    /// </summary>
    public abstract class LifetimeManager : ILifetimePolicy
    {
        public virtual bool InUse { get; set; }


        #region ILifetimePolicy Members

        /// <summary>
        /// Retrieve a value from the backing store associated with this Lifetime policy.
        /// </summary>
        /// <param name="container">Child container this lifetime belongs to</param>
        /// <returns>the object desired, or null if no such object is currently stored.</returns>
        public abstract object GetValue(ILifetimeContainer container = null);

        /// <summary>
        /// Stores the given value into backing store for retrieval later.
        /// </summary>
        /// <param name="newValue">The object being stored.</param>
        /// <param name="container">The container this lifetime belongs to</param>
        public abstract void SetValue(object newValue, ILifetimeContainer container = null);

        /// <summary>
        /// Remove the given object from backing store.
        /// <param name="container">The container this lifetime belongs to</param>
        /// </summary>
        public abstract void RemoveValue(ILifetimeContainer container = null);

        #endregion
    }
}
