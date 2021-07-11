using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TestClient.Models
{
    public class TestClientContext : IdentityDbContext<ApplicationUser>
    {
    public TestClientContext(DbContextOptions options) : base(options) { }
    }
}