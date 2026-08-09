using Toko.EFCore.Application.Models;

namespace Toko.EFCore.Application.Services
{
    public interface IIllustratorService
    {
        Task<int> InsertAsync(InsertUpdateIllustrator insertIllustrator);

        Task<int> UpdateAsync(int id, InsertUpdateIllustrator updateIllustrator);

        Task<int> DeleteAsync(int id);
    }
}
