namespace Presentations.Models
{
    public class Users
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? PasswordHash { get; set; }
        public string? FullName { get; set; }
        public int DepartmentId { get; set; }
        public int RoleId { get; set; }
    }
}
