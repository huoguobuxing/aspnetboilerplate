using Abp.Application.Services.Dto;

namespace Taskever.Application.Services.Dto.Tasks
{
    public class CreateTaskOutput : IOutputDto
    {
        public TaskDto Task { get; set; }
    }
}