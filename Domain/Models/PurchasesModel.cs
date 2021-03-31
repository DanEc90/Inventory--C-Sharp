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
    public class PurchasesModel
    {
        private int IdComp;
        private int IdProd_Comp;
        private DateTime Comp_Date;
        private int Comp_Cant;
        private string Prod_Name;
        private string Prod_Cod;

        private readonly IPurchasesRepository PurchasesRepository;
        public EntityState State { private get; set; }

        private List<PurchasesModel> listPurchases;
        private List<PurchasesModel> listPurchases2;

        //PROPIEDADDES/MODELO DE VISTA/VALIDACIONES
        public int IdCompMod { get => IdComp; set => IdComp = value; }

        public int IdProd_CompMod { get => IdProd_Comp; set => IdProd_Comp = value; }

        public string Prod_CodeMod { get => Prod_Cod; set => Prod_Cod = value; }

        public string Prod_NameMod { get => Prod_Name; set => Prod_Name = value; }

        public DateTime Comp_DateMod { get => Comp_Date; set => Comp_Date = value; }

        [Required(ErrorMessage = "Debe ingresar la cantidad")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Cantidad debe ser solo números")]
        public int Comp_CantMod { get => Comp_Cant; set => Comp_Cant = value; }

        

        //Constructor
        public PurchasesModel()
        {
            PurchasesRepository = new PurchasesRepository();
        }

        public string SaveChanges()
        {
            string message = null;

            try
            {
                var PurchasesDataModel = new TblPurchases
                {
                    IdComp = IdComp,
                    IdProd_Comp = IdProd_Comp,
                    Prod_Cod = Prod_Cod,
                    Prod_Name = Prod_Name,
                    Comp_Date = Comp_Date,
                    Comp_Cant = Comp_Cant
                };

                switch (State)
                {
                    //se pueden hacer calculos para almacenar en la BD
                    case EntityState.Added:
                        PurchasesRepository.Add(PurchasesDataModel);
                        message = "Compra registrada";
                        break;
                    case EntityState.Modified:
                        PurchasesRepository.Edit(PurchasesDataModel);
                        message = "Datos actualizados";
                        break;
                    case EntityState.Deleted:
                        PurchasesRepository.Remove(IdComp);
                        message = "Compra eliminada";
                        break;
                }

            }
            catch (Exception ex)
            {
                if (ex is SqlException SqlEx && SqlEx.Number == 2627)
                {
                    message = "Compra ya registrada";
                }
                else
                {
                    message = ex.ToString();
                }
            }
            return message;
        }

        public List<PurchasesModel> GetAll()
        {
            var PurchasesDataModel = PurchasesRepository.GetAll();
            listPurchases = new List<PurchasesModel>();
            foreach (TblPurchases item in PurchasesDataModel)
            {
                listPurchases.Add(new PurchasesModel
                {
                    IdComp = item.IdComp,
                    IdProd_Comp = item.IdProd_Comp,
                    Comp_Date = item.Comp_Date,
                    Comp_Cant = item.Comp_Cant
                });
            }
            return listPurchases;
        }


        //recupera datos de dos tablas INNER JOIN
        public List<PurchasesModel> PURPRO()
        {
            var PurchasesDataModel2 = PurchasesRepository.PURPRO();
            listPurchases2 = new List<PurchasesModel>();
            foreach (TblPurchases item in PurchasesDataModel2)
            {
                listPurchases2.Add(new PurchasesModel
                {
                    IdComp = item.IdComp,
                    IdProd_Comp = item.IdProd_Comp,
                    Prod_Cod = item.Prod_Cod.Trim(),
                    Prod_Name = item.Prod_Name.Trim(),
                    Comp_Date = item.Comp_Date,
                    Comp_Cant = item.Comp_Cant                    
                });
            }
            return listPurchases2;
        }

        public IEnumerable<PurchasesModel> FindByCed(string filter)
        {
             return listPurchases2.FindAll(e => e.Prod_Name.ToUpper().Contains(filter.ToUpper()) || e.Prod_Cod.ToUpper().Contains(filter.ToUpper()));
        }

        public void Dispose()
        {
        }
    }
}
