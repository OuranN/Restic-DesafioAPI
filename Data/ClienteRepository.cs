using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using MinhaApi.model;

namespace MinhaApi.Data{
    public class ClienteRepository : IClienteRepository
    {

      private readonly MyDbContext _context = new MyDbContext();
        public void add(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
            _context.SaveChanges();
        }

        public List<Cliente> Get()
        {
            return _context.Cliente.ToList();
        }
           // Método para obter um cliente pelo ID
        public Cliente GetById(int id)
        {
            return _context.Cliente.FirstOrDefault(c => c.id_Cliente == id);
        }

        // Método para atualizar um cliente
        public void update(Cliente cliente)
        {
            _context.Cliente.Update(cliente);
            _context.SaveChanges();
        }

        // Método para excluir um cliente
        public void delete(int id)
        {
            var cliente = GetById(id);
            if (cliente != null)
            {
                _context.Cliente.Remove(cliente);
                _context.SaveChanges();
            }
        }
    }
}