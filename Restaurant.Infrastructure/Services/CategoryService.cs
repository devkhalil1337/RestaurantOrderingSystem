using Restaurant.Application.DTOs;
using Restaurant.Application.Interfaces;
using Restaurant.Core.Entities;
using AutoMapper;

namespace Restaurant.Infrastructure.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            var category = await _unitOfWork.Category.GetAllAsync();
            return _mapper.Map<IEnumerable<CategoryDto>>(category);
        }

        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var category = await _unitOfWork.Category.GetByIdAsync(id);
            return _mapper.Map<CategoryDto>(category);
        }

        public async Task<CategoryDto> AddAsync(CategoryDto categoryDto)
        {
            var category = _mapper.Map<Category>(categoryDto);
            var added = await _unitOfWork.Category.AddAsync(category);
            await _unitOfWork.SaveChangesAsync(); 
            return _mapper.Map<CategoryDto>(added);
        }

        public async Task UpdateAsync(CategoryDto categoryDto)
        {
            var product = _mapper.Map<Category>(categoryDto);
            await _unitOfWork.Category.UpdateAsync(product);
            await _unitOfWork.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Category.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync(); 
        }
    }
}
