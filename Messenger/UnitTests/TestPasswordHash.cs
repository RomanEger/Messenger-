using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace UnitTests;

public class TestPasswordHash
{
    [Fact]
    public void Test_PasswordHasher()
    {
        PasswordHasher<User> hasher = new PasswordHasher<User>();
        var user = new User();
        var hashedPassword = hasher.HashPassword(user, "string");
        var result = hasher.VerifyHashedPassword(user, hashedPassword, "string");
        Assert.True(result == PasswordVerificationResult.Success);
    }
}