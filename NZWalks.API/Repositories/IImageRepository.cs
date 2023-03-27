using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
