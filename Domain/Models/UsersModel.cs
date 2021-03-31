using System;
using System.Collections.Generic;
using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Domain.Models
{
    public class UsersModel
    {
        private int IdUser;
        private string user_Name;
        private string user_Ced;
        private string user_Passwd;
        private string user_Type;

        private readonly IUsersRepository usersRepository;
        public EntityState State { private get; set; }

        private List<UsersModel> listUsers;

        //PROPIEDADDES/MODELO DE VISTA/VALIDACIONES
        public int IdUserMod { get => IdUser; set => IdUser = value; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [RegularExpression("^[a-zA-ZäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙñÑ ]+$", ErrorMessage = "Nombre debe ser solo letras")]
        public string User_NameMod { get => user_Name; set => user_Name = value; }

        [Required(ErrorMessage = "Debe ingresar un número de cédula o R.U.C.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Cédula o R.U.C. debe ser solo números")]
        [StringLength(maximumLength: 13, MinimumLength = 10, ErrorMessage = "Cédula o R.U.C. debe tener mínimo 10 dígitos")]
        public string User_CedMod { get => user_Ced; set => user_Ced = value; }

        [Required(ErrorMessage = "Debe ingresar una contraseña")]
        [StringLength(maximumLength: 25, MinimumLength = 4, ErrorMessage = "Contraseña debe tener mínimo 4 números/letras")]
        public string User_PasswdMod { get => user_Passwd; set => user_Passwd = value; }

        [Required(ErrorMessage = "Debe escoger el tipo de usuario")]
        [RegularExpression("^[(Administrador)(Usuario)]+$", ErrorMessage = "Debe escoger el tipo de usuario")]
        public string User_TypeMod { get => user_Type; set => user_Type = value; }

        //Constructor
        public UsersModel()
        {
            usersRepository = new UsersRepository();
        }

        public string SaveChanges()
        {
            string message = null;

            try
            {
                var usersDataModel = new TblUsers
                {
                    IdUser = IdUser,
                    User_Name = user_Name,
                    User_Ced = user_Ced,
                    User_Passwd = user_Passwd,
                    User_Type = user_Type
                };

                switch (State)
                {
                    //se pueden hacer calculos para almacenar en la BD
                    case EntityState.Added:
                        usersRepository.Add(usersDataModel);
                        message = "Usuario registrado";
                        break;
                    case EntityState.Modified:
                        usersRepository.Edit(usersDataModel);
                        message = "Datos actualizados";
                        break;
                    case EntityState.Deleted:
                        usersRepository.Remove(IdUser);
                        message = "Usuario eliminado";
                        break;
                }

            }
            catch (Exception ex)
            {
                if (ex is SqlException SqlEx && SqlEx.Number == 2627)
                {
                    message = "Usuario ya registrado";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public List<UsersModel> GetAll()
        {
            var usersDatModel = usersRepository.GetAll();
            listUsers = new List<UsersModel>();
            foreach (TblUsers item in usersDatModel)
            {
                listUsers.Add(new UsersModel
                {
                    IdUser = item.IdUser,
                    user_Name = item.User_Name.Trim(),
                    user_Ced = item.User_Ced.Trim(),
                    user_Passwd = item.User_Passwd.Trim(),          
                    user_Type = item.User_Type
                });
            }
            return listUsers;
        }

        public IEnumerable<UsersModel> FindByCed(string filter)
        {
            return listUsers.FindAll(e => e.user_Ced.ToUpper().Contains(filter.ToUpper()) || e.user_Name.ToUpper().Contains(filter.ToUpper()) || e.user_Type.ToUpper().Contains(filter.ToUpper()));            
        }

        public void Dispose()
        {
        }
    }
}
