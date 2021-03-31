using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class CustomersRepository : MasterRepository, ICustomersRepository
    {
        //Campos
        private readonly string selectAll;        
        private readonly string delete;
        private readonly string insert_update;

        //Propiedades
        //::

        //Constructor
        public CustomersRepository()
        {
            selectAll = "SELECT * FROM [dbo].[tblCustomers]";            
            delete = "DELETE FROM [dbo].[tblCustomers] WHERE IdClient = @IdCusto";
            insert_update = "MERGE INTO tblCustomers " +
                "USING(VALUES(@CustoName, @CustoCed, @CustoAddress, @CustoPhone)) " +
                    "AS tmp(nombre, cedula, direccion, telf) ON tblCustomers.cli_Ced = tmp.cedula " +
                "WHEN MATCHED THEN " +
                    "UPDATE SET cli_Name = @CustoName, cli_Ced = @CustoCed, cli_Address = @CustoAddress, cli_Phone = @CustoPhone " +
                "WHEN NOT MATCHED THEN " +
                    "INSERT(cli_Name, cli_Ced, cli_Address, cli_Phone) " +
                        "VALUES(@CustoName, @CustoCed, @CustoAddress, @CustoPhone);";
        }

        //Metodos
        public int Add(TblCustomers entity)
        {
            parameters = new List<SqlParameter>
            {                
                new SqlParameter("@CustoName", entity.CustoName),
                new SqlParameter("@CustoCed", entity.CustoCed),
                new SqlParameter("@CustoAddress", entity.CustoAddress),
                new SqlParameter("@CustoPhone", entity.CustoPhone)
            };
            return ExecuteNonQuery(insert_update);
        }

        public int Edit(TblCustomers entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdClient", entity.IdCusto),
                new SqlParameter("@CustoName", entity.CustoName),
                new SqlParameter("@CustoCed", entity.CustoCed),
                new SqlParameter("@CustoAddress", entity.CustoAddress),
                new SqlParameter("@CustoPhone", entity.CustoPhone)
            };
            return ExecuteNonQuery(insert_update);
        }

        public IEnumerable<TblCustomers> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var ListCustomers = new List<TblCustomers>();
            foreach (DataRow item in tableResult.Rows)
            {
                ListCustomers.Add(new TblCustomers
                {
                    IdCusto = Convert.ToInt32(item[0]),
                    CustoName = item[1].ToString(),
                    CustoCed = item[2].ToString(),
                    CustoAddress = item[3].ToString(),
                    CustoPhone = item[4].ToString()
                });
            }
            return ListCustomers;
        }

        public int Remove(int Identificador)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdCusto", Identificador)
            };
            return ExecuteNonQuery(delete);
        }
    }
}
