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
using CapaEntidad;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

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
            if (comboBox1.Text != "")
            {
                try
                {
                    ServiceColaborador.Colaborador objcolaborador = new ServiceColaborador.Colaborador();

                    objcolaborador.codigo = int.Parse(textBox1.Text);
                    objcolaborador.dni = textBox2.Text;
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
                    if (MessageBox.Show(descripcion, codigo, MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        limpiar();
                    }
                    //MessageBox.Show(mensaje);
                    //MessageBox.ReferenceEquals("Error al crear", error.Reason.ToString());
                    //MessageBox.ReferenceEquals(error.Detail.Codigo, "101");
                    //MessageBox.ReferenceEquals(error.Detail.Descripcion, "El colaborador ya existe");
                    //MessageBox.Show("El colaborador ya existe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //catch (FaultException<ServiceColaborador.RepetidoExcepcion2> error2)
                //{
                //    string codigo2 = error2.Detail.Codigo;
                //    string descripcion2 = error2.Detail.Descripcion;
                //    if (MessageBox.Show(descripcion2, codigo2, MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                //    {
                //        limpiar();
                //    }
                //}
                //catch(FaultException<ServiceColaborador.Valida> er)
                //{

                //}
            }
            else
            {
                if (MessageBox.Show("Debe elegir un cargo al colaborador", "Cargo Colaborador",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
                {
                    comboBox1.Focus();
                }
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
            objcolaborador.dni = textBox2.Text;
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

        //[TestMethod]
        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                //groupBox2.Enabled = true;
                WebClient proxy = new WebClient();
                string serviceURL = string.Format("http://localhost:19434/Personas.svc/Personas/" + textBox2.Text);
                byte[] data = proxy.DownloadData(serviceURL);
                Stream stream = new MemoryStream(data);
                DataContractJsonSerializer obj = new DataContractJsonSerializer(typeof(Persona));
                Persona persona = obj.ReadObject(stream) as Persona;
                textBox4.Text = persona.nombre + " " + persona.apellidopaterno + " " + persona.apellidomaterno;
                maskedTextBox2.Text = persona.nacimiento.ToString();
            }
            catch (WebException ex)
            {

                //if (textBox2.Text == "")
                //{
                    
                //    MessageBox.Show("Ingrese un DNI");
                //}
                //else
                //{
                    HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                    if (Convert.ToInt32(code) == 500)
                    {
                        string mensaje = ((HttpWebResponse)ex.Response).StatusDescription;
                        StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                        string error = reader.ReadToEnd();
                        JavaScriptSerializer js1 = new JavaScriptSerializer();
                        string mensa = js1.Deserialize<string>(error);
                        if (MessageBox.Show(mensa, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            limpiar();
                        }
                    }
                    else if (Convert.ToInt32(code) == 417)
                    {
                        string mensaje = ((HttpWebResponse)ex.Response).StatusDescription;
                        StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                        string error = reader.ReadToEnd();
                        JavaScriptSerializer js1 = new JavaScriptSerializer();
                        string mensa = js1.Deserialize<string>(error);
                        if (MessageBox.Show(mensa, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            limpiar();
                        }
                    }
                    
                //}
            }

            
            
            
     


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            maskedTextBox2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox1.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void colaboradorBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void colaboradorBindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
