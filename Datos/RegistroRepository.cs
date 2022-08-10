using Entidad;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RegistroRepository
    {
        DbConnection _connection;
        private List<Registro> registros;
        public RegistroRepository(DbConnection connection)
        {
            _connection = connection;
            registros = new List<Registro>();
        }

        public void GuardarRegistroRep(Registro registro)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "insert Registro(FechaIngreso,Nombre,Telefono,GB,Color,IMEI1,IMEI2,Entrada,Salida,Observacion)" +
                              " values (@FechaIngreso, @Nombre, @Telefono, @GB,@Color, @IMEI1, @IMEI2, @Entrada,@Salida,@Observacion)";
                command.Parameters.Add(new SqlParameter("@FechaIngreso", registro.FechaIngreso));
                command.Parameters.Add(new SqlParameter("@Nombre", registro.NombreCliente));
                command.Parameters.Add(new SqlParameter("@Telefono", registro.Telefono));
                command.Parameters.Add(new SqlParameter("@GB", registro.GB));
                command.Parameters.Add(new SqlParameter("@Color", registro.Color));
                command.Parameters.Add(new SqlParameter("@IMEI1", registro.IMEI1));
                command.Parameters.Add(new SqlParameter("@IMEI2", registro.IMEI2));
                command.Parameters.Add(new SqlParameter("@Entrada", registro.Entrada));
                command.Parameters.Add(new SqlParameter("@Salida", registro.Salida));
                command.Parameters.Add(new SqlParameter("@Observacion", registro.Observacion));

                command.ExecuteNonQuery();
            }
        }

        public Registro BuscarRegistroPorIMEI1(string IMEI1)
        {
            using (var command = _connection.CreateCommand())
            {

                command.CommandText = "select *from Registro where IMEI1=@IMEI1";
                command.Parameters.Add(new SqlParameter("@IMEI1", IMEI1));
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Registro registro = new Registro
                        {
                            FechaIngreso = reader.GetString(0),
                            NombreCliente = reader.GetString(1),
                            Telefono = reader.GetString(2),
                            GB = reader.GetString(3),
                            Color = reader.GetString(4),
                            IMEI1 = reader.GetString(5),
                            IMEI2 = reader.GetString(6),
                            Entrada = reader.GetString(7),
                            Salida = reader.GetString(8),
                            Observacion = reader.GetString(9),                           
                        };

                        return registro;
                    }
                }
                reader.Close();
            }
            return null;
        }


        public void EliminarRegistroRep(string IMEI1)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "delete From Registro where IMEI1=@IMEI1";
                command.Parameters.Add(new SqlParameter("@IMEI1", IMEI1));
                command.ExecuteNonQuery();
            }
        }

        public void ModificarRegistro(Registro registroNuevo, string IMEI1)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "update Registro set FechaIngreso=@FechaIngreso,Nombre=@Nombre,Telefono=@Telefono," +
                    "GB=@GB, Color=@Color,IMEI1=@IMEI1,IMEI2=@IMEI2,Entrada=@Entrada,Salida=@Salida,Observacion=@Observacion" +
                    " where IMEI1=@IMEI1";
                command.Parameters.Add(new SqlParameter("@IMEI1", IMEI1));
                command.Parameters.Add(new SqlParameter("@FechaIngreso", registroNuevo.FechaIngreso));
                command.Parameters.Add(new SqlParameter("@Nombre", registroNuevo.NombreCliente));
                command.Parameters.Add(new SqlParameter("@Telefono", registroNuevo.Telefono));
                command.Parameters.Add(new SqlParameter("@GB", registroNuevo.GB));
                command.Parameters.Add(new SqlParameter("@Color", registroNuevo.Color));
                command.Parameters.Add(new SqlParameter("@IMEI2", registroNuevo.IMEI2));
                command.Parameters.Add(new SqlParameter("@Entrada", registroNuevo.Entrada));
                command.Parameters.Add(new SqlParameter("@Salida", registroNuevo.Salida));
                command.Parameters.Add(new SqlParameter("@Observacion", registroNuevo.Observacion));

                command.ExecuteNonQuery();
            }
        }

        public List<Registro> ConsultarRegistros(string IMEI1)
        {
            List<Registro> registros = new List<Registro>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Registro where IMEI1=@IMEI1";
                command.Parameters.Add(new SqlParameter("@IMEI1", IMEI1));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Registro registro = new Registro
                    {
                        FechaIngreso = reader.GetString(0),
                        NombreCliente = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        GB = reader.GetString(3),
                        Color = reader.GetString(4),
                        IMEI1 = reader.GetString(5),
                        IMEI2 = reader.GetString(6),
                        Entrada = reader.GetString(7),
                        Salida = reader.GetString(8),
                        Observacion = reader.GetString(9),
                    };
                    registros.Add(registro);
                }
                reader.Close();
            }

            return registros;
        }
        public List<Registro> ConsultarListRegistros()
        {

            List<Registro> registros = new List<Registro>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from Registro";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Registro registro = new Registro
                        {
                            FechaIngreso = reader.GetString(0),
                            NombreCliente = reader.GetString(1),
                            Telefono = reader.GetString(2),
                            GB = reader.GetString(3),
                            Color = reader.GetString(4),
                            IMEI1 = reader.GetString(5),
                            IMEI2 = reader.GetString(6),
                            Entrada = reader.GetString(7),
                            Salida = reader.GetString(8),
                            Observacion = reader.GetString(9),
                        };

                        registros.Add(registro);
                    }
                }
            }
            return registros;
        }
    }
}
