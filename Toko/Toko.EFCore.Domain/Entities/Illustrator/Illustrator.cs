namespace Toko.EFCore.Domain.Entities.Illustrator
{
    public class Illustrator
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string[] Socials { get; set; } = Array.Empty<string>();

        public bool NSFW { get; set; }

        public DateOnly DateAdded { get; set; }
    }
}
