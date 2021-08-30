using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TesteMazzaFC.Api.Data;
using TesteMazzaFC.Api.Intefaces;
using TesteMazzaFC.Api.Model;

namespace TesteMazzaFC.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : MainController
    {
        private readonly ApiDbContext _context;

        public CategoriaController(ApiDbContext context, INotificador notificador) : base(notificador)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categoria>>> GetCategoria()
        {
            return await _context.Categorias.ToListAsync();
        }
    }
}
