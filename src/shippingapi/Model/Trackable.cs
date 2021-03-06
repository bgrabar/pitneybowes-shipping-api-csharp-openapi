/* 
 * Shipping API
 *
 * Shipping API Sample.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@pb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = shippingapi.Client.OpenAPIDateConverter;

namespace shippingapi.Model
{
    /// <summary>
    /// * TRACKABLE - Item is trackable by default. * NON_TRACKABLE - Item is not trackable. * REQUIRES_TRACKABLE_SPECIAL_SERVICE - Item is trackable if special service is requested. 
    /// </summary>
    /// <value>* TRACKABLE - Item is trackable by default. * NON_TRACKABLE - Item is not trackable. * REQUIRES_TRACKABLE_SPECIAL_SERVICE - Item is trackable if special service is requested. </value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Trackable
    {
        /// <summary>
        /// Enum TRACKABLE for value: TRACKABLE
        /// </summary>
        [EnumMember(Value = "TRACKABLE")]
        TRACKABLE = 1,

        /// <summary>
        /// Enum NONTRACKABLE for value: NON_TRACKABLE
        /// </summary>
        [EnumMember(Value = "NON_TRACKABLE")]
        NONTRACKABLE = 2,

        /// <summary>
        /// Enum REQUIRESTRACKABLESPECIALSERVICE for value: REQUIRES_TRACKABLE_SPECIAL_SERVICE
        /// </summary>
        [EnumMember(Value = "REQUIRES_TRACKABLE_SPECIAL_SERVICE")]
        REQUIRESTRACKABLESPECIALSERVICE = 3

    }

}
