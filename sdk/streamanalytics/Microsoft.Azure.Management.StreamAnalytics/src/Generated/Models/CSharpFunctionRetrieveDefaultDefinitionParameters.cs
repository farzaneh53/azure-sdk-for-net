// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters needed to retrieve the default function definition for a
    /// CSharp function.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.StreamAnalytics/CLRUdf")]
    [Rest.Serialization.JsonTransformation]
    public partial class CSharpFunctionRetrieveDefaultDefinitionParameters : FunctionRetrieveDefaultDefinitionParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CSharpFunctionRetrieveDefaultDefinitionParameters class.
        /// </summary>
        public CSharpFunctionRetrieveDefaultDefinitionParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CSharpFunctionRetrieveDefaultDefinitionParameters class.
        /// </summary>
        /// <param name="script">The CSharp code containing a single function
        /// definition.</param>
        /// <param name="udfType">The function type. Possible values include:
        /// 'Scalar'</param>
        public CSharpFunctionRetrieveDefaultDefinitionParameters(string script = default(string), UdfType? udfType = default(UdfType?))
        {
            Script = script;
            UdfType = udfType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the CSharp code containing a single function
        /// definition.
        /// </summary>
        [JsonProperty(PropertyName = "bindingRetrievalProperties.script")]
        public string Script { get; set; }

        /// <summary>
        /// Gets or sets the function type. Possible values include: 'Scalar'
        /// </summary>
        [JsonProperty(PropertyName = "bindingRetrievalProperties.udfType")]
        public UdfType? UdfType { get; set; }

    }
}