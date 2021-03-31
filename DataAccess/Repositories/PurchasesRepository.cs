using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class PurchasesRepository : MasterRepository, IPurchasesRepository
    {
        //Campos
        private readonly string selectAll;
        private readonly string insert;
        private readonly string update;
        private readonly string delete;
        private readonly string algo;
        //private readonly string insert_update;

        //Propiedades
        //::

        //Constructor
        public PurchasesRepository()
        {
            selectAll = "SELECT IdComp, IdProd_Comp, comp_Date, comp_Cant FROM [dbo].[tblPurchases]";
            insert = "INSERT INTO [dbo].[tblPurchases] VALUES (@comp_Cant, @IdProd_Comp, @comp_Date)";
            update = "UPDATE [dbo].[tblPurchases] SET comp_Cant = @comp_Cant WHERE IdComp = @IdComp";
            delete = "DELETE FROM [dbo].[tblPurchases] WHERE IdComp = @IdComp";
            algo = "SELECT PUR.IdComp, PUR.IdProd_Comp, PRO.prod_Cod, PRO.prod_Name, PUR.comp_Date, PUR.comp_Cant " +
                        "FROM tblPurchases PUR INNER JOIN tblProducts PRO " +
                            "ON PUR.IdProd_Comp = PRO.IdProd " +
                                "ORDER BY PUR.comp_Date DESC";
        }

        //Metodos
        public int Add(TblPurchases entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@comp_Cant", entity.Comp_Cant),
                new SqlParameter("@IdProd_Comp", entity.IdProd_Comp),
                new SqlParameter("@comp_Date", entity.Comp_Date)                
            };
            return ExecuteNonQuery(insert);
        }

        public int Edit(TblPurchases entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdComp", entity.IdComp),
                new SqlParameter("@comp_Cant", entity.Comp_Cant)
                //new SqlParameter("@IdProd_Comp", entity.IdProd_Comp),
                //new SqlParameter("@comp_Date", entity.Comp_Date)
            };
            return ExecuteNonQuery(update);
        }

        public IEnumerable<TblPurchases> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var ListPurcahses = new List<TblPurchases>();
            foreach (DataRow item in tableResult.Rows)
            {
                ListPurcahses.Add(new TblPurchases
                {                    
                    IdComp = Convert.ToInt32(item[0]),
                    IdProd_Comp = Convert.ToInt32(item[1]),
                    Comp_Date = Convert.ToDateTime(item[2]),
                    Comp_Cant = Convert.ToInt32(item[3]),                                       
                });
            }            
            return ListPurcahses;          
        }

        public int Remove(int Identificador)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdComp", Identificador)
            };
            return ExecuteNonQuery(delete);
        }

        //vamos a ver si me sale
        public IEnumerable<TblPurchases> PURPRO()
        {
            var tableResult = ExecuteReader(algo);
            var ListPurcahsesalgo = new List<TblPurchases>();
            foreach (DataRow item in tableResult.Rows)
            {
                ListPurcahsesalgo.Add(new TblPurchases
                {                    
                    IdComp = Convert.ToInt32(item[0]),
                    IdProd_Comp = Convert.ToInt32(item[1]),
                    Prod_Cod = item[2].ToString(),
                    Prod_Name = item[3].ToString(),
                    Comp_Date = Convert.ToDateTime(item[4]),
                    Comp_Cant = Convert.ToInt32(item[5])
                });
            }
            return ListPurcahsesalgo;
        }
    }
}
