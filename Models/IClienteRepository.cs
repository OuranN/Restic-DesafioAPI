namespace MinhaApi.model{
  public interface IClienteRepository{
        void add(Cliente cliente);
        List<Cliente> Get();
        Cliente GetById(int id); // Adicionar método para buscar cliente por ID
        void update(Cliente cliente); // Adicionar método para atualizar cliente
        void delete(int id); // Adicionar método para excluir cliente
  }
}