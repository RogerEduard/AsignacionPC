using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAsignacionPC
{
    public partial class RegistrarColaborador : Form
    {

        ServiceColaborador.ColaboradoresClient obj = new ServiceColaborador.ColaboradoresClient();
        //ServiceColaborador.RepetidoExcepcion obj2 = new ServiceColaborador.RepetidoExcepcion();
        public RegistrarColaborador()
        {
            InitializeComponent();
            ListarColaboradores();
        }

        private void ListarColaboradores() 
        {
            //DataSet ds = new DataSet();
            dataGridView1.DataSource = obj.ListarColaborador();
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    ServiceColaborador.Colaborador objcolaborador = new ServiceColaborador.Colaborador();

                    objcolaborador.codigo = int.Parse(textBox1.Text);
                    objcolaborador.nombre = textBox4.Text;
                    objcolaborador.ingreso = Convert.ToDateTime(maskedTextBox1.Text);
                    objcolaborador.fechanacimiento = Convert.ToDateTime(maskedTextBox2.Text);
                    objcolaborador.cargo = comboBox1.Text;
                    //objcolaborador.estado = textBox2.Text;

                    obj.CrearColaborador(objcolaborador);
                    MessageBox.Show("Colaborador creado correctamente");
                    ListarColaboradores();
                    limpiar();
                }
                catch (FaultException<ServiceColaborador.RepetidoExcepcion> error)
                {
                    string codigo = error.Detail.Codigo;
                    string descripcion = error.Detail.Descripcion;
                    if (MessageBox.Show(descripcion,codigo, MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        limpiar();
                    }
                    //MessageBox.Show(mensaje);
                    //MessageBox.ReferenceEquals("Error al crear", error.Reason.ToString());
                    //MessageBox.ReferenceEquals(error.Detail.Codigo, "101");
                    //MessageBox.ReferenceEquals(error.Detail.Descripcion, "El colaborador ya existe");
                    //MessageBox.Show("El colaborador ya existe");
                   
                }  
        }

        public void limpiar(){
            textBox1.Text="";
            textBox4.Text="";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text="";
            textBox1.Focus();
        }


        private void RegistrarColaborador_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceColaborador.Colaborador objcolaborador = new ServiceColaborador.Colaborador();

            objcolaborador.codigo = int.Parse(textBox1.Text);
            objcolaborador.nombre = textBox4.Text;
            objcolaborador.ingreso = Convert.ToDateTime(maskedTextBox1.Text);
            objcolaborador.fechanacimiento = Convert.ToDateTime(maskedTextBox2.Text);
            objcolaborador.cargo = comboBox1.Text;
            //objcolaborador.estado = textBox2.Text;

            obj.ModificarColaborador(objcolaborador);
            MessageBox.Show("Colaborador modificado correctamente");
            ListarColaboradores();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceColaborador.Colaborador objcolaborador = new ServiceColaborador.Colaborador();

            obj.EliminarColaborador(int.Parse(textBox1.Text));
            MessageBox.Show("Colaborador eliminado correctamente");
            ListarColaboradores();
            limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            //if (textBox1.Text.Trim() == ""){
                
            //}
        }
    }
}
