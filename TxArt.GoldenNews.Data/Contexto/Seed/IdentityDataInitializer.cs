using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TxArt.GoldenNews.Data.Entidades;

namespace TxArt.GoldenNews.Data.Contexto.Seed
{
    public static class IdentityDataInitializer
    {
        public static async Task SeedData(UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager)
        {
            await SeedRolesAsync(roleManager);
            await SeedUsersAsync(userManager);
        }

        private static async Task SeedRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Gestor de Conteúdo","Leitor" };

            foreach (string roleName in roles)
            {
                if (!await roleManager.RoleExistsAsync(roleName))
                {
                    IdentityResult roleResult = await roleManager.CreateAsync(new IdentityRole { Name = roleName });

                    if (!roleResult.Succeeded)
                    {
                        throw new Exception($"Error creating role: {roleResult.Errors.FirstOrDefault()?.Description}");
                    }
                }
            }
        }

        private static async Task SeedUsersAsync(UserManager<Usuario> userManager)
        {
            if (await userManager.FindByEmailAsync("admin@txart.ao") == null)
            {
                var user = new Usuario
                {
                    UserName = "admin",
                    Email = "admin@txart.ao",
                    EmailConfirmed = true
                };

                IdentityResult result = await userManager.CreateAsync(user, "123456");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "Admin");
                }
                else
                {
                    throw new Exception($"Error creating user: {result.Errors.FirstOrDefault()?.Description}");
                }
            }
        }
    }
}
