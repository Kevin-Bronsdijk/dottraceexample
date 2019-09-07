using System.Threading.Tasks;

namespace dottraceexample.Services
{
    public interface ISlowService
    {
        Task<int> GetNumberAsync();
    }
}