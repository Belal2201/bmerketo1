using Microsoft.AspNetCore.Identity;
using WebApplication1.Models.Forms;

namespace WebApplication1.ViewModel.Account
{
    public class UserAccountEditViewModel : IdentityUser
    {
        public string UserId { get; set; } = null!;
        public UserProfileEditForm Form { get; set; } = new UserProfileEditForm();
    }
}
