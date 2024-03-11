namespace Mapper;

public static class ExtensionsForUsers
{
    //userni UserDTOga mapping qilish
    public static UserDTO MapToUserDTO(this User user)
    {
        return new UserDTO()
        {
            Id = user.Id,
            Name = user.Name,
            Age = user.Age
        };
    }

    //userDTOni userga mapping qilish
    public static User MapToUser (this UserDTO userDTO)
    {
        return new User()
        {
            Id = userDTO.Id,
            Name = userDTO.Name,
            Age = userDTO.Age
        };
    }
}