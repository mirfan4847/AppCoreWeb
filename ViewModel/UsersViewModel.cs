namespace AppCoreWeb.ViewModel
{
    public class UsersViewModel
    {
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Dob { get; set; }

        public string Gender { get; set; }

        public string UserType { get; set; }

        public bool? Active { get; set; }

        public string CreatedAt { get; set; }

        public string ModifyAt { get; set; }
    }
}
