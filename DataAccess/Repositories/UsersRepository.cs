using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Contracts;
using DataAccess.Entities;

namespace DataAccess.Repositories
{
    public class UsersRepository : MasterRepository, IUsersRepository
    {
        //Campos
        private readonly string selectAll;
        //private string insert;
        //private string update;
        private readonly string delete;
        private readonly string insert_update;

        //Propiedades
        //::

        //Constructor
        public UsersRepository()
        {
            selectAll = "SELECT * FROM [dbo].[tblUsers]";
            //insert = "INSERT INTO [dbo].[tblUsers] VALUES (@user_Name, @user_Ced, @user_Passwd, @user_Type)";
            //update = "UPDATE [dbo].[tblUsers] SET user_Name = @user_Name, user_Ced = @user_Ced, user_Passwd = @user_Passwd, user_Type = @user_Type WHERE IdUser = @IdUser";
            delete = "DELETE FROM [dbo].[tblUsers] WHERE IdUser = @IdUser";            
            insert_update = "MERGE INTO tblUsers " +
                "USING(VALUES(@user_Name, @user_Ced, @user_Passwd, @user_Type)) " +
                    "AS tmp(nombre, cedula, contraseña, tipo) ON tblUsers.user_Ced = tmp.cedula " +
                "WHEN MATCHED THEN " +
                    "UPDATE SET user_Name = @user_Name, user_Ced = @user_Ced, user_Passwd = @user_Passwd, user_Type =  @user_Type " +
                "WHEN NOT MATCHED THEN " +
                    "INSERT(user_Name, user_Ced, user_Passwd, user_Type) " +
                        "VALUES(@user_Name, @user_Ced, @user_Passwd, @user_Type);";
        }

        //Metodos
        public int Add(TblUsers entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@user_Name", entity.User_Name),
                new SqlParameter("@user_Ced", entity.User_Ced),
                new SqlParameter("@user_Passwd", entity.User_Passwd),
                new SqlParameter("@user_Type", entity.User_Type)
            };
            return ExecuteNonQuery(insert_update);
        }

        public int Edit(TblUsers entity)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdUser", entity.IdUser),
                new SqlParameter("@user_Name", entity.User_Name),
                new SqlParameter("@user_Ced", entity.User_Ced),
                new SqlParameter("@user_Passwd", entity.User_Passwd),
                new SqlParameter("@user_Type", entity.User_Type)
            };
            return ExecuteNonQuery(insert_update);
        }

        public IEnumerable<TblUsers> GetAll()
        {
            var tableResult = ExecuteReader(selectAll);
            var ListUsers = new List<TblUsers>();
            foreach(DataRow item in tableResult.Rows)
            {
                ListUsers.Add(new TblUsers
                {
                    IdUser = Convert.ToInt32(item[0]),
                    User_Name = item[1].ToString(),
                    User_Ced = item[2].ToString(),
                    User_Passwd = item[3].ToString(),
                    User_Type = item[4].ToString()
                });
            }
            return ListUsers;
        }

        public int Remove(int Identificador)
        {
            parameters = new List<SqlParameter>
            {
                new SqlParameter("@IdUser", Identificador)
            };
            return ExecuteNonQuery(delete);
        }
    }
}
