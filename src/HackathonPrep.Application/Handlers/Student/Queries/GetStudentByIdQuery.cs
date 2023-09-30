using HackathonPrep.Application.DTOs;
using MediatR;

namespace HackathonPrep.Application.Handlers.Student.Queries;

public class GetStudentByIdQuery : IRequest<StudentDto>
{
    public string Id { get; set; }

}
