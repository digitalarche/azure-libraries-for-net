// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define the configuration of traffic analytics.
    /// </summary>
    public partial class TrafficAnalyticsProperties
    {
        /// <summary>
        /// Initializes a new instance of the TrafficAnalyticsProperties class.
        /// </summary>
        public TrafficAnalyticsProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TrafficAnalyticsProperties class.
        /// </summary>
        public TrafficAnalyticsProperties(TrafficAnalyticsConfigurationProperties networkWatcherFlowAnalyticsConfiguration)
        {
            NetworkWatcherFlowAnalyticsConfiguration = networkWatcherFlowAnalyticsConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "networkWatcherFlowAnalyticsConfiguration")]
        public TrafficAnalyticsConfigurationProperties NetworkWatcherFlowAnalyticsConfiguration { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (NetworkWatcherFlowAnalyticsConfiguration == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NetworkWatcherFlowAnalyticsConfiguration");
            }
            if (NetworkWatcherFlowAnalyticsConfiguration != null)
            {
                NetworkWatcherFlowAnalyticsConfiguration.Validate();
            }
        }
    }
}