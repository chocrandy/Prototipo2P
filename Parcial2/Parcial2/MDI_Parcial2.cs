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
<<<<<<< HEAD
=======
        /*/
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
        private mantenimiento_concepto frm_mantenimiento_concepto;
        private mantenimiento_departamento frm_mantenimiento_departamento;
        private mantenimiento_empleado frm_mantenimiento_empleado;
        private mantenimiento_puesto frm_mantenimiento_puesto;
        private nominaEncab frm_nominaEncab;
<<<<<<< HEAD
        private transEncab frm_transEncab;
=======
        private transEncab frm_transEncab; /*/
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0

        //sentencia sn = new sentencia();
        String usuarioActivo = "rchocm";

        public MDI_Parcial2()
        {
            InitializeComponent();
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            
        }

<<<<<<< HEAD
        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========          
=======
        //==========Funciones para evitar que se habrá 2 veces la misma ventana==========  
        /*/
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
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
<<<<<<< HEAD
        { frm_transEncab = null; }        

        //====================Funciones de declaración de Eventos====================       
        
=======
        { frm_transEncab = null; }        /*/

        //====================Funciones de declaración de Eventos====================       

>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
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
<<<<<<< HEAD
            //CONCEPTO            
=======
            //CONCEPTO 
            /*/
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
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
<<<<<<< HEAD
            }
        }       

        private void DepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DEPARTAMENTO            
            if (frm_mantenimiento_departamento == null)
            {
                frm_mantenimiento_departamento = new mantenimiento_departamento(usuarioActivo);
                frm_mantenimiento_departamento.MdiParent = this;
                frm_mantenimiento_departamento.FormClosed += new FormClosedEventHandler(frm_mantenimiento_departamento_FormClosed);
                frm_mantenimiento_departamento.Show();
            }
            else
            {
                frm_mantenimiento_departamento.Activate();
            }
=======
            } /*/
        }

        private void DepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
        }

        private void EmpleadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //EMPLEADO            
            if (frm_mantenimiento_empleado == null)
            {
                frm_mantenimiento_empleado = new mantenimiento_empleado(usuarioActivo);
                frm_mantenimiento_empleado.MdiParent = this;
                frm_mantenimiento_empleado.FormClosed += new FormClosedEventHandler(frm_mantenimiento_empleado_FormClosed);
                frm_mantenimiento_empleado.Show();
            }
            else
            {
                frm_mantenimiento_empleado.Activate();
            }
=======
           
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
        }

        private void PuestoToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //PUESTO            
            if (frm_mantenimiento_puesto == null)
            {
                frm_mantenimiento_puesto = new mantenimiento_puesto(usuarioActivo);
                frm_mantenimiento_puesto.MdiParent = this;
                frm_mantenimiento_puesto.FormClosed += new FormClosedEventHandler(frm_mantenimiento_puesto_FormClosed);
                frm_mantenimiento_puesto.Show();
            }
            else
            {
                frm_mantenimiento_puesto.Activate();
            }
=======
            
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
        }

        private void NominaToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //NOMINA            
            if (frm_nominaEncab == null)
            {
                frm_nominaEncab = new nominaEncab();
                frm_nominaEncab.MdiParent = this;
                frm_nominaEncab.FormClosed += new FormClosedEventHandler(frm_nominaEncab_FormClosed);
                frm_nominaEncab.Show();
            }
            else
            {
                frm_nominaEncab.Activate();
            }
=======
            
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
        }

        private void TransferenciaBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //TRANSFERENCIA
            //transEncab
            if (frm_transEncab == null)
            {
                frm_transEncab = new transEncab();
                frm_transEncab.MdiParent = this;
                frm_transEncab.FormClosed += new FormClosedEventHandler(frm_transEncab_FormClosed);
                frm_transEncab.Show();
            }
            else
            {
                frm_transEncab.Activate();
            }
=======
            
>>>>>>> b580a94a104c75dc30eb229fd2f37620f2f0e3c0
        }

        private void SeguridadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MDI_Seguridad seguridad = new MDI_Seguridad(Lbl_usuario.Text);
            seguridad.lbl_nombreUsuario.Text = Lbl_usuario.Text;
            seguridad.ShowDialog();
        }
    }
}
