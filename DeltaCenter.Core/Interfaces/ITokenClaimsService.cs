using System.Threading.Tasks;

namespace DeltaCenter.Core.Interfaces
{
    public interface ITokenClaimsService
    {
        Task<string> GetTokenAsync(string userName);
    }
}
