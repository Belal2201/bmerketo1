using WebApplication1.Models.Identity;

namespace WebApplication1.ViewModel.Admin
{
    public class AdminEditUserAccountViewModel
    {
        public ICollection<UserAccount> Users { get; set; } = new List<UserAccount>();
    }
}
