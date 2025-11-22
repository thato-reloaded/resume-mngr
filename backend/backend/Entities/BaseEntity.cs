using System.ComponentModel.DataAnnotations;

namespace backend.Entities
{
    public class BaseEntity
    {
        [Key]
        public long Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public bool IsActive { get; set; } = true;

        // Helper methods for South Africa time
        public DateTime CreatedAtSAST => CreatedAt.AddHours(2);
        public DateTime UpdatedAtSAST => UpdatedAt.AddHours(2);
    }
}
