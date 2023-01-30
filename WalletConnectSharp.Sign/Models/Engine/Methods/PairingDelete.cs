using Newtonsoft.Json;
using WalletConnectSharp.Common.Utils;
using WalletConnectSharp.Network.Models;
using WalletConnectSharp.Sign.Interfaces;

namespace WalletConnectSharp.Sign.Models.Engine.Methods
{
    /// <summary>
    /// A class that represents the request wc_pairingDelete. This is used to delete a pairing
    /// </summary>
    [RpcMethod("wc_pairingDelete")]
    [RpcRequestOptions(Clock.ONE_DAY, false, 1000)]
    [RpcResponseOptions(Clock.ONE_DAY, false, 1001)]
    public class PairingDelete : ErrorResponse, IWcMethod
    {
    }
}
