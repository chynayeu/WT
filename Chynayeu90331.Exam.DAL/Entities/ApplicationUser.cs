using Microsoft.AspNetCore.Identity;

namespace Chynayeu90331.Exam.DAL.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Education { get; set; }
    }
}
