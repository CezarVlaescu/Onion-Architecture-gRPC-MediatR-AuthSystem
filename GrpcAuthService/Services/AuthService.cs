using Auth;
using Grpc.Core;

namespace GrpcAuthService.Services
{
    public class AuthService : Auth.AuthService
    {
        private readonly ILogger<AuthService> _logger;

        public AuthService(ILogger<AuthService> logger)
        {
            _logger = logger;
        }

        public override Task<LoginResponse> LoginResponse(LoginRequest request, ServerCallContext context) 
        {
            try
            {
                _logger.LogInformation(request.Username, request.Password);

                return Task.FromResult(new LoginResponse
                {
                    Success = true,
                    Messsage = "Succesfull logged",
                    Token = " "
                });
            } catch
            {
                throw new Exception("Not success");
            }

        }
    }
}
