using DataAccess.Entities;

namespace DataAccess.Contracts
{
    public interface IUsersRepository:IGenericRepository<TblUsers>
    {
        //Sirve para metodos especificos como usuarios por tipo de acceso etc etc
    }
}
