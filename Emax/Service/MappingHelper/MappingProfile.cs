using AutoMapper;
using Emax.Domain.Entities;
using Emax.Service.DTOs.Group;
using Emax.Service.DTOs.Student;
using Emax.Service.DTOs.StudentGroup;
using Emax.Service.DTOs.Teacher;

namespace Emax.Service.MappingHelper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TeacherResultDto, Teacher>().ReverseMap();
        CreateMap<TeacherCreationDto, Teacher>().ReverseMap();
        CreateMap<TeacherUpdateDto, Teacher>().ReverseMap();
        CreateMap<StudentResultDto, Student>().ReverseMap();
        CreateMap<StudentCreationDto, Student>().ReverseMap();
        CreateMap<StudentUpdateDto, Student>().ReverseMap();
        CreateMap<Group, GroupResultDto>().ReverseMap();
        CreateMap<GroupCreationDto, Group>().ReverseMap();
        CreateMap<GroupUpdateDto, Group>().ReverseMap();
        CreateMap<StudentGroupResultDto , Student>().ReverseMap();
        CreateMap<StudentGroupCreationDto, Student>().ReverseMap();
        CreateMap<StudentGroupUpdateDto, Student>().ReverseMap();
    }
}
