using WebApplication1.Models.Entities;

namespace WebApplication1.ViewModel.Home
{
    public class HomeViewModel
    {
        public ICollection<ProductEntity> Product { get; set; } = new List<ProductEntity>();
    }
}
