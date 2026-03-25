using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskFlow.API.DTOs;

namespace TaskFlow.API.Services
{
    public interface ITaskService
    {
        Task<TaskResponseDto> CreateAsync(CreateTaskDto dto);
        Task<IEnumerable<TaskResponseDto>> GetAllAsync();
        Task<TaskResponseDto?> GetByIdAsync(Guid id);
        Task<bool> UpdateAsync(Guid id, UpdateTaskDto dto);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> CompleteAsync(Guid id);
    }
}