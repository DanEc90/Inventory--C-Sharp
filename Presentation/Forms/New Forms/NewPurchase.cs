using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Domain.Models;
using Domain.ValueObjects;

namespace Presentation.Forms.New_Forms
{
    public partial class NewPurchase : Form
    {
        private readonly PurchasesModel purchase = new PurchasesModel();
        public NewPurchase()
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
        }

        private void BtnsaveComp_Click(object sender, EventArgs e)
        {
            if(txtCantComp.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad");
            }
            else
            {
                if (Convert.ToInt32(txtCantComp.Text) < 1)
                {
                    MessageBox.Show("Ingrese un cantidad mayor a 0");
                }
                else
                {
                    purchase.State = EntityState.Added;
                    purchase.IdProd_CompMod = Convert.ToInt32(txtIdProd_Comp.Text);
                    purchase.Prod_CodeMod = txtCodProdComp.Text;
                    purchase.Prod_NameMod = txtNameProdComp.Text;
                    purchase.Comp_DateMod = Convert.ToDateTime(txtDateComp.Text);
                    purchase.Comp_CantMod = Convert.ToInt32(txtCantComp.Text);

                    bool valid = new Helps.DataValidation(purchase).Validate();

                    if (valid == true)
                    {
                        string result = purchase.SaveChanges();
                        MessageBox.Show(result);
                        Restart();
                        Close();
                    }
                }                
            }            
        }

        private void Restart()
        {
            txtIdProd_Comp.Clear();
            txtCodProdComp.Clear();
            txtNameProdComp.Clear();
            txtDateComp.Clear();
            txtCantComp.Clear();
            Close();
        }

        private void BtnexitComp_Click(object sender, EventArgs e)
        {
            Restart();
        }

        //Grag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void UpBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnEditComp_Click(object sender, EventArgs e)
        {
            if (txtCantComp.Text == "")
            {
                MessageBox.Show("Ingrese la cantidad");
            }
            else
            {
                if (Convert.ToInt32(txtCantComp.Text) < 1)
                {
                    MessageBox.Show("Ingrese un cantidad mayor a 0");
                }
                else
                {
                    purchase.State = EntityState.Modified;
                    purchase.IdCompMod = Convert.ToInt32(txtIdComp.Text);
                    purchase.Prod_CodeMod = txtCodProdComp.Text;
                    purchase.Prod_NameMod = txtNameProdComp.Text;
                    purchase.Comp_DateMod = Convert.ToDateTime(txtDateComp.Text);
                    purchase.Comp_CantMod = Convert.ToInt32(txtCantComp.Text);

                    bool valid = new Helps.DataValidation(purchase).Validate();

                    if (valid == true)
                    {
                        string result = purchase.SaveChanges();
                        MessageBox.Show(result);
                        Restart();
                        Close();
                    }
                }
            }
        }
    }
}
