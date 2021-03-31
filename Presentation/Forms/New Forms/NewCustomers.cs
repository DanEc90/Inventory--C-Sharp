using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Domain.Models;
using Domain.ValueObjects;

namespace Presentation.Forms.New_Forms
{
    public partial class NewCustomers : Form
    {
        private readonly CustomersModel customer = new CustomersModel();
        public NewCustomers()
        {
            InitializeComponent();
            Text = string.Empty;
            ControlBox = false;
            DoubleBuffered = true;
            //MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;
        }

        private bool Val_Ced(string ced)
        {
            string r = ced.Substring(9, 1);
            int sumatotal = 0;

            for (int i = 0; i < ced.Length - 1; i++)
            {
                int numero = Convert.ToInt32(ced[i].ToString());

                if ((i + 1) % 2 == 1)
                {
                    numero = Convert.ToInt32(ced[i].ToString()) * 2;

                    if (numero > 9)
                    {
                        numero -= 9;
                    }
                }
                sumatotal += numero;
            }

            sumatotal = 10 - (sumatotal % 10);

            if (sumatotal != Convert.ToInt32(r))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Restart()
        {
            txtCustoId.Clear();
            txtCustoName.Clear();
            txtCustoCed.Clear();
            txtCustoAddress.Clear();
            txtCustoPhone.Clear();
            Close();
        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSaveCusto_Click(object sender, EventArgs e)
        {
            customer.CustoNameMod = txtCustoName.Text;
            customer.CustoCedMod = txtCustoCed.Text;
            customer.CustoAddressMod = txtCustoAddress.Text;
            customer.CustoPhoneMod = txtCustoPhone.Text;
            if (txtCustoId.Text == "")
            {
                customer.State = EntityState.Added;
            }
            else
            {
                customer.State = EntityState.Modified;
            }

            bool valid = new Helps.DataValidation(customer).Validate();
            
            if (valid == true)
            {
                if (txtCustoCed.Text.Length == 13)// pregunta si es ruc
                {
                    string ruc = txtCustoCed.Text.Substring(10, 3);

                    if (ruc == "001")
                    {
                        bool resp = Val_Ced(txtCustoCed.Text.Substring(0, 10));

                        if (resp == true)
                        {
                            MessageBox.Show("Ingrese un R.U.C valido");
                        }
                        else
                        {
                            string result = customer.SaveChanges();
                            MessageBox.Show(result);
                            Restart();
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("R.U.C. debe terminar en 001");
                    }
                }
                else
                {
                    if (txtCustoCed.Text.Length == 10)//pregunta si es cedula
                    {
                        bool resp = Val_Ced(txtCustoCed.Text);

                        if (resp == true)
                        {
                            MessageBox.Show("Ingrese una cédula valida");
                        }
                        else
                        {
                            string result = customer.SaveChanges();
                            MessageBox.Show(result);
                            Restart();
                            Close();
                        }
                    }
                    else
                    {
                        if (txtCustoCed.Text.Length > 0)
                        {
                            MessageBox.Show("Ingrese una cédula / R.U.C. valido");
                        }
                    }
                }
            }
        }

        //Grag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void UpBarCli_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnExitCusto_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void TxtCustoCed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TxtCustoName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void TxtCustoPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
