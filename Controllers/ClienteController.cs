using Microsoft.AspNetCore.Mvc;
using MinhaApi.Data;
using MinhaApi.model;
using MinhaApi.ViewModel;

namespace MinhaApi.Controllers{

  [ApiController]
  [Route("api/v1/clientes")]
  public class ClienteController : ControllerBase{

    private readonly IClienteRepository _clienteRepository;

    public ClienteController(IClienteRepository clienteRepository){
      _clienteRepository = clienteRepository ?? throw new ArgumentNullException();
    }


    [HttpPost]
    public IActionResult Add(ClienteViewModel clienteView){
      var cliente = new Cliente(clienteView.Nome, clienteView.Email, clienteView.NumeroContato, clienteView.DataNascimento);
      _clienteRepository.add(cliente);
      return Ok();
    }

    [HttpGet]
    public IActionResult Get(){
      var clientes = _clienteRepository.Get();

      return Ok(clientes);
    }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var cliente = _clienteRepository.GetById(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }


        [HttpPut("{id}")]
        public IActionResult Update(int id, ClienteViewModel clienteView)
        {
            var clienteExistente = _clienteRepository.GetById(id);
            if (clienteExistente == null)
            {
                return NotFound();
            }

            clienteExistente.Update(clienteView.Nome, clienteView.Email, clienteView.NumeroContato, clienteView.DataNascimento);
            _clienteRepository.update(clienteExistente);
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var clienteExistente = _clienteRepository.GetById(id);
            if (clienteExistente == null)
            {
                return NotFound();
            }
            
            _clienteRepository.delete(id);
            return NoContent();
        }
    }
}