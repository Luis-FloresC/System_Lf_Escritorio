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
using Telerik.ReportViewer.WinForms;
using System.Runtime.InteropServices;

namespace Presentacion
{
    public partial class FRM_REPORTE_CUOTAS : Form
    {

        /// <summary>
        /// Constructor Iniciador del Form
        /// </summary>
        public FRM_REPORTE_CUOTAS()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private string IDENT;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="DNI">Numero de identidad</param>
        public FRM_REPORTE_CUOTAS(string DNI)
        {
            InitializeComponent();
        
            IDENT = DNI;
        }
    
        /// <summary>
        /// Generar Reporte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_REPORTE_CUOTAS_Load(object sender, EventArgs e)
        {
            
            this.Reports_PrestamoTableAdapter.Fill(this.System_LfDataSet4.Reports_Prestamo,IDENT);
          
            this.reportViewer1.RefreshReport();
        }
        /// <summary>
        /// Cerrar Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTN_CERRAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// Mover Formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRM_REPORTE_CUOTAS_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
      
    }
}
