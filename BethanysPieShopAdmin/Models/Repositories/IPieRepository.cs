namespace BethanysPieShopAdmin.Models.Repositories
{
    public interface IPieRepository
    {
        public Task<IEnumerable<Pie>> GetAllPiesAsync();
        public Task<Pie?> GetPieByIdAsync(int pieId);
        Task<int> AddPieAsync(Pie pie);
        Task<int> UpdatePieAsync(Pie pie);
        Task<int> DeletePieAsync(int id);
        Task<int> GetAllPiesCountAsync();
        Task<IEnumerable<Pie>> GetPiesPagedAsync(int? pageNumber, int pageSize);
        Task<IEnumerable<Pie>> GetPiesSortedAndPagedAsync(string sortBy, int? pageNumber, int pageSize);
        Task<IEnumerable<Pie>> SearchPies(string searchQuery, int? categoryId);
    }
}
