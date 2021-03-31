using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class ProductsRepository : MasterRepository, IProductsRepository
    {
        //Campos
        private readonly string selectAll;       
        private readonly string delete;
        private readonly string insert_update;

        //Propiedades
        //::

        //Constructor
        public ProductsRepository()
        {
            selectAll = "SELECT * FROM [dbo].[tblProducts]";            
            delete = "DELETE FROM [dbo].[tblProducts] WHERE IdProd = @IdProd";
            insert_update = "MERGE INTO tblProducts " +
                "USING(VALUES(@prod_Cod, @prod_Name, @prod_Pr_may, @prod_Pr_men, @prod_Stock)) " +
                    "AS tmp(codigo, nombre, premay, premen, stock) ON tblProducts.prod_Cod = tmp.codigo " +
                "WHEN MATCHED THEN " +
                    "UPDATE SET prod_Cod = @prod_Cod, prod_Name = @prod_Name, prod_Pr_may = @prod_Pr_may, prod_Pr_men = @prod_Pr_men, prod_Stock = @prod_Stock " +
                "WHEN NOT MATCHED THEN " +
                    "INSERT(prod_Cod, prod_Name, prod_Pr_may, prod_Pr_men, prod_Stock) " +
                        "VALUES(@prod_Cod, @prod_Name, @prod_Pr_may, @prod_Pr_men, @prod_Stock);";
        }

        //Metodos
        public int Add(TblProducts entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@prod_Cod", entity.ProdCod),
                new SqlParameter("@prod_Name", entity.ProdName),
                new SqlParameter("@prod_Pr_may", entity.ProdPrMay),
                new SqlParameter("@prod_Pr_men", entity.ProdPrMen),
                new SqlParameter("@prod_Stock", entity.ProdStock)
            };
            return ExecuteNonQuery(insert_update);
        }

        public int Edit(TblProducts entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdProd", entity.IdProd),
                new SqlParameter("@prod_Cod", entity.ProdCod),
                new SqlParameter("@prod_Name", entity.ProdName),
                new SqlParameter("@prod_Pr_may", entity.ProdPrMay),
                new SqlParameter("@prod_Pr_men", entity.ProdPrMen),
                new SqlParameter("@prod_Stock", entity.ProdStock)
            };
            return ExecuteNonQuery(insert_update);
        }

        public IEnumerable<TblProducts> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var ListProducts = new List<TblProducts>();
            foreach (DataRow item in tableResult.Rows)
            {
                ListProducts.Add(new TblProducts
                {
                    IdProd = Convert.ToInt32(item[0]),
                    ProdCod = item[1].ToString(),
                    ProdName = item[2].ToString(),
                    ProdPrMay = Convert.ToSingle(item[3]),
                    ProdPrMen = Convert.ToSingle(item[4]),
                    ProdStock = Convert.ToInt32(item[5])
                });
            }
            return ListProducts;
        }

        public int Remove(int Identificador)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdProd", Identificador)
            };
            return ExecuteNonQuery(delete);
        }
    }
}