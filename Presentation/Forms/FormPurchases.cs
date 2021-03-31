using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Domain.Models;
using Domain.ValueObjects;
using Presentation.Forms.New_Forms;

namespace Presentation.Forms
{
    public partial class FormPurchases : Form
    {
        private readonly PurchasesModel purchase = new PurchasesModel();
        
        public FormPurchases()
        {
            InitializeComponent();
        }

        private void FormPurchases_Load(object sender, EventArgs e)
        {
            ListPurchases();
        }

        public void ListPurchases()
        {
            try
            {               
                dataPur.DefaultCellStyle.Font = new Font("Yu Gothic UI", 9);                
                dataPur.DataSource = purchase.PURPRO();          
                dataPur.ReadOnly = true;
                dataPur.Columns[0].HeaderText = "IdCompra";
                dataPur.Columns[0].Visible = false;
                dataPur.Columns[1].HeaderText = "IdProd_Compra";
                dataPur.Columns[1].Visible = false;
                dataPur.Columns[2].HeaderText = "Código";
                dataPur.Columns[3].HeaderText = "Nombre";
                dataPur.Columns[4].HeaderText = "Fecha";               
                dataPur.Columns[5].HeaderText = "Cantidad";
                //dataPur.Columns[4].HeadeCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NewPurchase_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListPurchases();
        }

        private void NewPur_Click(object sender, EventArgs e)
        {
            if (dataPur.SelectedRows.Count > 0)
            {
                //se localiza el formulario buscandolo entre los forms abiertos 
                Form fnpur = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewPurchase);

                if (fnpur != null)
                {
                    if (fnpur.WindowState == FormWindowState.Minimized)
                    {
                        fnpur.WindowState = FormWindowState.Normal;
                    }
                    //si la instancia existe la pongo en primer plano
                    fnpur.BringToFront();
                    return;
                }
                //sino existe la instancia se crea una nueva
                NewPurchase NPUR = new NewPurchase();                
                NPUR.BtnsaveComp.Visible = true;
                NPUR.txtIdProd_Comp.Text = dataPur.CurrentRow.Cells[1].Value.ToString();
                NPUR.txtCodProdComp.Text = dataPur.CurrentRow.Cells[2].Value.ToString();
                NPUR.txtNameProdComp.Text = dataPur.CurrentRow.Cells[3].Value.ToString();
                NPUR.txtDateComp.Text = DateTime.Now.ToString();
                NPUR.Show();
                NPUR.FormClosed += new FormClosedEventHandler(NewPurchase_FormClosed);

            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void TxtSearchPur_TextChanged(object sender, EventArgs e)
        {
            dataPur.DataSource = purchase.FindByCed(TxtSearchPur.Text);
        }

        private void EditPur_Click(object sender, EventArgs e)
        {
            if (dataPur.SelectedRows.Count > 0)
            {
                //se localiza el formulario buscandolo entre los forms abiertos 
                Form fnpur = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewPurchase);

                if (fnpur != null)
                {
                    if (fnpur.WindowState == FormWindowState.Minimized)
                    {
                        fnpur.WindowState = FormWindowState.Normal;
                    }
                    //si la instancia existe la pongo en primer plano
                    fnpur.BringToFront();
                    return;
                }
                //sino existe la instancia se crea una nueva
                NewPurchase NPUR = new NewPurchase();
                
                NPUR.BtnEditComp.Visible = true;
                NPUR.txtIdComp.Text = dataPur.CurrentRow.Cells[0].Value.ToString();
                NPUR.txtCodProdComp.Text = dataPur.CurrentRow.Cells[2].Value.ToString();
                NPUR.txtNameProdComp.Text = dataPur.CurrentRow.Cells[3].Value.ToString();
                NPUR.txtDateComp.Text = dataPur.CurrentRow.Cells[4].Value.ToString();
                NPUR.txtCantComp.Text = dataPur.CurrentRow.Cells[5].Value.ToString();
                NPUR.Show();
                NPUR.FormClosed += new FormClosedEventHandler(NewPurchase_FormClosed);

            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void DelPur_Click(object sender, EventArgs e)
        {
            if (dataPur.SelectedRows.Count > 0)
            {

                DialogResult deluser = MessageBox.Show("Eliminar los datos de la compra " + dataPur.CurrentRow.Cells[3].Value.ToString() + "? ", "Eliminar datos", MessageBoxButtons.YesNo);
                if (deluser == DialogResult.Yes)
                {
                    purchase.State = EntityState.Deleted;
                    purchase.IdCompMod = Convert.ToInt32(dataPur.CurrentRow.Cells[0].Value);

                    string result = purchase.SaveChanges();
                    MessageBox.Show(result);
                    ListPurchases();
                }
            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }
    }
}
