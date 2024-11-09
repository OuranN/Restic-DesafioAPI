using MinhaApi.model;
using Microsoft.EntityFrameworkCore;

namespace MinhaApi.Data
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly MyDbContext _context;

        public ProdutoRepository(MyDbContext context)
        {
            _context = context;
        }

        public void Add(Produto produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
        }

        public List<Produto> Get()
        {
            return _context.Produto.ToList();
        }

        public Produto GetById(int id)
        {
            return _context.Produto.FirstOrDefault(p => p.ID_Produto == id);
        }

        public void Update(Produto produto)
        {
            _context.Produto.Update(produto);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var produto = GetById(id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
                _context.SaveChanges();
            }
        }
    }
}
