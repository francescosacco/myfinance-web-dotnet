namespace myfinance_web_dotnet_infra.Interfaces.Base
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Interface do CRUD.
        void Cadastrar(TEntity Entidade);
        void Excluir(int Id);
        List<TEntity> ListarRegistros();
        TEntity RetornarRegistro(int Id);
    }
}
