using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wipro.WebApi.DAL.Fila;
using Wipro.WebApi.Model;

namespace Wipro.WebApi.Api.Controllers
{
    [ApiController]
    [Route("fila")]
    public class FilaController : Controller
    {
        private JsonMoeda _jsonMoeda;
        private MoedaDAL _moedaDAL;

        public FilaController(JsonMoeda jsonMoeda, MoedaDAL moedaDAL)
        {
            _jsonMoeda = jsonMoeda;
            _moedaDAL = moedaDAL;
        }


        [HttpPost("AddItemFila")]
        //public IActionResult Incluir([FromForm] LivroUpload model)
        public IActionResult AddItemFila([FromBody] List<JsonMoeda> model)
        {
            if (ModelState.IsValid)
            {
                _moedaDAL.AddItemFila(model);
                return Ok();
            }            
            return BadRequest();

        }



        [HttpGet("GetItemFila")]        
        public IActionResult GetItemFila()
        {
            _jsonMoeda = _moedaDAL.GetUltimoItemFila();
            return Ok(_jsonMoeda);            
        }




        [HttpGet("teste")]
        //public IActionResult Incluir([FromBody] LivroUpload model)
        public IActionResult teste()
        {
            return Ok();
        }



    }
}
