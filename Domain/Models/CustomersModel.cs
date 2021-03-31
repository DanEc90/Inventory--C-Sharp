using DataAccess.Contracts;
using DataAccess.Entities;
using DataAccess.Repositories;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;

namespace Domain.Models
{
    public class CustomersModel
    {
        private int IdCusto;
        private string CustoCed;
        private string CustoName;
        private string CustoAddress;
        private string CustoPhone;

        private readonly ICustomersRepository CustomersRepository;
        public EntityState State { private get; set; }

        private List<CustomersModel> listCustomers;

        //PROPIEDADDES/MODELO DE VISTA/VALIDACIONES
        public int IdCustoMod { get => IdCusto; set => IdCusto = value; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [RegularExpression("^[a-zA-ZäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙñÑ ]+$", ErrorMessage = "Nombre debe ser solo letras")]
        public string CustoNameMod { get => CustoName; set => CustoName = value; }

        [Required(ErrorMessage = "Debe ingresar un número de cédula o R.U.C.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Cédula o R.U.C. debe ser solo números")]
        [StringLength(maximumLength: 13, MinimumLength = 10, ErrorMessage = "Cédula o R.U.C. debe tener mínimo 10 dígitos")]
        public string CustoCedMod { get => CustoCed; set => CustoCed = value; }
        
        [Required(ErrorMessage = "Debe ingresar una dirección")]
        [RegularExpression("^[0-9a-zA-ZäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙñÑ ]+$", ErrorMessage = "Dirección no debe tener caracteres especiales")]
        [StringLength(maximumLength: 50, MinimumLength = 5, ErrorMessage = "Dirección no valida")]
        public string CustoAddressMod { get => CustoAddress; set => CustoAddress = value; }

        [Required(ErrorMessage = "Debe ingresar un número de teléfono.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Teléfono debe ser solo números")]
        [StringLength(maximumLength: 10, MinimumLength = 7, ErrorMessage = "Teléfono no valido")]
        public string CustoPhoneMod { get => CustoPhone; set => CustoPhone = value; }

        //Constructor
        public CustomersModel()
        {
            CustomersRepository = new CustomersRepository();
        }

        public string SaveChanges()
        {
            string message = null;

            try
            {
                var customersDataModel = new TblCustomers
                {
                    IdCusto = IdCusto,
                    CustoName = CustoName,
                    CustoCed = CustoCed,                    
                    CustoAddress = CustoAddress,
                    CustoPhone = CustoPhone
                };

                switch (State)
                {
                    //se pueden hacer calculos para almacenar en la BD
                    case EntityState.Added:
                        CustomersRepository.Add(customersDataModel);
                        message = "Cliente registrado";
                        break;
                    case EntityState.Modified:
                        CustomersRepository.Edit(customersDataModel);
                        message = "Datos actualizados";
                        break;
                    case EntityState.Deleted:
                        CustomersRepository.Remove(IdCusto);
                        message = "Cliente eliminado";
                        break;
                }

            }
            catch (Exception ex)
            {
                if (ex is SqlException SqlEx && SqlEx.Number == 2627)
                {
                    message = "Cliente ya registrado";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }
        
        public List<CustomersModel> GetAll()
        {
            var customersDataModel = CustomersRepository.GetAll();
            listCustomers = new List<CustomersModel>();
            foreach (TblCustomers item in customersDataModel)
            {
                listCustomers.Add(new CustomersModel
                {
                    IdCusto = item.IdCusto,
                    CustoName = item.CustoName.Trim(),
                    CustoCed = item.CustoCed.Trim(),                    
                    CustoAddress = item.CustoAddress.Trim(),
                    CustoPhone = item.CustoPhone.Trim()
                });
            }
            return listCustomers;
        }

        public IEnumerable<CustomersModel> FindByCed(string filter)
        {
            return listCustomers.FindAll(e => e.CustoCed.ToUpper().Contains(filter.ToUpper()) || e.CustoName.ToUpper().Contains(filter.ToUpper()));
        }

        public IEnumerable<CustomersModel> FindCustomerBill(string filter)
        {
            return GetAll().FindAll(e => e.CustoCed == filter);
        }

        public void Dispose()
        {
        }
    }
}
