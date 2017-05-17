// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This class contains the error details per object.
    /// </summary>
    public partial class ProviderError
    {
        /// <summary>
        /// Initializes a new instance of the ProviderError class.
        /// </summary>
        public ProviderError()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProviderError class.
        /// </summary>
        /// <param name="errorCode">The Error code.</param>
        /// <param name="errorMessage">The Error message.</param>
        /// <param name="errorId">The Provider error Id.</param>
        /// <param name="possibleCauses">The possible causes for the
        /// error.</param>
        /// <param name="recommendedAction">The recommended action to resolve
        /// the error.</param>
        public ProviderError(int? errorCode = default(int?), string errorMessage = default(string), string errorId = default(string), string possibleCauses = default(string), string recommendedAction = default(string))
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ErrorId = errorId;
            PossibleCauses = possibleCauses;
            RecommendedAction = recommendedAction;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Error code.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the Error message.
        /// </summary>
        [JsonProperty(PropertyName = "errorMessage")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Gets or sets the Provider error Id.
        /// </summary>
        [JsonProperty(PropertyName = "errorId")]
        public string ErrorId { get; set; }

        /// <summary>
        /// Gets or sets the possible causes for the error.
        /// </summary>
        [JsonProperty(PropertyName = "possibleCauses")]
        public string PossibleCauses { get; set; }

        /// <summary>
        /// Gets or sets the recommended action to resolve the error.
        /// </summary>
        [JsonProperty(PropertyName = "recommendedAction")]
        public string RecommendedAction { get; set; }

    }
}