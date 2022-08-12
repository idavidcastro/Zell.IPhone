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
                command.CommandText = "insert Registro(FechaIngreso,Nombre,Iphone,AppleWatch,Samsung,GB,Color,IMEI1,IMEI2,Entrada,Salida,Observacion)" +
                              " values (@FechaIngreso, @Nombre, @Iphone,@AppleWatch,@Samsung, @GB,@Color, @IMEI1, @IMEI2, @Entrada,@Salida,@Observacion)";

                command.Parameters.Add(new SqlParameter("@FechaIngreso", registro.FechaIngreso.ToShortDateString()));
                command.Parameters.Add(new SqlParameter("@Nombre", ValidarCamposVacios(registro.NombreCliente)));
                command.Parameters.Add(new SqlParameter("@Iphone", ValidarCamposVacios(registro.Iphone)));
                command.Parameters.Add(new SqlParameter("@AppleWatch", ValidarCamposVacios(registro.AppleWatch)));
                command.Parameters.Add(new SqlParameter("@Samsung", ValidarCamposVacios(registro.Samsung)));
                command.Parameters.Add(new SqlParameter("@GB", ValidarCamposVacios(registro.GB)));
                command.Parameters.Add(new SqlParameter("@Color", ValidarCamposVacios(registro.Color)));
                command.Parameters.Add(new SqlParameter("@IMEI1", ValidarCamposVacios(registro.IMEI1)));
                command.Parameters.Add(new SqlParameter("@IMEI2", ValidarCamposVacios(registro.IMEI2)));
                command.Parameters.Add(new SqlParameter("@Entrada", ValidarCamposVacios(registro.Entrada)));
                command.Parameters.Add(new SqlParameter("@Salida", ValidarCamposVacios(registro.Salida)));
                command.Parameters.Add(new SqlParameter("@Observacion", ValidarCamposVacios(registro.Observacion)));

                command.ExecuteNonQuery();
            }
        }
        public string ValidarCamposVacios(string campo)
        {
            if (string.IsNullOrEmpty(campo))
            {
                return "NULL";
            }
            else
            {
                return campo;
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
                            FechaIngreso = reader.GetDateTime(0),
                            NombreCliente = reader.GetString(1),
                            Iphone = reader.GetString(2),
                            AppleWatch = reader.GetString(3),
                            Samsung = reader.GetString(4),
                            GB = reader.GetString(5),
                            Color = reader.GetString(6),
                            IMEI1 = reader.GetString(7),
                            IMEI2 = reader.GetString(8),
                            Entrada = reader.GetString(9),
                            Salida = reader.GetString(10),
                            Observacion = reader.GetString(11)                         
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
                command.CommandText = "update Registro set FechaIngreso=@FechaIngreso,Nombre=@Nombre,Iphone=@Iphone,AppleWatch=@AppleWatch,Samsung=@Samsung," +
                    "GB=@GB, Color=@Color,IMEI1=@IMEI1,IMEI2=@IMEI2,Entrada=@Entrada,Salida=@Salida,Observacion=@Observacion" +
                    " where IMEI1=@IMEI1";
                command.Parameters.Add(new SqlParameter("@IMEI1", IMEI1));
                command.Parameters.Add(new SqlParameter("@FechaIngreso", registroNuevo.FechaIngreso.ToShortDateString()));
                command.Parameters.Add(new SqlParameter("@Nombre", registroNuevo.NombreCliente));
                command.Parameters.Add(new SqlParameter("@Iphone", registroNuevo.Iphone));
                command.Parameters.Add(new SqlParameter("@AppleWatch", registroNuevo.AppleWatch));
                command.Parameters.Add(new SqlParameter("@Samsung", registroNuevo.Samsung));
                command.Parameters.Add(new SqlParameter("@GB", registroNuevo.GB));
                command.Parameters.Add(new SqlParameter("@Color", registroNuevo.Color));
                command.Parameters.Add(new SqlParameter("@IMEI2", registroNuevo.IMEI2));
                command.Parameters.Add(new SqlParameter("@Entrada", registroNuevo.Entrada));
                command.Parameters.Add(new SqlParameter("@Salida", registroNuevo.Salida));
                command.Parameters.Add(new SqlParameter("@Observacion", registroNuevo.Observacion));

                command.ExecuteNonQuery();
            }
        }

        public List<Registro> ConsultarRegistrosIMEI1(string IMEI1)
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
                        FechaIngreso = reader.GetDateTime(0),
                        NombreCliente = reader.GetString(1),
                        Iphone = reader.GetString(2),
                        AppleWatch = reader.GetString(3),
                        Samsung = reader.GetString(4),
                        GB = reader.GetString(5),
                        Color = reader.GetString(6),
                        IMEI1 = reader.GetString(7),
                        IMEI2 = reader.GetString(8),
                        Entrada = reader.GetString(9),
                        Salida = reader.GetString(10),
                        Observacion = reader.GetString(11)
                    };
                    registros.Add(registro);
                }
                reader.Close();
            }

            return registros;
        }
        public List<Registro> ConsultarRegistrosIMEI2(string IMEI2)
        {
            List<Registro> registros = new List<Registro>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Registro where IMEI2=@IMEI2";
                command.Parameters.Add(new SqlParameter("@IMEI2", IMEI2));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Registro registro = new Registro
                    {
                        FechaIngreso = reader.GetDateTime(0),
                        NombreCliente = reader.GetString(1),
                        Iphone = reader.GetString(2),
                        AppleWatch = reader.GetString(3),
                        Samsung = reader.GetString(4),
                        GB = reader.GetString(5),
                        Color = reader.GetString(6),
                        IMEI1 = reader.GetString(7),
                        IMEI2 = reader.GetString(8),
                        Entrada = reader.GetString(9),
                        Salida = reader.GetString(10),
                        Observacion = reader.GetString(11)
                    };
                    registros.Add(registro);
                }
                reader.Close();
            }

            return registros;
        }
        public List<Registro> ConsultarRegistrosIphone(string Iphone)
        {
            List<Registro> registros = new List<Registro>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Registro where Iphone=@Iphone";
                command.Parameters.Add(new SqlParameter("@Iphone", Iphone));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Registro registro = new Registro
                    {
                        FechaIngreso = reader.GetDateTime(0),
                        NombreCliente = reader.GetString(1),
                        Iphone = reader.GetString(2),
                        AppleWatch = reader.GetString(3),
                        Samsung = reader.GetString(4),
                        GB = reader.GetString(5),
                        Color = reader.GetString(6),
                        IMEI1 = reader.GetString(7),
                        IMEI2 = reader.GetString(8),
                        Entrada = reader.GetString(9),
                        Salida = reader.GetString(10),
                        Observacion = reader.GetString(11)
                    };
                    registros.Add(registro);
                }
                reader.Close();
            }

            return registros;
        }
        public List<Registro> ConsultarRegistrosAppleWatch(string AppleWatch)
        {
            List<Registro> registros = new List<Registro>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Registro where AppleWatch=@AppleWatch";
                command.Parameters.Add(new SqlParameter("@AppleWatch", AppleWatch));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Registro registro = new Registro
                    {
                        FechaIngreso = reader.GetDateTime(0),
                        NombreCliente = reader.GetString(1),
                        Iphone = reader.GetString(2),
                        AppleWatch = reader.GetString(3),
                        Samsung = reader.GetString(4),
                        GB = reader.GetString(5),
                        Color = reader.GetString(6),
                        IMEI1 = reader.GetString(7),
                        IMEI2 = reader.GetString(8),
                        Entrada = reader.GetString(9),
                        Salida = reader.GetString(10),
                        Observacion = reader.GetString(11)
                    };
                    registros.Add(registro);
                }
                reader.Close();
            }

            return registros;
        }
        public List<Registro> ConsultarRegistrosColor(string Color)
        {
            List<Registro> registros = new List<Registro>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Registro where Color=@Color";
                command.Parameters.Add(new SqlParameter("@Color", Color));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Registro registro = new Registro
                    {
                        FechaIngreso = reader.GetDateTime(0),
                        NombreCliente = reader.GetString(1),
                        Iphone = reader.GetString(2),
                        AppleWatch = reader.GetString(3),
                        Samsung = reader.GetString(4),
                        GB = reader.GetString(5),
                        Color = reader.GetString(6),
                        IMEI1 = reader.GetString(7),
                        IMEI2 = reader.GetString(8),
                        Entrada = reader.GetString(9),
                        Salida = reader.GetString(10),
                        Observacion = reader.GetString(11)
                    };
                    registros.Add(registro);
                }
                reader.Close();
            }

            return registros;
        }
        public List<Registro> ConsultarRegistrosGB(string GB)
        {
            List<Registro> registros = new List<Registro>();
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "select * from Registro where GB=@GB";
                command.Parameters.Add(new SqlParameter("@GB", GB));
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Registro registro = new Registro
                    {
                        FechaIngreso = reader.GetDateTime(0),
                        NombreCliente = reader.GetString(1),
                        Iphone = reader.GetString(2),
                        AppleWatch = reader.GetString(3),
                        Samsung = reader.GetString(4),
                        GB = reader.GetString(5),
                        Color = reader.GetString(6),
                        IMEI1 = reader.GetString(7),
                        IMEI2 = reader.GetString(8),
                        Entrada = reader.GetString(9),
                        Salida = reader.GetString(10),
                        Observacion = reader.GetString(11)
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
                command.CommandText = "Select * from Registro order by FechaIngreso asc";
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Registro registro = new Registro
                        {
                            FechaIngreso = reader.GetDateTime(0),
                            NombreCliente = reader.GetString(1),
                            Iphone = reader.GetString(2),
                            AppleWatch = reader.GetString(3),
                            Samsung = reader.GetString(4),
                            GB = reader.GetString(5),
                            Color = reader.GetString(6),
                            IMEI1 = reader.GetString(7),
                            IMEI2 = reader.GetString(8),
                            Entrada = reader.GetString(9),
                            Salida = reader.GetString(10),
                            Observacion = reader.GetString(11)
                        };

                        registros.Add(registro);
                    }
                }
            }
            return registros;
        }
    }
}
