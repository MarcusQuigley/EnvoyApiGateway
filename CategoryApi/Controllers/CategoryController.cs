using CategoryApi.Entities;
using CategoryApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CategoryApi.Controllers
{
    [ApiController]
    [Route("category")]
    public class CategoryController : ControllerBase
    {
 
        private readonly ICategoryRepository _service;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger, ICategoryRepository service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> Get()
        {
            var categories = await _service.GetCategories();
            if (categories == null)
                return NotFound();
            return Ok(categories);
        }
    }
}
