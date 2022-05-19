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
        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            List<Product> allProducts = await _productRepository.GetAllAsync();
            return Ok(allProducts);
        }
        [HttpGet("sendemail")]
        public IActionResult SendEmail()
        {
            bool result = _emailService.Send("test", "Test - test");
            return Ok(result);
        }

        /// <summary>
        /// Kaydetmek için
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost("save")]
        public async Task Save(Product product)
        {
            await _productRepository.AddAsync(product);
        }

        /// <summary>
        /// Güncelleme için
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpPost("update")]
        public async Task Update(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        /// <summary>
        /// Güncelleme için
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        [HttpDelete("delete")]
        public async Task Delete(Product product)
        {
            await _productRepository.DeleteAsync(product);
        }
    }
}
