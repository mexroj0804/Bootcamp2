﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using T_1.Entities;

namespace T_1.Configurations
{
    public class PermissionConfigurations : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasData(new List<Permission>()
            {
                new Permission()
                {
                    Id = 1,
                    Name = "CreateUser"
                },
                new Permission()
                {
                    Id = 2,
                    Name = "UpdateUser"
                },
                new Permission()
                {
                    Id = 3,
                    Name = "DeleteUser"
                },
                new Permission()
                {
                    Id = 4,
                    Name = "GetAllUser"
                },
                new Permission()
                {
                    Id = 5,
                    Name = "GetAllWeathers"
                }
            });
        }
    }
}