public class LeaveAllocationDto : BaseDto
{
    public int NumberOfDays { get; set; }
    public GetLeaveTypesDto LeaveType { get; set; } = default!;
    public int LeaveTypeId { get; set; }
    public int Period { get; set; }
}