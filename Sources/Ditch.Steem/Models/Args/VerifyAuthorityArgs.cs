using Ditch.Steem.Models.Other;
using Newtonsoft.Json;

namespace Ditch.Steem.Models.Args
{
    /// <summary>
    /// verify_authority_args
    /// libraries\plugins\apis\database_api\include\steem\plugins\database_api\database_api_args.hpp
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public partial class VerifyAuthorityArgs
    {

        /// <summary>
        /// API name: trx
        /// 
        /// </summary>
        /// <returns>API type: signed_transaction</returns>
        [JsonProperty("trx")]
        public SignedTransaction Trx {get; set;}
    }
}
