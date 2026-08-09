using Microsoft.EntityFrameworkCore;
using Toko.EFCore.Application.Context;
using Toko.EFCore.Application.Models;
using Toko.EFCore.Domain.Entities.Illustrator;

namespace Toko.EFCore.Application.Services
{
    public class IllustratorService : IIllustratorService
    {
        private readonly ITokoEFCoreDBContext _dbContext;

        public IllustratorService(
            ITokoEFCoreDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> InsertAsync(InsertUpdateIllustrator insertIllustrator)
        {
            var illustrator = new Illustrator
            {
                Name = insertIllustrator.Name,
                Socials = insertIllustrator.Socials,
                NSFW = insertIllustrator.NSFW,
                DateAdded = insertIllustrator.DateAdded
            };

            await _dbContext.Illustrators.AddAsync(illustrator);
            await _dbContext.SaveChangesAsync();
            return illustrator.Id;
        }

        public async Task<int> UpdateAsync(int id, InsertUpdateIllustrator updateIllustrator)
        {
            var illustrator = await _dbContext.Illustrators.FirstOrDefaultAsync(x => x.Id == id);

            illustrator.Name = updateIllustrator.Name;
            illustrator.Socials = updateIllustrator.Socials;
            illustrator.NSFW = updateIllustrator.NSFW;

            await _dbContext.SaveChangesAsync();
            return illustrator.Id;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var illustrator = await _dbContext.Illustrators.FirstOrDefaultAsync(x => x.Id == id);
            if (illustrator == null)
            {
                throw new Exception($"Illustrator with ID {id} not found.");
            }
            _dbContext.Illustrators.Remove(illustrator);
            await _dbContext.SaveChangesAsync();
            return illustrator.Id;
        }
    }
}
