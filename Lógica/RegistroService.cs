using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lógica
{
    public class RegistroService
    {
        RegistroRepository registroRepository;
        ConnectionManager connectionManager;
        //List<Cliente> clientes;
        public RegistroService(string connectionstring)
        {
            connectionManager = new ConnectionManager(connectionstring);
            registroRepository = new RegistroRepository(connectionManager.Connetion);

        }

        public string GuardarRegistro(Registro registro)
        {
            try
            {
                connectionManager.Open();

                if (registroRepository.BuscarRegistroPorIMEI1(registro.IMEI1) == null)
                {
                    registroRepository.GuardarRegistroRep(registro);
                    return "Se ha registrado correctamente!";
                }
                else
                {
                    return $"El IMEI {registro.IMEI1} ya se encuentra registrado";
                }
            }
            catch (Exception exception)
            {
                return "Se presentó el siguiente error:" + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }

        }

        public string EliminarRegistro(string IMEI1)
        {
            try
            {
                connectionManager.Open();
                if (registroRepository.BuscarRegistroPorIMEI1(IMEI1) != null)
                {
                    registroRepository.EliminarRegistroRep(IMEI1);
                    return $"Se eliminó el registro con el IMEI {IMEI1}";
                }
                return $"No se encontraron registros con el IMEI: {IMEI1}";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error: " + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }

        public string ModificarRegistro(Registro registroNuevo, string IMEI1)
        {
            try
            {
                connectionManager.Open();

                if (registroRepository.BuscarRegistroPorIMEI1(IMEI1) != null)
                {
                    registroRepository.ModificarRegistro(registroNuevo, IMEI1);
                    return $"Se modificó el registro con el IMEI: {IMEI1}";
                }
                return $"No se encontraron registros con el IMEI: {IMEI1}";
            }
            catch (Exception exception)
            {

                return "Se presentó el siguiente error: " + exception.Message;
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public List<Registro> ConsultarListRegistros()
        {
            List<Registro> registros = new List<Registro>();

            try
            {
                connectionManager.Open();
                registros = registroRepository.ConsultarListRegistros();
            }
            catch (Exception exception)
            {

            }
            finally
            {
                connectionManager.Close();
            }
            return registros;
        }
        public ConsultaReponseRegistro ConsultarRegistrosIMEI1(string IMEI1)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseRegistro(registroRepository.ConsultarRegistrosIMEI1(IMEI1));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseRegistro("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public ConsultaReponseRegistro ConsultarRegistrosIMEI2(string IMEI2)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseRegistro(registroRepository.ConsultarRegistrosIMEI2(IMEI2));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseRegistro("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public ConsultaReponseRegistro ConsultarRegistrosIphone(string Iphone)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseRegistro(registroRepository.ConsultarRegistrosIphone(Iphone));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseRegistro("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public ConsultaReponseRegistro ConsultarRegistrosAppleWatch(string AppleWatch)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseRegistro(registroRepository.ConsultarRegistrosAppleWatch(AppleWatch));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseRegistro("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        
        public ConsultaReponseRegistro ConsultarRegistrosColor(string Color)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseRegistro(registroRepository.ConsultarRegistrosColor(Color));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseRegistro("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public ConsultaReponseRegistro ConsultarRegistrosGB(string GB)
        {
            try
            {
                connectionManager.Open();

                return new ConsultaReponseRegistro(registroRepository.ConsultarRegistrosGB(GB));
            }
            catch (Exception exception)
            {
                return new ConsultaReponseRegistro("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }
        }
        public BusquedaReponseRegistro BuscarRegistro(string IMEI1)
        {
            try
            {
                connectionManager.Open();
                if (registroRepository.BuscarRegistroPorIMEI1(IMEI1) == null)
                {
                    return new BusquedaReponseRegistro($"El registro con el IMEI {IMEI1} NO se encuentra guardado");

                }
                else
                {
                    return new BusquedaReponseRegistro(registroRepository.BuscarRegistroPorIMEI1(IMEI1));
                }
            }
            catch (Exception exception)
            {

                return new BusquedaReponseRegistro("Se presentó el siguiente error: " + exception.Message);
            }
            finally
            {
                connectionManager.Close();
            }

        }
    }
    public class ConsultaReponseRegistro
    {
        public List<Registro> Registros { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public ConsultaReponseRegistro(List<Registro> registros)
        {
            Registros = registros;
            Error = false;
        }

        public ConsultaReponseRegistro(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
    public class BusquedaReponseRegistro
    {
        public Registro Registro { get; set; }
        public string Mensaje { get; set; }
        public bool Error { get; set; }

        public BusquedaReponseRegistro(Registro registro)
        {
            Registro = registro;
            Error = false;
        }

        public BusquedaReponseRegistro(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
