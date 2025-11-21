// ============================================
// Infrastructure/Context/Configurations/IdentitySeeder.cs
// ============================================

using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Context.Configurations
{
    public static class IdentitySeeder
    {
        public static async Task SeedAsync(
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            await SeedRolesAsync(roleManager);
            await SeedUsersAsync(userManager);
        }

        // ==================== الأدوار ====================
        private static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Supervisor", "Researcher", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }
        }

        // ==================== المستخدمين ====================
        private static async Task SeedUsersAsync(UserManager<ApplicationUser> userManager)
        {
            var users = new List<(ApplicationUser User, string Password, string Role)>
            {
                // Admin
                (new ApplicationUser
                {
                    UserName = "admin@heritage.com",
                    Email = "admin@heritage.com",
                    FullNameAr = "مدير النظام",
                    FullNameEn = "System Administrator",
                    Organization = "وزارة السياحة والآثار",
                    JobTitle = "مدير تقني",
                    EmailConfirmed = true,
                    IsActive = true
                }, "Admin@123", "Admin"),

                // Supervisor
                (new ApplicationUser
                {
                    UserName = "supervisor@heritage.com",
                    Email = "supervisor@heritage.com",
                    FullNameAr = "أحمد محمود حسن",
                    FullNameEn = "Ahmed Mahmoud Hassan",
                    Organization = "المجلس الأعلى للآثار",
                    JobTitle = "مشرف ترميم",
                    EmailConfirmed = true,
                    IsActive = true
                }, "Super@123", "Supervisor"),

                // Researcher
                (new ApplicationUser
                {
                    UserName = "researcher@heritage.com",
                    Email = "researcher@heritage.com",
                    FullNameAr = "د. سارة أحمد محمد",
                    FullNameEn = "Dr. Sara Ahmed Mohamed",
                    Organization = "جامعة القاهرة - كلية الآثار",
                    JobTitle = "أستاذ مساعد ترميم",
                    EmailConfirmed = true,
                    IsActive = true
                }, "Research@123", "Researcher"),

                // User 1
                (new ApplicationUser
                {
                    UserName = "user1@heritage.com",
                    Email = "user1@heritage.com",
                    FullNameAr = "محمد علي إبراهيم",
                    FullNameEn = "Mohamed Ali Ibrahim",
                    Organization = "جامعة عين شمس",
                    JobTitle = "طالب ماجستير ترميم",
                    EmailConfirmed = true,
                    IsActive = true
                }, "User@123", "User"),

                // User 2
                (new ApplicationUser
                {
                    UserName = "user2@heritage.com",
                    Email = "user2@heritage.com",
                    FullNameAr = "فاطمة حسين أحمد",
                    FullNameEn = "Fatma Hussein Ahmed",
                    Organization = "جامعة الإسكندرية",
                    JobTitle = "باحثة دكتوراه",
                    EmailConfirmed = true,
                    IsActive = true
                }, "User@123", "User")
            };

            foreach (var (user, password, role) in users)
            {
                if (await userManager.FindByEmailAsync(user.Email!) == null)
                {
                    var result = await userManager.CreateAsync(user, password);
                    if (result.Succeeded)
                    {
                        await userManager.AddToRoleAsync(user, role);
                    }
                }
            }
        }
    }
}

// ============================================
// كيفية الاستدعاء في Program.cs
// ============================================
/*
// Add this after building the app:

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();
        var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
        
        await IdentitySeeder.SeedAsync(userManager, roleManager);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}
*/