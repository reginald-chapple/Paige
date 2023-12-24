using Paige.Web.Infrastructure.Validation;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Paige.Web.Domain
{
    public class ApplicationUser : IdentityUser<string>
    {
        public string FullName { get; set; } = string.Empty;

        public string Image { get; set; } = string.Empty;

        [NotMapped]
        [PhotoExtension]
        public IFormFile? ImageUpload { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.Parse("1/1/1901");

        public bool IsHostAccount { get; set; } = false;

        public virtual ICollection<ApplicationUserRole> UserRoles { get; set; } = new List<ApplicationUserRole>();
        public virtual ICollection<UserNotification> Notifications { get; set; } = new List<UserNotification>();
        public virtual ICollection<ChatUser> Chats { get; set; } = new List<ChatUser>();
    }
}