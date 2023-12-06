namespace my_school.MVVM.Model.User
{
    class ShowUserDTO
    {
        public int Id { get; set; }
        public required string UserName { get; set; }

        public required string Password { get; set; }
        public string? Email { get; set; }
        public required string Role { get; set; }

        public ShowUserDTO(User user)
        {
            Id = user.Id;
            UserName = user.UserName;
            Email = user.Email;
            Role = user.Role;
        }
    }
}
