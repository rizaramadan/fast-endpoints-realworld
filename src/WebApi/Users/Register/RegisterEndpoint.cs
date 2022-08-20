namespace src.WebApi.Users.Register;

public class RegisterEndpoint : Endpoint<RegisterRequest, RegisterResponse>
{
    public override void Configure()
    {
        Post("/api/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(RegisterRequest req, CancellationToken ct)
    {
        var response = new RegisterResponse
        { 
            User = new UserRegisterResponse
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