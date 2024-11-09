namespace MinhaApi.model{
  public interface IClienteRepository{
        void add(Cliente cliente);
        List<Cliente> Get();
        Cliente GetById(int id);
        void update(Cliente cliente);
        void delete(int id); 
  }
}