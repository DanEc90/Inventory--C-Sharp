using Domain.Models;
using Domain.ValueObjects;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Forms.New_Forms
{
    public partial class NewProduct : Form
    {
        private readonly ProductsModel product = new ProductsModel();
        public NewProduct()
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            //MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private void GbPrice_Paint(object sender, PaintEventArgs e)
        {
            Graphics gfx = e.Graphics;
            Pen p = new Pen(Color.FromArgb(112, 146, 190), 2);
            gfx.DrawLine(p, 0, 8, 0, e.ClipRectangle.Height - 1);
            gfx.DrawLine(p, 0, 9, 8, 9);
            gfx.DrawLine(p, 54, 9, e.ClipRectangle.Width - 2, 9);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, 8, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2);
            gfx.DrawLine(p, e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2, 0, e.ClipRectangle.Height - 2);
        }

        private void Restart()
        {
            txtIdPro.Clear();
            txtCodPro.Clear();
            txtNamePro.Clear();
            txtMayPro.Clear();
            txtMenPro.Clear();
            txtStockPro.Clear();            
            Close();
        }

        private void BtnsaveProduct_Click(object sender, EventArgs e)
        {
            
            product.ProdCodMod = txtCodPro.Text;
            product.ProdNameMod = txtNamePro.Text;
            if (txtIdPro.Text == "")
            {
                product.State = EntityState.Added;
            }
            else
            {
                product.State = EntityState.Modified;
            }

            bool valid = new Helps.DataValidation(product).Validate();

            if (valid == true)
            {

                if (txtMayPro.Text == "")
                {
                    MessageBox.Show("Ingrese el precio al por mayor del producto");
                }
                else
                {
                    if (txtMenPro.Text == "")
                    {
                        MessageBox.Show("Ingrese el precio al por menor del producto");
                    }
                    else
                    {
                        product.ProdPrMayMod = float.Parse(txtMayPro.Text.Trim());
                        product.ProdPrMenMod = float.Parse(txtMenPro.Text.Trim());
                        product.ProdStockMod = Convert.ToInt32(txtStockPro.Text);

                        string result = product.SaveChanges();
                        MessageBox.Show(result);
                        Restart();
                        Close();
                    }
                }
            }                               
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnexitProduct_Click(object sender, EventArgs e)
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
    }
}
