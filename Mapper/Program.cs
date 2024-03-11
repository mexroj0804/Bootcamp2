using Mapper;
using System.Text.Json;

var user = new User()
{
    Id = 1,
    Name = "Test",
    Age = 19,
    PasswordHash = "234567",
    Salt = "",
    RefreshToken = ""
};


var userDTO = user.MapToUserDTO();

Console.WriteLine(JsonSerializer.Serialize(userDTO));

var userA = userDTO.MapToUser();

Console.WriteLine(JsonSerializer.Serialize(userA));

