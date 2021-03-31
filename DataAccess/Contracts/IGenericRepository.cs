using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IGenericRepository <Entity> where Entity:class
    {
        //tiene los metodos comunes de todas las clases
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(int Identificador);
        IEnumerable<Entity> GetAll();
    }
}
