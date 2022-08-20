namespace src.WebApi.Users.Login;

using Domain;

public class LoginRequest
{
    public UserLoginRequest User { get; init; }
}

public class UserLoginRequest
{
    public string Email { get; init; }
    public string Password { get; init; }
}
public class LoginResponse
{
    public UserLoginResponse User { get; init; }
}


public class UserLoginResponse : Profile
{
    public string Email { get; init; } = string.Empty;
    public string Token { get; init; } = string.Empty;
}