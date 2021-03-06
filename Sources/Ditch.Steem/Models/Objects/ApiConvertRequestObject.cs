using System;
using Ditch.Steem.Models.Other;
using Newtonsoft.Json;

namespace Ditch.Steem.Models.Objects
{
    /// <summary>
    /// api_convert_request_object
    /// libraries\plugins\apis\condenser_api\include\steem\plugins\condenser_api\condenser_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class ApiConvertRequestObject
    {

        /// <summary>
        /// API name: id
        /// 
        /// </summary>
        /// <returns>API type: convert_request_id_type</returns>
        [JsonProperty("id")]
        public object Id {get; set;}

        /// <summary>
        /// API name: owner
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("owner")]
        public string Owner {get; set;}

        /// <summary>
        /// API name: requestid
        /// = 0;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("requestid")]
        public UInt32 Requestid {get; set;}

        /// <summary>
        /// API name: amount
        /// 
        /// </summary>
        /// <returns>API type: legacy_asset</returns>
        [JsonProperty("amount")]
        public LegacyAsset Amount {get; set;}

        /// <summary>
        /// API name: conversion_date
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("conversion_date")]
        public DateTime ConversionDate {get; set;}
    }
}
