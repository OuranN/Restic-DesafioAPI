using MinhaApi.model;

namespace MinhaApi.Data
{
    public interface IProdutoRepository
    {
        void Add(Produto produto);
        List<Produto> Get();
        Produto GetById(int id);
        void Update(Produto produto);
        void Delete(int id);
    }
}
