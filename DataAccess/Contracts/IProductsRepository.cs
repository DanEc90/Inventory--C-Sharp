using DataAccess.Entities;

namespace DataAccess.Contracts
{
    public interface IProductsRepository : IGenericRepository<TblProducts>
    {
        //Sirve para metodos especificos como usuarios por tipo de acceso etc etc
    }
}
