using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _AboutService;

        public AboutController(IAboutService AboutService)
        {
            _AboutService = AboutService;
        }
        [HttpGet]
        public IActionResult AboutList()
        {
            var values = _AboutService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddAbout(About About)
        {
            _AboutService.TInsert(About);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteAbout(int id)
        {
            var values = _AboutService.TGetByID(id);
            _AboutService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateAbout(About About)
        {
            _AboutService.TUpdate(About);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var values = _AboutService.TGetByID(id);
            return Ok(values);
        }
    }
}
