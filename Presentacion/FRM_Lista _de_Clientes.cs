using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;




namespace Presentacion
{
    public partial class FRM_Lista__de_Clientes : Form 
    {
        public FRM_Lista__de_Clientes()
        {
            InitializeComponent();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        Class1 cl = new Class1();

        /// <summary>
        /// Cargar Todos los Clientes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_Lista__de_Clientes_Load(object sender, EventArgs e)
        {
            Mostrar();
        }
        

        /// <summary>
        /// Mostrar Todos los Clientes
        /// </summary>
        public void Mostrar()
        {
            DataTable DT = new DataTable();
            SqlDataAdapter DS = new SqlDataAdapter();
            SqlConnection CN1 = new SqlConnection("Server = DESKTOP-8CA51GL\\SQLEXPRESS; DataBase= System_Lf; integrated security = true");
            try
            {
                cl.abrir();
                DS = new SqlDataAdapter("SELECT DNI [Nª DE IDENTIDAD],CONCAT(NOMBRE_CL,' ',APELLIDO_CL) [NOMBRE COMPLETO],GENERO,TELEFONO_CL TELEFONO,DIRECCION_CL DIRECCION,FECHA_REG [FECHA DE INGRESO] FROM CLIENTES ORDER BY [NOMBRE COMPLETO] ", cl.CN);
                DS.Fill(DT);
                Dg2.DataSource = DT;
                var v = new int();
                v = Dg2.Rows.Count;
                iconButton1.Text = "Clientes: " + v;
            }
            catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            cl.cerrar();
        }

     
        /// <summary>
        /// Cerrar Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }


        /// <summary>
        /// Mover el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dg2_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Mover el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dg2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Mover el Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_Lista__de_Clientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Minimizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BT_MIN_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Dg2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
