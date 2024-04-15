namespace BethanysPieShopAdmin.Models.Repositories
{
    public interface IPieRepository
    {
        public Task<IEnumerable<Pie>> GetAllPiesAsync();
        public Task<Pie?> GetPieByIdAsync(int pieId);
        Task<int> AddPieAsync(Pie pie);
    }
}
