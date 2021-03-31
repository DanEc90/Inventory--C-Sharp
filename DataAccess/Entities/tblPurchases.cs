using System;

namespace DataAccess.Entities
{
    public class TblPurchases
    {        
        public int IdComp { set; get; }
        public int IdProd_Comp { set; get; }
        public DateTime Comp_Date { set; get; }
        public int Comp_Cant { set; get; }
        public string Prod_Name { set; get; }
        public string Prod_Cod { set; get; }
    }
}
