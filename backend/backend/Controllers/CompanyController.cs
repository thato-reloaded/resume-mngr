using AutoMapper;
using backend.Context;
using backend.Dtos.Company;
using backend.Entities;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private ApplicationDbContext _context { get; set; }
        private IMapper _mapper { get; set; }
        public CompanyController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // CRUD
        // Create
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyCreateDto dto)
        {
            Company newCompany = _mapper.Map<Company>(dto);
            await _context.Companies.AddAsync(newCompany);
            await _context.SaveChangesAsync();

            return Ok("Company created successfully");
        }

        // Read
        // Update
        // Delete
    }
}
