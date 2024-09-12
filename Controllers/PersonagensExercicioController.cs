using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;

namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonagensExercicioController : ControllerBase
    {
        private static List<Personagem> personagens
         = new List<Personagem>()
        {
            new Personagem() { Id=  1, Nome="Frodo", PontosVida=140, Forca=17, Defesa=23, Inteligencia=33, Classe = Models.Enuns.ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=170, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=103, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=106, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=101, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=107, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=110, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        //Método a
        [HttpGet("{GetByNome}")]
        public IActionResult GetByNome(string GetByNome)
        {
            return Ok(personagens.FirstOrDefault(pe => pe.Nome == GetByNome));    
        }

        //Método b
        [HttpGet("GetClerigoMago")]
        public IActionResult GetClerigoMago()
        {
          personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro);
          List<Personagem> listaFinal = personagens.OrderByDescending(p => p.PontosVida).ToList();
          
          return Ok(listaFinal);           
        }

        //Método c
        [HttpGet("GetEstatisticas")]
        public IActionResult GetEstatisticas()
        {  
            return Ok("A soma da inteligência dos personagens é: " + personagens.Sum(p => p.Inteligencia) + "\n" + "A quantidade de personagens é: " + personagens.Count);
        }

        //Método d
        [HttpPost("PostValidacao")]
        public IActionResult PostValidacao(Personagem novoPersonagem)
        {
            if(novoPersonagem.Defesa < 10 || novoPersonagem.Inteligencia > 30) {
                return BadRequest("A defesa do personagem não pode ser menor que 10 e a inteligência não pode ser maior que 30");
            } else {
                personagens.Add(novoPersonagem);
                return Ok(personagens);
            }        
        }

        //Método e
        [HttpPost("PostValidacaoMago")]
        public IActionResult PostValidacaoMago(Personagem novoPersonagem)
        {
            if(novoPersonagem.Classe == ClasseEnum.Mago) {
                if(novoPersonagem.Inteligencia < 35){
                    return BadRequest("Um personagem do tipo mago não pode ter inteligência inferior a 35");
            } else {
                    personagens.Add(novoPersonagem);
                    return Ok(personagens);
                }
            } else {
                    return Ok("O personagem tem que ser do tipo mago");
            }
        }

      



    }
}