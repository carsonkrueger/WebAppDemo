using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;

namespace WebAppDemo.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class UsersContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
    }
}
