using Microsoft.AspNetCore.Mvc;
using OnionArchitecture.Application.Interfaces;
using OnionArchitecture.Application.Interfaces.Repositories;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepository _productRepository;
        readonly IEmailService _emailService;
        public ProductController(IProductRepository productRepository, IEmailService emailService)
        {
            _productRepository = productRepository;
            _emailService = emailService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> allProducts = await _productRepository.GetAsync();
            return Ok(allProducts);
        }
        [HttpGet("sendemail")]
        public IActionResult SendEmail()
        {
            bool result = _emailService.Send("can.289@hotmail.com", "Test - test");
            return Ok(result);
        }
    }
}
