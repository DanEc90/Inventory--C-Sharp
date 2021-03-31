using Presentation.Forms.New_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class FormSales : Form
    {
        public FormSales()
        {
            InitializeComponent();
        }

        private void NewBill_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form fnsc = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is SearchCustomer);

            if (fnsc != null)
            {
                if (fnsc.WindowState == FormWindowState.Minimized)
                {
                    fnsc.WindowState = FormWindowState.Normal;
                }
                //si la instancia existe la pongo en primer plano
                fnsc.BringToFront();
                return;
            }
            //sino existe la instancia se crea una nueva
            SearchCustomer fnscd = new SearchCustomer();
            fnscd.Show();            
        }
    }
}
