using System;

namespace MvcPaging.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
