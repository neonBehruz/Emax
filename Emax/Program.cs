using Emax.Data.IRepositories;
using Emax.Data.Repositories;
using Emax.Domain.Entities;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        IRepository<Teacher> teacherRepository = new Repository<Teacher>();
        teacherRepository.InsertAsync(new Teacher
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Email = "john.doe@example.com",
            Password = "password123",
            Groups = [],
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow
        });

        IRepository<Group> groupRepository = new Repository<Group>();
        groupRepository.InsertAsync(new Group
        {
            Id = 1,
            Name = "Math 101",
            Description = "Basic Mathematics",
            Room = 101,
            TeacherId = 1,
            Created = DateTime.UtcNow,
            Updated = DateTime.UtcNow
        });
    }
}