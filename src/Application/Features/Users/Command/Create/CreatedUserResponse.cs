namespace Application.Features.Users.Command.Create
{
    public class CreatedUserResponse
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}