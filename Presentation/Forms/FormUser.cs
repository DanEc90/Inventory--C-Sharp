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
    public partial class FormUser : Form
    {
        private readonly UsersModel user = new UsersModel();

        public FormUser()
        {
            InitializeComponent();            
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            ListUsers();            
        }

        public void ListUsers()
        {
            try
            {
                dataUsers.DefaultCellStyle.Font = new Font("Yu Gothic UI", 9);
                dataUsers.DataSource = user.GetAll();
                dataUsers.ReadOnly = true;
                dataUsers.Columns[0].HeaderText = "IdUser";
                dataUsers.Columns[0].Visible = false;
                dataUsers.Columns[1].HeaderText = "Nombre";
                dataUsers.Columns[2].HeaderText = "Cédula / R.U.C.";
                dataUsers.Columns[3].HeaderText = "Contraseña";
                dataUsers.Columns[4].HeaderText = "Tipo";

                /* Agrega botnes al dataGridView, pero sigue creando botones cada vez q 
                     * actualizo los datos o hago un insert

                DataGridViewButtonColumn elim = new DataGridViewButtonColumn();
                DataGridViewButtonColumn mod = new DataGridViewButtonColumn();
                mod.Name = "mod";
                mod.HeaderText = "a";
                mod.Text = "Modificar";
                mod.UseColumnTextForButtonValue = true;

                //
                elim.Name = "elim";
                elim.HeaderText = "b";
                elim.Text = "Eliminar";
                elim.UseColumnTextForButtonValue = true;


                //añadir la columna de tipo botón al DataGridView                
                dataGridView1.Columns.Add(mod);
                dataGridView1.Columns.Add(elim);*/                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void NewUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            ListUsers();
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form fnu = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewUser);

            if (fnu != null)
            {
                if (fnu.WindowState == FormWindowState.Minimized)
                {
                    fnu.WindowState = FormWindowState.Normal;
                }
                //si la instancia existe la pongo en primer plano
                fnu.BringToFront();
                return;
            }
            //sino existe la instancia se crea una nueva
            NewUser NU = new NewUser();
            NU.Show();
            NU.FormClosed += new FormClosedEventHandler(NewUser_FormClosed);
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (dataUsers.SelectedRows.Count > 0)
            {
                //se localiza el formulario buscandolo entre los forms abiertos 
                Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is NewUser);

                if (frm != null)
                {
                    if (frm.WindowState == FormWindowState.Minimized)
                    {
                        frm.WindowState = FormWindowState.Normal;
                    }
                    //si la instancia existe la pongo en primer plano
                    frm.BringToFront();
                    return;
                }
                //sino existe la instancia se crea una nueva
                NewUser NU = new NewUser();
                
                NU.txtID.Text = (dataUsers.CurrentRow.Cells[0].Value.ToString());
                NU.txt_user_Name.Text = dataUsers.CurrentRow.Cells[1].Value.ToString();
                NU.txt_user_Ced.Text = dataUsers.CurrentRow.Cells[2].Value.ToString();
                NU.txt_user_Passwd.Text = dataUsers.CurrentRow.Cells[3].Value.ToString();
                NU.txt_user_Type.Text = dataUsers.CurrentRow.Cells[4].Value.ToString();
                NU.Show();
                NU.FormClosed += new FormClosedEventHandler(NewUser_FormClosed);

            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void DelUser_Click(object sender, EventArgs e)
        {
            if (dataUsers.SelectedRows.Count > 0)
            {

                DialogResult deluser = MessageBox.Show("Eliminar los datos del usuario " + dataUsers.CurrentRow.Cells[1].Value.ToString() + "? ", "Eliminar datos", MessageBoxButtons.YesNo);
                if (deluser == DialogResult.Yes)
                {
                    user.State = EntityState.Deleted;
                    user.IdUserMod = Convert.ToInt32(dataUsers.CurrentRow.Cells[0].Value);

                    string result = user.SaveChanges();
                    MessageBox.Show(result);
                    ListUsers();
                }
            }
            else
            {
                MessageBox.Show("Select Row");
            }
        }

        private void DataUsers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                e.Value = new string('*', 10);
            }
        }

        private void TxtSearchUsers_TextChanged(object sender, EventArgs e)
        {
            dataUsers.DataSource = user.FindByCed(txtSearchUsers.Text);
        }


        /* private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //el siguiente evento lo usamos para detectar las pulsaciones en los botones
            if (dataGridView1.Columns[e.ColumnIndex].Name == "mod")
            {
                user.State = EntityState.Modified;                
                user.IdUser1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value);
                txt_user_Name.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txt_user_Ced.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txt_user_Passwd.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                txt_user_Type.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "elim")
            {
                user.State = EntityState.Deleted;
                user.IdUser1 = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string result = user.SaveChanges();
                MessageBox.Show(result);
                ListUsers();
            }
        }*/
    }
}
