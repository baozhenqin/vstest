// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.VisualStudio.TestPlatform.ObjectModel
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Exception thrown by Run Settings when an error with a settings provider
    /// is encountered.
    /// </summary>
#if NET451
    [Serializable]
#endif
    public class SettingsException : Exception
    {
        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public SettingsException() : base()
        {
        }

        /// <summary>
        /// Initializes with the message.
        /// </summary>
        /// <param name="message">Message for the exception.</param>
        public SettingsException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes with message and inner exception.
        /// </summary>
        /// <param name="message">Message for the exception.</param>
        /// <param name="innerException">The inner exception.</param>
        public SettingsException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

#if NET451
        /// <summary>
        /// Seralization constructor.
        /// </summary>
        protected SettingsException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

#endif
        #endregion
    }
}
