using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI_Net6.Data;
using RestAPI_Net6.Models;

namespace RestAPI_Net6.Controllers
{
    //[Authorize]
    [Route("api")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IJWTAuthenticationManager jwtAuthenticationManager;

        public PessoaController(IJWTAuthenticationManager jwtAuthenticationManager)
        {
            this.jwtAuthenticationManager = jwtAuthenticationManager;
        }

        [HttpGet]
        [Route("pessoas")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] Contexto context)
        {
            var pessoas = await context
                .Pessoas
                .AsNoTracking()//Se você está apenas consultando um objeto no EF, ou seja, não vai modificar e gravar, use AsNoTracking() sempre que possível.
                               //Isto não quer dizer que você não possa instanciar outro contexto, mas evitar isto pode lhe dar um ganho de performance!
                .ToListAsync();

            return pessoas == null
                ? NotFound()
                : Ok(pessoas);
        }

        [HttpGet]
        [Route("pessoas/{id}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] Contexto context,
            [FromRoute] int id)
        {
            var pessoa = await context
                .Pessoas
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.id == id);

            return pessoa == null
                ? NotFound()
                : Ok(pessoa);
        }

        [HttpPost("pessoas")]
        public async Task<IActionResult> PostAsync(
            [FromServices] Contexto context,
            [FromBody] Pessoa pessoa)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                await context.Pessoas.AddAsync(pessoa);
                await context.SaveChangesAsync();
                return Created($"api/pessoas/{pessoa.id}", pessoa);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpPut("pessoas/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] Contexto context,
            [FromBody] Pessoa pessoa,
            [FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var p = await context.Pessoas.FirstOrDefaultAsync(x => x.id == id);

            if (p == null)
                return NotFound();

            try
            {
                p.nome = pessoa.nome;

                context.Pessoas.Update(p);
                await context.SaveChangesAsync();
                return Ok(p);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [HttpDelete("pessoas/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] Contexto context,
            [FromRoute] int id)
        {
            var p = await context.Pessoas.FirstOrDefaultAsync(x => x.id == id);

            try
            {
                context.Pessoas.Remove(p);
                await context.SaveChangesAsync();

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }

        [AllowAnonymous]
        [HttpPost("autenticar")]
        public IActionResult Authenticate([FromBody] Usuario user)
        {
            var token = jwtAuthenticationManager.Authenticate(
                user.Username, user.Password);

            if(token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
