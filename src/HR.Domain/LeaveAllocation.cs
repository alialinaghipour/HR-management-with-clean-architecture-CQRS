public class LeaveAllocation : BaseEntity
{
    public int NumberOfDays { get; set; }
    public LeaveType LeaveType { get; set; } = default!;
    public int LeaveTypeId { get; set; }
    public int Priod { get; set; }
}
