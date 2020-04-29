using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;
using CapaDatos;

namespace CapaVistaFRM
{
    public partial class MDI_Parcial2 : Form
    {
        //mantenimiento_concepto
        /*/
        private mantenimiento_concepto frm_mantenimiento_concepto;
        private mantenimiento_departamento frm_mantenimiento_departamento;
        private mantenimiento_empleado frm_mantenimiento_empleado;
        private mantenimiento_puesto frm_mantenimiento_puesto;
        private nominaEncab frm_nominaEncab;
        private transEncab frm_transEncab; /*/

        //sentencia sn = new sentencia();
        String usuarioActivo = "rchocm";

        public MDI_Parcial2()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========  
        /*/
        private void frm_mantenimiento_concepto_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_concepto = null; }
        private void frm_mantenimiento_departamento_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_departamento = null; }
        private void frm_mantenimiento_empleado_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_empleado = null; }
        private void frm_mantenimiento_puesto_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_mantenimiento_puesto = null; }
        private void frm_nominaEncab_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_nominaEncab = null; }
        private void frm_transEncab_FormClosed(Object sender, FormClosedEventArgs e)
        { frm_transEncab = null; }        /*/

        //====================Funciones de declaración de Eventos====================       

        private void MDI_FRM_Load(object sender, EventArgs e)
        {
            /*/
            frm_login login = new frm_login();
            login.ShowDialog();
            Lbl_usuario.Text = login.obtenerNombreUsuario();
            usuarioActivo = Lbl_usuario.Text; /*/
            usuarioActivo = "rchocm"; 
        }

        private void SeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            
        }

        private void Btn_prueba_Click(object sender, EventArgs e)
        {
            //                      Usuario        Mensaje a guardar     Tabla
            //sn.insertarBitacora(Lbl_usuario.Text, "Probó la Bitacora", "General");
        }        

        private void BonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CONCEPTO 
            /*/
            if (frm_mantenimiento_concepto == null)
            {
                frm_mantenimiento_concepto = new mantenimiento_concepto(usuarioActivo);
                frm_mantenimiento_concepto.MdiParent = this;
                frm_mantenimiento_concepto.FormClosed += new FormClosedEventHandler(frm_mantenimiento_concepto_FormClosed);
                frm_mantenimiento_concepto.Show();
            }
            else
            {
                frm_mantenimiento_concepto.Activate();
            } /*/
        }

        private void DepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void EmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void PuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void NominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void TransferenciaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void SeguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }
    }
}
