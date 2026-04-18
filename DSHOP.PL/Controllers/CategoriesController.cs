using DSHOP.BLL.Service;
using DSHOP.DAL.Data;
using DSHOP.DAL.DTO.Request;
using DSHOP.DAL.DTO.Response;
using DSHOP.DAL.Models;
using DSHOP.DAL.Repository;
using DSHOP.PL.Resources;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace DSHOP.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IStringLocalizer<SharedResource> _localizer;

        public CategoriesController(ICategoryService categoryService, IStringLocalizer<SharedResource> localizer)
        {
            _categoryService = categoryService;
            _localizer = localizer;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            var response = _categoryService.GetAllCategory();
           
            return Ok(new { Message = _localizer["Success"].Value, response });
        }
        [HttpPost("")]
        public IActionResult Create(CategoryRequest request)
        {
            
            _categoryService.CreateCategory(request);

            return Ok(new { Message = _localizer["Success"].Value });
        }
    }
}
