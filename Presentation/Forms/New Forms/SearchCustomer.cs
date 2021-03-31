using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Forms.New_Forms
{
    public partial class SearchCustomer : Form
    {
        private readonly CustomersModel customer = new CustomersModel();
        public SearchCustomer()
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
        }

        private void BtnSearchDataCusto_Click(object sender, EventArgs e)
        {
            if (customer.FindCustomerBill(txtSearchDataCusto.Text).Count() == 1)
            {
                dataCustoBill.DataSource = customer.FindCustomerBill(txtSearchDataCusto.Text);
                //se localiza el formulario buscandolo entre los forms abiertos 
                Form fnb = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewBill);

                if (fnb != null)
                {
                    if (fnb.WindowState == FormWindowState.Minimized)
                    {
                        fnb.WindowState = FormWindowState.Normal;
                    }
                    //si la instancia existe la pongo en primer plano
                    fnb.BringToFront();
                    return;
                }
                //sino existe la instancia se crea una nueva
                NewBill NB = new NewBill();
                NB.Show();
                NB.txtIdCustoBill.Text = dataCustoBill.CurrentRow.Cells[0].Value.ToString();
                NB.txtNameCustoBill.Text = dataCustoBill.CurrentRow.Cells[1].Value.ToString();
                NB.txtPhoneCustoBill.Text = dataCustoBill.CurrentRow.Cells[4].Value.ToString();
                NB.txtDateCustoBill.Text = DateTime.Now.ToString();
                NB.txtAddressCustoBill.Text = dataCustoBill.CurrentRow.Cells[3].Value.ToString();
                NB.txtRucCustoBill.Text = dataCustoBill.CurrentRow.Cells[2].Value.ToString();
                //NB.TxtPrecioBill.Text = "Por Mayor";
                Close();
                NB.Show();
                //NC.FormClosed += new FormClosedEventHandler(NewCustomers_FormClosed);

            }
            else
            {
                int b = customer.FindCustomerBill(txtSearchDataCusto.Text).Count();
                MessageBox.Show("Cantidad de archivos encontrados:" + b);
            }            
        }

        //Grag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void upBarCli_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            txtSearchDataCusto.Clear();
            Close();
        }
    }
}
