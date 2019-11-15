// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Fluent.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with ResponseWithError
    /// information.
    /// </summary>
    public partial class ResponseWithErrorException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public ResponseWithError Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the ResponseWithErrorException class.
        /// </summary>
        public ResponseWithErrorException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResponseWithErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public ResponseWithErrorException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the ResponseWithErrorException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public ResponseWithErrorException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}