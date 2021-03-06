using System;
using Newtonsoft.Json;

namespace Ditch.Steem.Models.Args
{
    /// <summary>
    /// get_discussions_by_author_before_date_args
    /// libraries\plugins\apis\tags_api\include\steem\plugins\tags_api\tags_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class GetDiscussionsByAuthorBeforeDateArgs
    {

        /// <summary>
        /// API name: author
        /// 
        /// </summary>
        /// <returns>API type: account_name_type</returns>
        [JsonProperty("author")]
        public string Author {get; set;}

        /// <summary>
        /// API name: start_permlink
        /// 
        /// </summary>
        /// <returns>API type: string</returns>
        [JsonProperty("start_permlink")]
        public string StartPermlink {get; set;}

        /// <summary>
        /// API name: before_date
        /// 
        /// </summary>
        /// <returns>API type: time_point_sec</returns>
        [JsonProperty("before_date")]
        public DateTime BeforeDate {get; set;}

        /// <summary>
        /// API name: limit
        /// = 100;
        /// </summary>
        /// <returns>API type: uint32_t</returns>
        [JsonProperty("limit")]
        public UInt32 Limit {get; set;}
    }
}
