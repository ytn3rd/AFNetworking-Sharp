using System;

namespace AFNetworking
{

    public enum AFNetworkReachabilityStatus
    {
        Unknown = -1,
        NotReachable = 0,
        ReachableViaWWAN = 1,
        ReachableViaWiFi = 2,
    }

    public enum AFSSLPinningMode
    {
        None,
        PublicKey,
        Certificate,
    }


    public enum AFHTTPClientParameterEncoding
    {
        AFFormURLParameterEncoding = 0,
        AFJSONParameterEncoding = 1,
        AFPropertyListParameterEncoding = 2
    }
}