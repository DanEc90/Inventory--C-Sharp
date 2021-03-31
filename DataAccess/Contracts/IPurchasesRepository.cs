using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IPurchasesRepository : IGenericRepository<TblPurchases>
    {
        //Sirve para metodos especificos como usuarios por tipo de acceso etc etc
        //int Add(TblPurchases entity);
        //int Edit(TblPurchases entity);
        //int Remove(int Identificador);
        IEnumerable<TblPurchases> PURPRO();
    }
}
