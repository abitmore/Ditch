using Ditch.Steem.Models.Other;
using Newtonsoft.Json;

namespace Ditch.Steem.Models.Return
{
    /// <summary>
    /// get_blog_authors_return
    /// libraries\plugins\apis\follow_api\include\steem\plugins\follow_api\follow_api.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class GetBlogAuthorsReturn
    {

        /// <summary>
        /// API name: blog_authors
        /// 
        /// </summary>
        /// <returns>API type: reblog_count</returns>
        [JsonProperty("blog_authors")]
        public ReblogCount[] BlogAuthors {get; set;}
    }
}
