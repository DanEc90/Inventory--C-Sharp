using Domain.Models;
using Domain.ValueObjects;
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
    public partial class FormProducts : Form
    {
        private readonly ProductsModel product = new ProductsModel();
        public FormProducts()
        {
            InitializeComponent();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            ListProducts();
        }

        public void ListProducts()
        {
            try
            {
                dataProducts.DefaultCellStyle.Font = new Font("Yu Gothic UI", 9);
                dataProducts.DataSource = product.GetAll();
                dataProducts.ReadOnly = true;
                dataProducts.Columns[0].HeaderText = "IdProd";
                dataProducts.Columns[0].Visible = false;
                dataProducts.Columns[1].HeaderText = "Código";
                dataProducts.Columns[2].HeaderText = "Nombre";
                dataProducts.Columns[3].HeaderText = "Precio por Mayor $";
                dataProducts.Columns[4].HeaderText = "Precio por Menor $";
                dataProducts.Columns[5].HeaderText = "Cantidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NewProducts_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form fnup = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewProduct);

            if (fnup != null)
            {
                if (fnup.WindowState == FormWindowState.Minimized)
                {
                    fnup.WindowState = FormWindowState.Normal;
                }
                //si la instancia existe la pongo en primer plano
                fnup.BringToFront();
                return;
            }
            //sino existe la instancia se crea una nueva
            NewProduct NP = new NewProduct();
            NP.Show();
            NP.FormClosed += new FormClosedEventHandler(NewProduct_FormClosed);
        }

        private void NewProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListProducts();
        }

        private void EditProduct_Click(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count > 0)
            {
                //se localiza el formulario buscandolo entre los forms abiertos 
                Form fnup = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewProduct);

                if (fnup != null)
                {
                    if (fnup.WindowState == FormWindowState.Minimized)
                    {
                        fnup.WindowState = FormWindowState.Normal;
                    }
                    //si la instancia existe la pongo en primer plano
                    fnup.BringToFront();
                    return;
                }
                //sino existe la instancia se crea una nueva
                NewProduct NP = new NewProduct();               
                NP.txtIdPro.Text = (dataProducts.CurrentRow.Cells[0].Value.ToString());
                NP.txtCodPro.Text = dataProducts.CurrentRow.Cells[1].Value.ToString();
                NP.txtNamePro.Text = dataProducts.CurrentRow.Cells[2].Value.ToString();
                NP.txtMayPro.Text = dataProducts.CurrentRow.Cells[3].Value.ToString();
                NP.txtMenPro.Text = dataProducts.CurrentRow.Cells[4].Value.ToString();
                NP.txtStockPro.Text = dataProducts.CurrentRow.Cells[5].Value.ToString();
                NP.Show();
                NP.FormClosed += new FormClosedEventHandler(NewProduct_FormClosed);

            }
            else
            {
                MessageBox.Show("Seleccione el producto a editar");
            }
        }

        private void DelProduct_Click(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count > 0)
            {
                DialogResult deluser = MessageBox.Show("Eliminar los datos del producto: " + dataProducts.CurrentRow.Cells[1].Value.ToString() + "? ", "Eliminar datos", MessageBoxButtons.YesNo);
                if (deluser == DialogResult.Yes)
                {
                    product.State = EntityState.Deleted;
                    product.IdProdMod = Convert.ToInt32(dataProducts.CurrentRow.Cells[0].Value);

                    string result = product.SaveChanges();
                    MessageBox.Show(result);
                    ListProducts();
                }
            }
            else
            {
                MessageBox.Show("Seleccione el producto a eliminar");
            }
        }

        private void TxtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            dataProducts.DataSource = product.FindByCed(txtSearchProducts.Text);
        }
    }
}
