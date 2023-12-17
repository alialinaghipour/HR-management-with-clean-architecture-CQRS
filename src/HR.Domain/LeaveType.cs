public class LeaveType : BaseEntity
{
    public string Name { get; set; } = default!;
    public int DefaultDay { get; set; }
}