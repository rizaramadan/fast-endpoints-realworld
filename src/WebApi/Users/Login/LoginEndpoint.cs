namespace src.WebApi.Users.Login;

public class LoginEndpoint : Endpoint<LoginRequest, LoginResponse>
{
    public override void Configure()
    {
        Post("/api/users/login");
        AllowAnonymous();
    }

    public override async Task HandleAsync(LoginRequest req, CancellationToken ct)
    {
        var response = new LoginResponse
        { 
            User = new UserLoginResponse
            {
                Email = req.User.Email,
                Token = "jwt.token.here",
                Username = "jake",
                Bio = "some bio",
                Image = null
            } 
        };

        await SendOkAsync(response, ct);
    }
}