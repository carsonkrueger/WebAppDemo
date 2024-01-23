using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore;

namespace WebAppDemo.Models
{
    public class UserModel
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
    }

    public class UsersContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }

        public UsersContext(DbContextOptions<UsersContext> options) : base(options)
        {

        }
    }
}
