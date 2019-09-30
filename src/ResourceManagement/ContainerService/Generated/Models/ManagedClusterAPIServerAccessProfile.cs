// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Access profile for managed cluster API server.
    /// </summary>
    public partial class ManagedClusterAPIServerAccessProfile
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAPIServerAccessProfile class.
        /// </summary>
        public ManagedClusterAPIServerAccessProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ManagedClusterAPIServerAccessProfile class.
        /// </summary>
        /// <param name="authorizedIPRanges">Authorized IP Ranges to kubernetes
        /// API server.</param>
        /// <param name="enablePrivateCluster">Whether to create the cluster as
        /// a private cluster or not.</param>
        public ManagedClusterAPIServerAccessProfile(IList<string> authorizedIPRanges = default(IList<string>), bool? enablePrivateCluster = default(bool?))
        {
            AuthorizedIPRanges = authorizedIPRanges;
            EnablePrivateCluster = enablePrivateCluster;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets authorized IP Ranges to kubernetes API server.
        /// </summary>
        [JsonProperty(PropertyName = "authorizedIPRanges")]
        public IList<string> AuthorizedIPRanges { get; set; }

        /// <summary>
        /// Gets or sets whether to create the cluster as a private cluster or
        /// not.
        /// </summary>
        [JsonProperty(PropertyName = "enablePrivateCluster")]
        public bool? EnablePrivateCluster { get; set; }

    }
}
