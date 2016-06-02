using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RESTServicePersonas.Dominio;
using System.Data.SqlClient;

namespace RESTServicePersonas.Persistencia
{
    public class PersonaDAO
    {

        public Persona Obtener(string dni)
        {
            Persona personaObtenida = null;
            string sql = "SELECT * FROM PERSONA WHERE DNI=@dni";
            using (SqlConnection con = new SqlConnection(ConexionUtil.Cadena))
            {
                con.Open();
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.Parameters.Add(new SqlParameter("@dni", dni));
                    using (SqlDataReader resultado = com.ExecuteReader())
                    {
                        if (resultado.Read())
                        {
                            personaObtenida = new Persona()
                            {
                                dni = (string)resultado["DNI"],
                                nombre = (string)resultado["NOMBRES"],
                                apellidopaterno = (string)resultado["APELLIDO_PATERNO"],
                                apellidomaterno = (string)resultado["APELLIDO_MATERNO"],
                                nacimiento = (DateTime)resultado["FECHA_NACIMIENTO"],
                                estado = (string)resultado["ESTADO"]
                            };
                        }
                    }
                }
            }
            return personaObtenida;
        }

    }
}