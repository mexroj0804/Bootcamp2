using T_1.Entities;

namespace T_1.Helper
{
    public interface IJWTService
    {
        public string GenerateToken(User user);
    }
}