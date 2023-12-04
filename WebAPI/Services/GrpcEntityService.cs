using MediatR;

namespace WebAPI.Services
{
    public class GrpcEntityService
    {
        private readonly IMediator _mediator;

        public GrpcEntityService(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
