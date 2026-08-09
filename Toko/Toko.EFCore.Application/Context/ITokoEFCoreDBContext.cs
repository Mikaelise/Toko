using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Toko.EFCore.Domain.Entities.Illustrator;

namespace Toko.EFCore.Application.Context
{
    public interface ITokoEFCoreDBContext
    {
        DbSet<Illustrator> Illustrators { get; set; }

        DatabaseFacade Database { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

        EntityEntry Remove(object entity);
    }
}
