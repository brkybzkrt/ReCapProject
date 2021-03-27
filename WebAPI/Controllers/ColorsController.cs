using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorsController : ControllerBase
    {

        IColorService _colorService;

        public ColorsController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet("getAll")]

        public IActionResult GetAll()
        {
            var result = _colorService.GetColors();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("addColor")]


        public IActionResult AddColor(Color color)
        {
            var result = _colorService.Add(color);
            if (result.Success==true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("deleteColor")]

        public IActionResult DeleteColor(Color color)
        {
            var result = _colorService.Delete(color);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);


        }
    }
}
