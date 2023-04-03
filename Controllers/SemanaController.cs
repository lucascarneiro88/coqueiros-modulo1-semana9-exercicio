using exercicio_semana9;
using exercicio_semana9.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace exercicio_semana9.Controllers
{

    public class SemanaController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class SemanaController1 : ControllerBase
        {
            private readonly SemanaContext _semanaContext;

            public SemanaController1(SemanaContext semanaContext)
            {
                _semanaContext = semanaContext;
            }

            [HttpGet]
            public ActionResult Get()
            {
                return Ok();
            }

            [HttpGet("{id}")]
            public ActionResult Get([FromRoute] int id)
            {
                return Ok();
            }

            [HttpPost]
            public ActionResult Post([FromBody] SemanaModel semanaModel)
            {
                if (semanaModel.Id > 0)
                {
                    return Ok(true);
                }
                {
                    return BadRequest("ID precisa ser maior que 0");// Validar se o ID for maior que zero não precisa incluir o registro
                }



            }

            private ActionResult Put([FromBody] SemanaModel semanaModel, [FromRoute] int id)
            {
                if (semanaModel.Id == id)
                {
                    return Ok();
                }

                return BadRequest("ID não identificado!");
            }
            [HttpDelete]
            [Route("{id}")]
            public ActionResult Delete([FromRoute] int id)
            {
                
                return BadRequest("ID não identificado!");
            }



        }
    }

}