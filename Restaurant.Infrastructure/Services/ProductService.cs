using Restaurant.Application.DTOs;
using Restaurant.Application.Interfaces;
using Restaurant.Core.Entities;
using AutoMapper;

namespace Restaurant.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var product = await _unitOfWork.Products.GetByIdAsync(id);
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<ProductDto> AddAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            var added = await _unitOfWork.Products.AddAsync(product);
            await _unitOfWork.SaveChangesAsync(); 
            return _mapper.Map<ProductDto>(added);
        }

        public async Task UpdateAsync(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            await _unitOfWork.Products.UpdateAsync(product);
            await _unitOfWork.SaveChangesAsync(); 
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Products.DeleteAsync(id);
            await _unitOfWork.SaveChangesAsync(); 
        }
    }
}
