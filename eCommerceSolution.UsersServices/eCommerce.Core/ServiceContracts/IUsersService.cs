using eCommerce.Core.DTOs;

namespace eCommerce.Core.ServiceContracts;

public interface IUsersService
{
    Task<AuthenticationResponse> Login(LoginRequest loginRequest);
    Task<AuthenticationResponse> Register(RegisterRequest registerRequest);
    Task<UserDTO> GetUserByUserID(Guid userID);
}
