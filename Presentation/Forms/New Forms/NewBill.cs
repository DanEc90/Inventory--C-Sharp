using Domain.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Forms.New_Forms
{
    public partial class NewBill : Form
    {
        private readonly ProductsModel product = new ProductsModel();
        private int inscount;
        readonly string[,] allprodbill = new string[15, 4];
        private readonly bool act1 = false;
        private bool act2 = false;
        private bool act3 = false;
        private bool act4 = false;
        private bool act5 = false;
        private bool act6 = false;
        private bool act7 = false;
        private bool act8 = false;
        private bool act9 = false;
        private bool act10 = false;
        private bool act11 = false;
        private bool act12 = false;
        private bool act13 = false;
        private bool act14 = false;
        private bool act15 = false;

        public NewBill()
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;            
        }
        
        //Grag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelUpBar_MouseDown(object sender, MouseEventArgs e)
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

        //Cuando se ingresa una cantidad, multiplica y pone un valor en campo valor total //**************************************************************
        private void TxtCant1ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else { 
                if (product.FindProdBill(TxtCod1ProdBill.Text).Count() == 1)
                {                    
                    if (TxtCant1ProdBill.Text != "")
                    {
                        if (TxtCant1ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant1ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT1ProdBill.Text = (Convert.ToInt32(TxtCant1ProdBill.Text) * (float.Parse(TxtVU1ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant1ProdBill.Focus();                        
                    }                    
                }
            }
        }

        private void TxtCant2ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod2ProdBill.Text).Count() == 1)
                {
                    if (TxtCant2ProdBill.Text != "")
                    {
                        if (TxtCant2ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant2ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT2ProdBill.Text = (Convert.ToInt32(TxtCant2ProdBill.Text) * (float.Parse(TxtVU2ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant2ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant3ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod3ProdBill.Text).Count() == 1)
                {
                    if (TxtCant3ProdBill.Text != "")
                    {
                        if (TxtCant3ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant3ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT3ProdBill.Text = (Convert.ToInt32(TxtCant3ProdBill.Text) * (float.Parse(TxtVU3ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant3ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant4ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod4ProdBill.Text).Count() == 1)
                {
                    if (TxtCant4ProdBill.Text != "")
                    {
                        if (TxtCant4ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant4ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT4ProdBill.Text = (Convert.ToInt32(TxtCant4ProdBill.Text) * (float.Parse(TxtVU4ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant4ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant5ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod5ProdBill.Text).Count() == 1)
                {
                    if (TxtCant5ProdBill.Text != "")
                    {
                        if (TxtCant5ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant5ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT5ProdBill.Text = (Convert.ToInt32(TxtCant5ProdBill.Text) * (float.Parse(TxtVU5ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant5ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant6ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod6ProdBill.Text).Count() == 1)
                {
                    if (TxtCant6ProdBill.Text != "")
                    {
                        if (TxtCant6ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant6ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT6ProdBill.Text = (Convert.ToInt32(TxtCant6ProdBill.Text) * (float.Parse(TxtVU6ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant6ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant7ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod7ProdBill.Text).Count() == 1)
                {
                    if (TxtCant7ProdBill.Text != "")
                    {
                        if (TxtCant7ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant7ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT7ProdBill.Text = (Convert.ToInt32(TxtCant7ProdBill.Text) * (float.Parse(TxtVU7ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant7ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant8ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod8ProdBill.Text).Count() == 1)
                {
                    if (TxtCant8ProdBill.Text != "")
                    {
                        if (TxtCant8ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant8ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT8ProdBill.Text = (Convert.ToInt32(TxtCant8ProdBill.Text) * (float.Parse(TxtVU8ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant8ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant9ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod9ProdBill.Text).Count() == 1)
                {
                    if (TxtCant9ProdBill.Text != "")
                    {
                        if (TxtCant9ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant9ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT9ProdBill.Text = (Convert.ToInt32(TxtCant9ProdBill.Text) * (float.Parse(TxtVU9ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant9ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant10ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod10ProdBill.Text).Count() == 1)
                {
                    if (TxtCant10ProdBill.Text != "")
                    {
                        if (TxtCant10ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant10ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT10ProdBill.Text = (Convert.ToInt32(TxtCant10ProdBill.Text) * (float.Parse(TxtVU10ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant10ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant11ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod11ProdBill.Text).Count() == 1)
                {
                    if (TxtCant11ProdBill.Text != "")
                    {
                        if (TxtCant11ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant11ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT11ProdBill.Text = (Convert.ToInt32(TxtCant11ProdBill.Text) * (float.Parse(TxtVU11ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant11ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant12ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod12ProdBill.Text).Count() == 1)
                {
                    if (TxtCant12ProdBill.Text != "")
                    {
                        if (TxtCant12ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant12ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT12ProdBill.Text = (Convert.ToInt32(TxtCant12ProdBill.Text) * (float.Parse(TxtVU12ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant12ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant13ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod13ProdBill.Text).Count() == 1)
                {
                    if (TxtCant13ProdBill.Text != "")
                    {
                        if (TxtCant13ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant13ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT13ProdBill.Text = (Convert.ToInt32(TxtCant13ProdBill.Text) * (float.Parse(TxtVU13ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant13ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant14ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod14ProdBill.Text).Count() == 1)
                {
                    if (TxtCant14ProdBill.Text != "")
                    {
                        if (TxtCant14ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant14ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT14ProdBill.Text = (Convert.ToInt32(TxtCant14ProdBill.Text) * (float.Parse(TxtVU14ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant14ProdBill.Focus();
                    }
                }
            }
        }

        private void TxtCant15ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (product.FindProdBill(TxtCod15ProdBill.Text).Count() == 1)
                {
                    if (TxtCant15ProdBill.Text != "")
                    {
                        if (TxtCant15ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                        {
                            TxtPrecioBill.Text = "Por Menor";
                            TxtPrecioBill.Text = "Por Mayor";
                        }
                        if (TxtCant15ProdBill.Modified == true && TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                        {
                            TxtPrecioBill.Text = "Por Mayor";
                            TxtPrecioBill.Text = "Por Menor";
                        }

                        TxtVT15ProdBill.Text = (Convert.ToInt32(TxtCant15ProdBill.Text) * (float.Parse(TxtVU15ProdBill.Text))).ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Ingrese una cantidad");                        
                        TxtCant15ProdBill.Focus();
                    }
                }
            }
        }

        //Busca por codigo un producto cuando pierde el foco //**************************************************************
        private void TxtCod1ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod1ProdBill.Text).Count() == 1)
            {
                dataProd1Bill.DataSource = product.FindProdBill(TxtCod1ProdBill.Text);
                TxtId1ProdBill.Text = dataProd1Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod1ProdBill.Text = dataProd1Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName1ProdBill.Text = dataProd1Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd1.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU1ProdBill.Text = dataProd1Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU1ProdBill.Text = dataProd1Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }                  
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod1ProdBill.Clear();
                TxtCod1ProdBill.Focus();
            }                      
        }

        private void TxtCod2ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod2ProdBill.Text).Count() == 1)
            {
                dataProd2Bill.DataSource = product.FindProdBill(TxtCod2ProdBill.Text);
                TxtId2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd2.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod2ProdBill.Clear();
                TxtCod2ProdBill.Focus();
            }
        }

        private void TxtCod3ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod3ProdBill.Text).Count() == 1)
            {
                dataProd3Bill.DataSource = product.FindProdBill(TxtCod3ProdBill.Text);
                TxtId3ProdBill.Text = dataProd3Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod3ProdBill.Text = dataProd3Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName3ProdBill.Text = dataProd3Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd3.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU3ProdBill.Text = dataProd3Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU3ProdBill.Text = dataProd3Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod3ProdBill.Clear();
                TxtCod3ProdBill.Focus();
            }
        }

        private void TxtCod4ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod4ProdBill.Text).Count() == 1)
            {
                dataProd4Bill.DataSource = product.FindProdBill(TxtCod4ProdBill.Text);
                TxtId4ProdBill.Text = dataProd4Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod4ProdBill.Text = dataProd4Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName4ProdBill.Text = dataProd4Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd4.Visible = true;
                inscount += 1;//otra forma de sumar
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU4ProdBill.Text = dataProd4Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU4ProdBill.Text = dataProd4Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod4ProdBill.Clear();
                TxtCod4ProdBill.Focus();
            }
        }

        private void TxtCod5ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod5ProdBill.Text).Count() == 1)
            {
                dataProd5Bill.DataSource = product.FindProdBill(TxtCod5ProdBill.Text);
                TxtId5ProdBill.Text = dataProd5Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod5ProdBill.Text = dataProd5Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName5ProdBill.Text = dataProd5Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd5.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU5ProdBill.Text = dataProd5Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU5ProdBill.Text = dataProd5Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod5ProdBill.Clear();
                TxtCod5ProdBill.Focus();
            }
        }

        private void TxtCod6ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod6ProdBill.Text).Count() == 1)
            {
                dataProd6Bill.DataSource = product.FindProdBill(TxtCod6ProdBill.Text);
                TxtId6ProdBill.Text = dataProd6Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod6ProdBill.Text = dataProd6Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName6ProdBill.Text = dataProd6Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd6.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU6ProdBill.Text = dataProd6Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU6ProdBill.Text = dataProd6Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod6ProdBill.Clear();
                TxtCod6ProdBill.Focus();
            }
        }

        private void TxtCod7ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod2ProdBill.Text).Count() == 1)
            {
                dataProd7Bill.DataSource = product.FindProdBill(TxtCod7ProdBill.Text);
                TxtId7ProdBill.Text = dataProd7Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod7ProdBill.Text = dataProd7Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName7ProdBill.Text = dataProd7Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd7.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU7ProdBill.Text = dataProd7Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU7ProdBill.Text = dataProd7Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod7ProdBill.Clear();
                TxtCod7ProdBill.Focus();
            }
        }

        private void TxtCod8ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod8ProdBill.Text).Count() == 1)
            {
                dataProd8Bill.DataSource = product.FindProdBill(TxtCod8ProdBill.Text);
                TxtId8ProdBill.Text = dataProd8Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod8ProdBill.Text = dataProd8Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName8ProdBill.Text = dataProd8Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd8.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU8ProdBill.Text = dataProd8Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU8ProdBill.Text = dataProd8Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod8ProdBill.Clear();
                TxtCod8ProdBill.Focus();
            }
        }

        private void TxtCod9ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod9ProdBill.Text).Count() == 1)
            {
                dataProd9Bill.DataSource = product.FindProdBill(TxtCod9ProdBill.Text);
                TxtId9ProdBill.Text = dataProd9Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod9ProdBill.Text = dataProd9Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName9ProdBill.Text = dataProd9Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd9.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU9ProdBill.Text = dataProd9Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU9ProdBill.Text = dataProd9Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod9ProdBill.Clear();
                TxtCod9ProdBill.Focus();
            }
        }

        private void TxtCod10ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod10ProdBill.Text).Count() == 1)
            {
                dataProd10Bill.DataSource = product.FindProdBill(TxtCod10ProdBill.Text);
                TxtId10ProdBill.Text = dataProd10Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod10ProdBill.Text = dataProd10Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName10ProdBill.Text = dataProd10Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd10.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod10ProdBill.Clear();
                TxtCod10ProdBill.Focus();
            }
        }

        private void TxtCod11ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod11ProdBill.Text).Count() == 1)
            {
                dataProd11Bill.DataSource = product.FindProdBill(TxtCod11ProdBill.Text);
                TxtId11ProdBill.Text = dataProd11Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod11ProdBill.Text = dataProd11Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName11ProdBill.Text = dataProd11Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd11.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU11ProdBill.Text = dataProd11Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU11ProdBill.Text = dataProd11Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod11ProdBill.Clear();
                TxtCod11ProdBill.Focus();
            }
        }

        private void TxtCod12ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod12ProdBill.Text).Count() == 1)
            {
                dataProd12Bill.DataSource = product.FindProdBill(TxtCod12ProdBill.Text);
                TxtId12ProdBill.Text = dataProd12Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod12ProdBill.Text = dataProd12Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName12ProdBill.Text = dataProd12Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd12.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU12ProdBill.Text = dataProd12Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU12ProdBill.Text = dataProd12Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod12ProdBill.Clear();
                TxtCod12ProdBill.Focus();
            }
        }

        private void TxtCod13ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod13ProdBill.Text).Count() == 1)
            {
                dataProd13Bill.DataSource = product.FindProdBill(TxtCod13ProdBill.Text);
                TxtId13ProdBill.Text = dataProd13Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod13ProdBill.Text = dataProd13Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName13ProdBill.Text = dataProd13Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd13.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU13ProdBill.Text = dataProd13Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU13ProdBill.Text = dataProd13Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod13ProdBill.Clear();
                TxtCod13ProdBill.Focus();
            }
        }

        private void TxtCod14ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod14ProdBill.Text).Count() == 1)
            {
                dataProd14Bill.DataSource = product.FindProdBill(TxtCod14ProdBill.Text);
                TxtId14ProdBill.Text = dataProd14Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod14ProdBill.Text = dataProd14Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName14ProdBill.Text = dataProd14Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd14.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU14ProdBill.Text = dataProd14Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU14ProdBill.Text = dataProd14Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod14ProdBill.Clear();
                TxtCod14ProdBill.Focus();
            }
        }

        private void TxtCod15ProdBill_Leave(object sender, EventArgs e)
        {
            if (product.FindProdBill(TxtCod15ProdBill.Text).Count() == 1)
            {
                dataProd15Bill.DataSource = product.FindProdBill(TxtCod15ProdBill.Text);
                TxtId15ProdBill.Text = dataProd15Bill.CurrentRow.Cells[0].Value.ToString();
                TxtCod15ProdBill.Text = dataProd15Bill.CurrentRow.Cells[1].Value.ToString();
                TxtName15ProdBill.Text = dataProd15Bill.CurrentRow.Cells[2].Value.ToString();
                EraseProd15.Visible = true;
                inscount++;
                textBox1.Text = inscount.ToString();
                if (TxtPrecioBill.SelectedIndex.Equals(-1))
                {
                    //MessageBox.Show("Selecciones el tipo de venta");                    
                }
                else
                {
                    if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                    {
                        TxtVU15ProdBill.Text = dataProd15Bill.CurrentRow.Cells[3].Value.ToString();
                    }
                    else
                    {
                        TxtVU15ProdBill.Text = dataProd15Bill.CurrentRow.Cells[4].Value.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe el propducto");
                TxtCod15ProdBill.Clear();
                TxtCod15ProdBill.Focus();
            }
        }

        //Cuando cambia el valor unitario, multiplica la cantidad con el vu y lo asigna al valor total //**************************************************************
        private void TxtVU1ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant1ProdBill.Text != "")
            {                
                TxtVT1ProdBill.Text = ((Convert.ToInt32(TxtCant1ProdBill.Text)) * (float.Parse(TxtVU1ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant1ProdBill.Focus();
            }*/
        }

        private void TxtVU2ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant2ProdBill.Text != "")
            {
                TxtVT2ProdBill.Text = ((Convert.ToInt32(TxtCant2ProdBill.Text)) * (float.Parse(TxtVU2ProdBill.Text))).ToString();
            }
           /* else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant2ProdBill.Focus();
            }*/
        }

        private void TxtVU3ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant3ProdBill.Text != "")
            {
                TxtVT3ProdBill.Text = ((Convert.ToInt32(TxtCant3ProdBill.Text)) * (float.Parse(TxtVU3ProdBill.Text))).ToString();
            }
           /* else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant3ProdBill.Focus();
            }*/
        }

        private void TxtVU4ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant4ProdBill.Text != "")
            {
                TxtVT4ProdBill.Text = ((Convert.ToInt32(TxtCant4ProdBill.Text)) * (float.Parse(TxtVU4ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant4ProdBill.Focus();
            }*/
        }

        private void TxtVU5ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant5ProdBill.Text != "")
            {
                TxtVT5ProdBill.Text = ((Convert.ToInt32(TxtCant5ProdBill.Text)) * (float.Parse(TxtVU5ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant5ProdBill.Focus();
            }*/
        }

        private void TxtVU6ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant6ProdBill.Text != "")
            {
                TxtVT6ProdBill.Text = ((Convert.ToInt32(TxtCant6ProdBill.Text)) * (float.Parse(TxtVU6ProdBill.Text))).ToString();
            }
           /* else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant6ProdBill.Focus();
            }*/
        }

        private void TxtVU7ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant7ProdBill.Text != "")
            {
                TxtVT7ProdBill.Text = ((Convert.ToInt32(TxtCant7ProdBill.Text)) * (float.Parse(TxtVU7ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant7ProdBill.Focus();
            }*/
        }

        private void TxtVU8ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant8ProdBill.Text != "")
            {
                TxtVT8ProdBill.Text = ((Convert.ToInt32(TxtCant8ProdBill.Text)) * (float.Parse(TxtVU8ProdBill.Text))).ToString();
            }
           /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant8ProdBill.Focus();
            }*/
        }

        private void TxtVU9ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant9ProdBill.Text != "")
            {
                TxtVT9ProdBill.Text = ((Convert.ToInt32(TxtCant9ProdBill.Text)) * (float.Parse(TxtVU9ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant9ProdBill.Focus();
            }*/
        }

        private void TxtVU10ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant10ProdBill.Text != "")
            {
                TxtVT10ProdBill.Text = ((Convert.ToInt32(TxtCant10ProdBill.Text)) * (float.Parse(TxtVU10ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant10ProdBill.Focus();
            }*/
        }

        private void TxtVU11ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant11ProdBill.Text != "")
            {
                TxtVT11ProdBill.Text = ((Convert.ToInt32(TxtCant11ProdBill.Text)) * (float.Parse(TxtVU11ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant11ProdBill.Focus();
            }*/
        }

        private void TxtVU12ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant12ProdBill.Text != "")
            {
                TxtVT12ProdBill.Text = ((Convert.ToInt32(TxtCant12ProdBill.Text)) * (float.Parse(TxtVU12ProdBill.Text))).ToString();
            }
            /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant12ProdBill.Focus();
            }*/
        }

        private void TxtVU13ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant13ProdBill.Text != "")
            {
                TxtVT13ProdBill.Text = ((Convert.ToInt32(TxtCant13ProdBill.Text)) * (float.Parse(TxtVU13ProdBill.Text))).ToString();
            }
           /*else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant13ProdBill.Focus();
            }*/
        }

        private void TxtVU14ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant14ProdBill.Text != "")
            {
                TxtVT14ProdBill.Text = ((Convert.ToInt32(TxtCant14ProdBill.Text)) * (float.Parse(TxtVU14ProdBill.Text))).ToString();
            }
           /* else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant14ProdBill.Focus();
            }*/
        }

        private void TxtVU15ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtCant15ProdBill.Text != "")
            {
                TxtVT15ProdBill.Text = ((Convert.ToInt32(TxtCant15ProdBill.Text)) * (float.Parse(TxtVU15ProdBill.Text))).ToString();
            }
           /* else
            {
                MessageBox.Show("Ingrese una cantidad");
                TxtCant15ProdBill.Focus();
            }*/
        }

        //Cuando cambia el valor total, suma y asigna el subtotal //**************************************************************
        private void TxtVT1ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT1ProdBill.Text != "")
            {
                
                if (TxtSubtotBill.Text != "")
                {
                    
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT1ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT1ProdBill.Text))).ToString();
                }    
                
            }
            else
            {
                // MessageBox.Show("Ingrese una cantidad");
                TxtCant1ProdBill.Focus();
            }
        }

        private void TxtVT2ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT2ProdBill.Text != "")
            {                
                if (TxtSubtotBill.Text != "")
                {                    
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT2ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT2ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant2ProdBill.Focus();
            }
        }

        private void TxtVT3ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT3ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT3ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT3ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant3ProdBill.Focus();
            }
        }

        private void TxtVT4ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT4ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT4ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT4ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant4ProdBill.Focus();
            }
        }

        private void TxtVT5ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT5ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT5ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT5ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant5ProdBill.Focus();
            }
        }

        private void TxtVT6ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT6ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT6ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT6ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant6ProdBill.Focus();
            }
        }

        private void TxtVT7ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT7ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT7ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT7ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant7ProdBill.Focus();
            }
        }

        private void TxtVT8ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT8ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT8ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT8ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant8ProdBill.Focus();
            }
        }

        private void TxtVT9ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT9ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT9ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT9ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant9ProdBill.Focus();
            }
        }

        private void TxtVT10ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT10ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT10ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT10ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant10ProdBill.Focus();
            }
        }

        private void TxtVT11ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT11ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT11ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT11ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant11ProdBill.Focus();
            }
        }

        private void TxtVT12ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT12ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT12ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT12ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant12ProdBill.Focus();
            }
        }

        private void TxtVT13ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT13ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT13ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT13ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant13ProdBill.Focus();
            }
        }

        private void TxtVT14ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT14ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT14ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT14ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant14ProdBill.Focus();
            }
        }

        private void TxtVT15ProdBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtVT15ProdBill.Text != "")
            {
                if (TxtSubtotBill.Text != "")
                {
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT15ProdBill.Text))).ToString();
                }
                else
                {
                    TxtSubtotBill.Text = "0";
                    TxtSubtotBill.Text = ((float.Parse(TxtSubtotBill.Text)) + (float.Parse(TxtVT15ProdBill.Text))).ToString();
                }
            }
            else
            {
                //MessageBox.Show("Ingrese una cantidad");
                TxtCant15ProdBill.Focus();
            }
        }

        //Detecta si el tipo de venta cambia para cambiar los valores unitarios //**************************************************************
        private void TxtPrecioBill_TextChanged(object sender, EventArgs e)
        {
            TxtSubtotBill.Clear();
            if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
            {
                if (product.FindProdBill(TxtCod1ProdBill.Text).Count() == 1)
                {
                    TxtVU1ProdBill.Text = dataProd1Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod2ProdBill.Text).Count() == 1)
                {
                    TxtVU2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod3ProdBill.Text).Count() == 1)
                {
                    TxtVU3ProdBill.Text = dataProd3Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod4ProdBill.Text).Count() == 1)
                {
                    TxtVU4ProdBill.Text = dataProd4Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod5ProdBill.Text).Count() == 1)
                {
                    TxtVU5ProdBill.Text = dataProd5Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod6ProdBill.Text).Count() == 1)
                {
                    TxtVU6ProdBill.Text = dataProd6Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod7ProdBill.Text).Count() == 1)
                {
                    TxtVU7ProdBill.Text = dataProd7Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod8ProdBill.Text).Count() == 1)
                {
                    TxtVU8ProdBill.Text = dataProd8Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod9ProdBill.Text).Count() == 1)
                {
                    TxtVU9ProdBill.Text = dataProd9Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod10ProdBill.Text).Count() == 1)
                {
                    TxtVU10ProdBill.Text = dataProd10Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod11ProdBill.Text).Count() == 1)
                {
                    TxtVU11ProdBill.Text = dataProd11Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod12ProdBill.Text).Count() == 1)
                {
                    TxtVU12ProdBill.Text = dataProd12Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod13ProdBill.Text).Count() == 1)
                {
                    TxtVU13ProdBill.Text = dataProd13Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod14ProdBill.Text).Count() == 1)
                {
                    TxtVU14ProdBill.Text = dataProd14Bill.CurrentRow.Cells[3].Value.ToString();
                }
                if (product.FindProdBill(TxtCod15ProdBill.Text).Count() == 1)
                {
                    TxtVU15ProdBill.Text = dataProd15Bill.CurrentRow.Cells[3].Value.ToString();
                }
            }
            else
            {
                if (product.FindProdBill(TxtCod1ProdBill.Text).Count() == 1)
                {
                    TxtVU1ProdBill.Text = dataProd1Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod2ProdBill.Text).Count() == 1)
                {
                    TxtVU2ProdBill.Text = dataProd2Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod3ProdBill.Text).Count() == 1)
                {
                    TxtVU3ProdBill.Text = dataProd3Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod4ProdBill.Text).Count() == 1)
                {
                    TxtVU4ProdBill.Text = dataProd4Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod5ProdBill.Text).Count() == 1)
                {
                    TxtVU5ProdBill.Text = dataProd5Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod6ProdBill.Text).Count() == 1)
                {
                    TxtVU6ProdBill.Text = dataProd6Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod7ProdBill.Text).Count() == 1)
                {
                    TxtVU7ProdBill.Text = dataProd7Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod8ProdBill.Text).Count() == 1)
                {
                    TxtVU8ProdBill.Text = dataProd8Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod9ProdBill.Text).Count() == 1)
                {
                    TxtVU9ProdBill.Text = dataProd9Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod10ProdBill.Text).Count() == 1)
                {
                    TxtVU10ProdBill.Text = dataProd10Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod11ProdBill.Text).Count() == 1)
                {
                    TxtVU11ProdBill.Text = dataProd11Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod12ProdBill.Text).Count() == 1)
                {
                    TxtVU12ProdBill.Text = dataProd12Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod13ProdBill.Text).Count() == 1)
                {
                    TxtVU13ProdBill.Text = dataProd13Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod14ProdBill.Text).Count() == 1)
                {
                    TxtVU14ProdBill.Text = dataProd14Bill.CurrentRow.Cells[4].Value.ToString();
                }
                if (product.FindProdBill(TxtCod15ProdBill.Text).Count() == 1)
                {
                    TxtVU15ProdBill.Text = dataProd15Bill.CurrentRow.Cells[4].Value.ToString();
                }
            }
        }

        //Cuando cambia el valor subtotal, saca el iva //**************************************************************
        private void TxtSubtotBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtSubtotBill.Text != "")
            {
                TxtIvaBill.Refresh();
                TxtIvaBill.Text = Math.Round(float.Parse(TxtSubtotBill.Text) * 0.12, 2).ToString();
            }
            else
            {
                TxtIvaBill.Text = "";
            }
        }

        //Cuando cambia el valor iva, suma el total de la factura //**************************************************************
        private void TxtIvaBill_TextChanged(object sender, EventArgs e)
        {
            if (TxtIvaBill.Text != "")
            {
                TxtTotBill.Refresh();
                TxtTotBill.Text = Math.Round((float.Parse(TxtSubtotBill.Text) + float.Parse(TxtIvaBill.Text)), 2).ToString();
            }
            else
            {
                TxtTotBill.Text = "";
            }
        }

        //Botones para eliminar el producto de la factura //**************************************************************
        private void EraseProd1_Click(object sender, EventArgs e)
        {
            TxtId1ProdBill.Clear();            
            TxtCod1ProdBill.Clear();
            TxtName1ProdBill.Clear();
            
            TxtCant1ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU1ProdBill.Clear();
            TxtVT1ProdBill.Clear();            
            dataProd1Bill.Columns.Clear();
            EraseProd1.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd2_Click(object sender, EventArgs e)
        {
            TxtId2ProdBill.Clear();
            TxtCod2ProdBill.Clear();
            TxtName2ProdBill.Clear();

            TxtCant2ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU2ProdBill.Clear();
            TxtVT2ProdBill.Clear();
            dataProd2Bill.Columns.Clear();
            EraseProd2.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd3_Click(object sender, EventArgs e)
        {
            TxtId3ProdBill.Clear();
            TxtCod3ProdBill.Clear();
            TxtName3ProdBill.Clear();

            TxtCant3ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU3ProdBill.Clear();
            TxtVT3ProdBill.Clear();
            dataProd3Bill.Columns.Clear();
            EraseProd3.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd4_Click(object sender, EventArgs e)
        {
            TxtId4ProdBill.Clear();
            TxtCod4ProdBill.Clear();
            TxtName4ProdBill.Clear();

            TxtCant4ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU4ProdBill.Clear();
            TxtVT4ProdBill.Clear();
            dataProd4Bill.Columns.Clear();
            EraseProd4.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd5_Click(object sender, EventArgs e)
        {
            TxtId5ProdBill.Clear();
            TxtCod5ProdBill.Clear();
            TxtName5ProdBill.Clear();

            TxtCant5ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU5ProdBill.Clear();
            TxtVT5ProdBill.Clear();
            dataProd5Bill.Columns.Clear();
            EraseProd5.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd6_Click(object sender, EventArgs e)
        {
            TxtId6ProdBill.Clear();
            TxtCod6ProdBill.Clear();
            TxtName6ProdBill.Clear();

            TxtCant6ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU6ProdBill.Clear();
            TxtVT6ProdBill.Clear();
            dataProd6Bill.Columns.Clear();
            EraseProd6.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd7_Click(object sender, EventArgs e)
        {
            TxtId7ProdBill.Clear();
            TxtCod7ProdBill.Clear();
            TxtName7ProdBill.Clear();

            TxtCant7ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU7ProdBill.Clear();
            TxtVT7ProdBill.Clear();
            dataProd7Bill.Columns.Clear();
            EraseProd7.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd8_Click(object sender, EventArgs e)
        {
            TxtId8ProdBill.Clear();
            TxtCod8ProdBill.Clear();
            TxtName8ProdBill.Clear();

            TxtCant8ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU8ProdBill.Clear();
            TxtVT8ProdBill.Clear();
            dataProd8Bill.Columns.Clear();
            EraseProd8.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd9_Click(object sender, EventArgs e)
        {
            TxtId9ProdBill.Clear();
            TxtCod9ProdBill.Clear();
            TxtName9ProdBill.Clear();

            TxtCant9ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU9ProdBill.Clear();
            TxtVT9ProdBill.Clear();
            dataProd9Bill.Columns.Clear();
            EraseProd9.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd10_Click(object sender, EventArgs e)
        {
            TxtId10ProdBill.Clear();
            TxtCod10ProdBill.Clear();
            TxtName10ProdBill.Clear();

            TxtCant10ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU10ProdBill.Clear();
            TxtVT10ProdBill.Clear();
            dataProd10Bill.Columns.Clear();
            EraseProd10.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd11_Click(object sender, EventArgs e)
        {
            TxtId11ProdBill.Clear();
            TxtCod11ProdBill.Clear();
            TxtName11ProdBill.Clear();

            TxtCant11ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU11ProdBill.Clear();
            TxtVT11ProdBill.Clear();
            dataProd11Bill.Columns.Clear();
            EraseProd11.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd12_Click(object sender, EventArgs e)
        {
            TxtId12ProdBill.Clear();
            TxtCod12ProdBill.Clear();
            TxtName12ProdBill.Clear();

            TxtCant12ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU12ProdBill.Clear();
            TxtVT12ProdBill.Clear();
            dataProd12Bill.Columns.Clear();
            EraseProd12.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd13_Click(object sender, EventArgs e)
        {
            TxtId13ProdBill.Clear();
            TxtCod13ProdBill.Clear();
            TxtName13ProdBill.Clear();

            TxtCant13ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU13ProdBill.Clear();
            TxtVT13ProdBill.Clear();
            dataProd13Bill.Columns.Clear();
            EraseProd13.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd14_Click(object sender, EventArgs e)
        {
            TxtId14ProdBill.Clear();
            TxtCod14ProdBill.Clear();
            TxtName14ProdBill.Clear();

            TxtCant14ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU14ProdBill.Clear();
            TxtVT14ProdBill.Clear();
            dataProd14Bill.Columns.Clear();
            EraseProd14.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void EraseProd15_Click(object sender, EventArgs e)
        {
            TxtId15ProdBill.Clear();
            TxtCod15ProdBill.Clear();
            TxtName15ProdBill.Clear();

            TxtCant15ProdBill.Text = "";
            if (TxtPrecioBill.SelectedIndex.Equals(-1))
            {
                //MessageBox.Show("Selecciones el tipo de venta");
            }
            else
            {
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Mayor")
                {
                    TxtPrecioBill.Text = "Por Menor";
                    TxtPrecioBill.Text = "Por Mayor";
                }
                if (TxtPrecioBill.SelectedItem.ToString() == "Por Menor")
                {
                    TxtPrecioBill.Text = "Por Mayor";
                    TxtPrecioBill.Text = "Por Menor";
                }
            }

            TxtVU15ProdBill.Clear();
            TxtVT15ProdBill.Clear();
            dataProd15Bill.Columns.Clear();
            EraseProd15.Visible = false;
            inscount--;
            textBox1.Text = inscount.ToString();
        }

        private void BtnsaveBill_Click(object sender, EventArgs e)
        {
            if ()
        }
    }
}
