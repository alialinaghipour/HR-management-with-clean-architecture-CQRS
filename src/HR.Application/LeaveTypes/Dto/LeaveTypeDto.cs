public class GetLeaveTypesDto : BaseDto
{
    public string Name { get; set; } = default!;
    public int DefaultDay { get; set; }
}