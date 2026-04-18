using Azure.Core;
using DSHOP.DAL.DTO.Request;
using DSHOP.DAL.DTO.Response;
using DSHOP.DAL.Models;
using DSHOP.DAL.Repository;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSHOP.BLL.Service
{
    public class CategoryService: ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository) {
            _repository = repository;
        }
        public List<CategoryResponse> GetAllCategory()
        {
            var category = _repository.GetAll();
            var response = category.Adapt<List<CategoryResponse>>();
            return response;
        }

        public CategoryResponse CreateCategory(CategoryRequest request)
        {
            var result = request.Adapt<Category>();
            _repository.create(result);
           return result.Adapt<CategoryResponse>();


        }
    }
}
