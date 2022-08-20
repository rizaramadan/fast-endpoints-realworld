namespace src.WebApi.Users.Register;

using Domain;

public class RegisterRequest
{
    public UserRegisterRequest User { get; init; }
}

public class UserRegisterRequest
{
    public string Username { get; init; }
    public string Email { get; init; }
    public string Password { get; init; }
}
public class RegisterResponse
{
    public UserRegisterResponse User { get; init; }
}

public class UserRegisterResponse : Profile
{
    public string Email { get; init; } = string.Empty;
    public string Token { get; init; } = string.Empty;
}