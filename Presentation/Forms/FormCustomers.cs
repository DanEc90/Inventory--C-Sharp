using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Domain.Models;
using Domain.ValueObjects;
using Presentation.Forms.New_Forms;

namespace Presentation.Forms
{
    public partial class FormCustomers : Form
    {
        private readonly CustomersModel customer = new CustomersModel();
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            ListCustomers();
        }

        public void ListCustomers()
        {
            try
            {
                dataCusto.DefaultCellStyle.Font = new Font("Yu Gothic UI", 9);
                dataCusto.DataSource = customer.GetAll();
                dataCusto.ReadOnly = true;
                dataCusto.Columns[0].HeaderText = "IdCli";
                dataCusto.Columns[0].Visible = false;
                dataCusto.Columns[1].HeaderText = "Nombre";
                dataCusto.Columns[2].HeaderText = "Cédula / R.U.C.";
                dataCusto.Columns[3].HeaderText = "Dirección";
                dataCusto.Columns[4].HeaderText = "Teléfono";                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NewCusto_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form fnc = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewCustomers);

            if (fnc != null)
            {
                if (fnc.WindowState == FormWindowState.Minimized)
                {
                    fnc.WindowState = FormWindowState.Normal;
                }
                //si la instancia existe la pongo en primer plano
                fnc.BringToFront();
                return;
            }
            //sino existe la instancia se crea una nueva
            NewCustomers NC = new NewCustomers();
            NC.Show();
            NC.FormClosed += new FormClosedEventHandler(NewCustomers_FormClosed);
        }

        private void NewCustomers_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListCustomers();
        }

        private void EditCusto_Click(object sender, EventArgs e)
        {
            if (dataCusto.SelectedRows.Count > 0)
            {
                //se localiza el formulario buscandolo entre los forms abiertos 
                Form fnc = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewCustomers);

                if (fnc != null)
                {
                    if (fnc.WindowState == FormWindowState.Minimized)
                    {
                        fnc.WindowState = FormWindowState.Normal;
                    }
                    //si la instancia existe la pongo en primer plano
                    fnc.BringToFront();
                    return;
                }
                //sino existe la instancia se crea una nueva
                NewCustomers NC = new NewCustomers();                
                NC.txtCustoId.Text = dataCusto.CurrentRow.Cells[0].Value.ToString();
                NC.txtCustoName.Text = dataCusto.CurrentRow.Cells[1].Value.ToString();
                NC.txtCustoCed.Text = dataCusto.CurrentRow.Cells[2].Value.ToString();
                NC.txtCustoAddress.Text = dataCusto.CurrentRow.Cells[3].Value.ToString();
                NC.txtCustoPhone.Text = dataCusto.CurrentRow.Cells[4].Value.ToString();
                NC.Show();
                NC.FormClosed += new FormClosedEventHandler(NewCustomers_FormClosed);

            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void DelCusto_Click(object sender, EventArgs e)
        {
            if (dataCusto.SelectedRows.Count > 0)
            {

                DialogResult delcusto = MessageBox.Show("Eliminar los datos del cliente: " + dataCusto.CurrentRow.Cells[1].Value.ToString() + "? ", "Eliminar datos", MessageBoxButtons.YesNo);
                if (delcusto == DialogResult.Yes)
                {
                    customer.State = EntityState.Deleted;
                    customer.IdCustoMod = Convert.ToInt32(dataCusto.CurrentRow.Cells[0].Value);

                    string result = customer.SaveChanges();
                    MessageBox.Show(result);
                    ListCustomers();
                }
            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void TxtSearchCusto_TextChanged(object sender, EventArgs e)
        {
            dataCusto.DataSource = customer.FindByCed(txtSearchCusto.Text);
        }
    }
}
