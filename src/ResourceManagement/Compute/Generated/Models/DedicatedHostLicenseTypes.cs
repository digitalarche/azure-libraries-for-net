// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DedicatedHostLicenseTypes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DedicatedHostLicenseTypes
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Windows_Server_Hybrid")]
        WindowsServerHybrid,
        [EnumMember(Value = "Windows_Server_Perpetual")]
        WindowsServerPerpetual
    }
    internal static class DedicatedHostLicenseTypesEnumExtension
    {
        internal static string ToSerializedValue(this DedicatedHostLicenseTypes? value)
        {
            return value == null ? null : ((DedicatedHostLicenseTypes)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DedicatedHostLicenseTypes value)
        {
            switch( value )
            {
                case DedicatedHostLicenseTypes.None:
                    return "None";
                case DedicatedHostLicenseTypes.WindowsServerHybrid:
                    return "Windows_Server_Hybrid";
                case DedicatedHostLicenseTypes.WindowsServerPerpetual:
                    return "Windows_Server_Perpetual";
            }
            return null;
        }

        internal static DedicatedHostLicenseTypes? ParseDedicatedHostLicenseTypes(this string value)
        {
            switch( value )
            {
                case "None":
                    return DedicatedHostLicenseTypes.None;
                case "Windows_Server_Hybrid":
                    return DedicatedHostLicenseTypes.WindowsServerHybrid;
                case "Windows_Server_Perpetual":
                    return DedicatedHostLicenseTypes.WindowsServerPerpetual;
            }
            return null;
        }
    }
}
