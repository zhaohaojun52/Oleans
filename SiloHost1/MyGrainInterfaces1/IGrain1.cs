using System.Threading.Tasks;
using Orleans;

namespace MyGrainInterfaces1
{
    /// <summary>
    /// Grain interface IGrain1
    /// </summary>
    public interface IGrain1 : IGrain
    {
        Task<string> SayHello(int i);
    }
    
}
