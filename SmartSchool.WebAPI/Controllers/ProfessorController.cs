using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.WebAPI.Models;

namespace SmartSchool.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {

        public List<Aluno> Alunos = new List<Aluno>(){

            new Aluno(){
                Id = 1,
                Nome= "Marcos",
                Sobrenome = "Almeida",
                Telefone = "123456"
            },

                new Aluno(){
                Id = 2,
                Nome= "Marta",
                Sobrenome = "Silva",
                Telefone = "123456"
            },

                new Aluno(){
                Id = 3,
                Nome= "Laura",
                Sobrenome = "Pereira",
                Telefone = "123456"
            },
        };

        public ProfessorController() {}

        [HttpGet]
        public IActionResult Get()
        {
               return Ok(Alunos);
        }
    }
}