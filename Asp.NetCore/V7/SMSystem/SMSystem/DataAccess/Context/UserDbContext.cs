using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DataAccess.Context;

public class UserDbContext : DbContext
{
    public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
    {

    }

    public DbSet<UserDetails> users_dtls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Data Source=UCHIHA_MADARA\\SQLEXPRESS;Initial Catalog=UserDetail;User=UCHIHA_MADARA\\aa882;Password=;Trusted_Connection=True;");
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserDetails>().HasData(
            new UserDetails
            {
                id = 1,
                user_create_id = "USR001",
                first_nm = "Abc",
                middle_nm = "Lmn",
                last_nm = "Xyz",
                address1 = "aksdlasd",
                address2 = "asdkasdoasdij",
                address3 = "asdasdsaddfkja",
                email1 = "asndd@gmail.com",
                phone1 = "9898989898",
                crtd_date = DateTime.Now,
                lst_crtd_date = DateTime.Now,
                crtd_ip_add = "1.1.1.1",
                lst_crtd_ip_add = "1.1.1.1",
                act_ind = 1,
                crtd_user = 1,
                lst_crtd_user = 1
            });
    }
}
