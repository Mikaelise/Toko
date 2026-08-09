
namespace Toko.EFCore.Application.Models
{
    public class InsertUpdateIllustrator
    {
        public string Name { get; set; } = string.Empty;

        public string[] Socials { get; set; } = Array.Empty<string>();

        public bool NSFW { get; set; }

        public DateOnly DateAdded { get; set; }
    }
}
