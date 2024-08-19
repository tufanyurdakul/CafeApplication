using System.ComponentModel.DataAnnotations;

namespace CafeApplication.Database.Framework.Models.Shared
{
    public class DbRecordBase
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsActive { get; set; } = true;
    }
}
