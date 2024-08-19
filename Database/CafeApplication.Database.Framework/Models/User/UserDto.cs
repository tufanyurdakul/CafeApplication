using CafeApplication.Database.Framework.Models.Shared;
using System.ComponentModel.DataAnnotations;

namespace CafeApplication.Database.Framework.Models.User
{
    public class UserDto : DbRecordBase
    {
        [StringLength(10)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        public short Age { get; set; }
    }
}
