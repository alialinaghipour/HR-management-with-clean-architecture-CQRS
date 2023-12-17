public abstract class BaseEntity
{
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; } = default!;
        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; } = default!;
}