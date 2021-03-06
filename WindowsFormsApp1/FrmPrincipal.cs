using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class FrmPrincipal : Form
    {
        private LosHilos hilos;

        public FrmPrincipal()
        {
            InitializeComponent();
            this.hilos = new LosHilos();
            this.hilos.AvisoFin += MostrarMensajeFin;
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            try
            {
                hilos += 1;
            }
            catch(CantidadInvalidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBitacora_Click(object sender, EventArgs e)
        {
            MessageBox.Show(hilos.Bitacora);
        }
        
        public void MostrarMensajeFin(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
