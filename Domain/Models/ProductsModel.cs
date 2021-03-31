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
    public class ProductsModel
    {
        private int IdProd;
        private string ProdCod;
        private string ProdName;
        private float ProdPrMay;
        private float ProdPrMen;
        private int ProdStock;

        private readonly IProductsRepository ProductsRepository;

        public EntityState State { private get; set; }

        private List<ProductsModel> listProducts;

        //PROPIEDADDES/MODELO DE VISTA/VALIDACIONES
        public int IdProdMod { get => IdProd; set => IdProd = value; }

        [Required(ErrorMessage = "Debe ingresar un código de producto")]
        [RegularExpression("^[0-9a-zA-ZäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙñÑ ]+$", ErrorMessage = "Código no debe tener caracteres especiales")]
        [StringLength(maximumLength: 10, MinimumLength = 3, ErrorMessage = "Código debe tener mínimo 3 dígitos")]
        public string ProdCodMod { get => ProdCod; set => ProdCod = value; }

        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [RegularExpression("^[0-9a-zA-ZäÄëËïÏöÖüÜáéíóúáéíóúÁÉÍÓÚÂÊÎÔÛâêîôûàèìòùÀÈÌÒÙñÑ/ ]+$", ErrorMessage = "Nombre solo permite caracter /")]
        public string ProdNameMod { get => ProdName; set => ProdName = value; }

        [Required(ErrorMessage = "Debe ingresar precio al por mayor")]
        [RegularExpression("([0-9,]+)", ErrorMessage = "EL decimal debe estar separado por (,) may punto ej: 2,3")]        
        public float ProdPrMayMod { get => ProdPrMay; set => ProdPrMay = value; }

        [Required(ErrorMessage = "Debe ingresar precio al por menor")]
        [RegularExpression("([0-9,]+)", ErrorMessage = "EL decimal debe estar separado por (,) men punto ej: 2,3")]
        public float ProdPrMenMod { get => ProdPrMen; set => ProdPrMen = value; }

        [Required(ErrorMessage = "Debe ingresar la cantidad")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Cantidad debe ser solo números")]
        public int ProdStockMod { get => ProdStock; set => ProdStock = value; }

        //Constructor
        public ProductsModel()
        {
            ProductsRepository = new ProductsRepository();
        }

        public string SaveChanges()
        {
            string message = null;

            try
            {
                var productsDataModel = new TblProducts
                {
                    IdProd = IdProd,
                    ProdCod = ProdCod,
                    ProdName = ProdName,
                    ProdPrMay = ProdPrMay,
                    ProdPrMen = ProdPrMen,
                    ProdStock = ProdStock
                };

                switch (State)
                {
                    //se pueden hacer calculos para almacenar en la BD
                    case EntityState.Added:
                        ProductsRepository.Add(productsDataModel);
                        message = "Producto registrado";
                        break;
                    case EntityState.Modified:
                        ProductsRepository.Edit(productsDataModel);
                        message = "Producto actualizados";
                        break;
                    case EntityState.Deleted:
                        ProductsRepository.Remove(IdProd);
                        message = "Producto eliminado";
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

        public List<ProductsModel> GetAll()
        {
            var productsDataModel = ProductsRepository.GetAll();
            listProducts = new List<ProductsModel>();
            foreach (TblProducts item in productsDataModel)
            {
                listProducts.Add(new ProductsModel
                {
                    IdProd = item.IdProd,
                    ProdCod = item.ProdCod.Trim(),
                    ProdName = item.ProdName.Trim(),
                    ProdPrMay = item.ProdPrMay,
                    ProdPrMen = item.ProdPrMen,
                    ProdStock = item.ProdStock
                }); 
            }
            return listProducts;
        }

        public IEnumerable<ProductsModel> FindByCed(string filter)
        {
            return listProducts.FindAll(e => e.ProdCod.ToUpper().Contains(filter.ToUpper()) || e.ProdName.ToUpper().Contains(filter.ToUpper()));
        }

        public IEnumerable<ProductsModel> FindProdBill(string filter)
        {
            return GetAll().FindAll(e => e.ProdCod.ToUpper().Contains(filter.ToUpper()));
        }

        public void Dispose()
        {
        }
    }
}
