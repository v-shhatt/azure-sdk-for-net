// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ExtendedStatusInfo
    {
        /// <summary>
        /// Initializes a new instance of the ExtendedStatusInfo class.
        /// </summary>
        public ExtendedStatusInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExtendedStatusInfo class.
        /// </summary>
        /// <param name="statusCode">Possible values include: 'None',
        /// 'Pending', 'Active', 'PurchaseError', 'PaymentInstrumentError',
        /// 'Split', 'Merged', 'Expired', 'Succeeded'</param>
        /// <param name="message">The message giving detailed information about
        /// the status code.</param>
        public ExtendedStatusInfo(string statusCode = default(string), string message = default(string))
        {
            StatusCode = statusCode;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'None', 'Pending', 'Active',
        /// 'PurchaseError', 'PaymentInstrumentError', 'Split', 'Merged',
        /// 'Expired', 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the message giving detailed information about the
        /// status code.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

    }
}