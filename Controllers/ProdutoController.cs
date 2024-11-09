using Microsoft.AspNetCore.Mvc;
using MinhaApi.Data;
using MinhaApi.model;
using MinhaApi.ViewModel;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/v1/produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public IActionResult Add(ProdutoViewModel produtoView)
        {
            var produto = new Produto(produtoView.Nome, produtoView.Tipo, produtoView.Valor);
            _produtoRepository.Add(produto);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var produtos = _produtoRepository.Get();
            return Ok(produtos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var produto = _produtoRepository.GetById(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, ProdutoViewModel produtoView)
        {
            var produtoExistente = _produtoRepository.GetById(id);
            if (produtoExistente == null)
            {
                return NotFound();
            }

            produtoExistente.Update(produtoView.Nome, produtoView.Tipo, produtoView.Valor);
            _produtoRepository.Update(produtoExistente);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produtoExistente = _produtoRepository.GetById(id);
            if (produtoExistente == null)
            {
                return NotFound();
            }

            _produtoRepository.Delete(id);
            return NoContent();
        }
    }
}
