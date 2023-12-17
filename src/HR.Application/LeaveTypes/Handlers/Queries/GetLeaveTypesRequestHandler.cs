using MediatR;

public class GetLeaveTypesRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<GetLeaveTypesDto>>
{
    public Task<List<GetLeaveTypesDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}