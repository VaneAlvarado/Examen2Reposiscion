using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Examen2VanessaAlvaradoSarmiento
{
    public class ClaseCliente
    {
        private static string nombre { get; set; }
        private static string cedula { get; set; }
        private static string direccion { get; set; }
        private static string telefono { get; set; }
        public static string servicio { get; set; }

        private static float costo{ get; set; }
        private static float descuento{ get; set; }
        private static float subtotal { get; set; }
        private static float iva { get; set; }
        private static float total { get; set; }
        public static int factura { get; set; }


        //constructor
        public ClaseCliente(string nom, string ced, string di, string tel, float co, float desc, float st, float i, float t, string ser)
        {
            nombre = nom;
            cedula = ced;
            direccion = di;
            telefono = tel;
            servicio = ser;

            costo = co;
            descuento = desc;
            subtotal = st;
            iva = i;
            total = t;
            factura=0;
        }

      
        public static string GetNombre() { return nombre; }
        public static string GetCedula() { return cedula; }
        public static string GetDireccion() { return direccion; }
        public static string GetTelefono() { return telefono; }
        public static float GetCosto() { return costo; }
        public static float GetDescuento() { return descuento; }
        public static float GetSubtotal() { return subtotal; }
        public static float GetIva() { return iva; }
        public static int GetFactura() { return factura; }
        public static string GetServicio() { return servicio; }



        public static void SetCedula(string ced)
        {
            cedula = ced;
        }
        public static void SetNombre(string nom)
        {
            nombre = nom;
        }
        public static void SetDireccion(string di)
        {
            direccion = di;
        }
        public static void SetTelefono(string tel)
        {
            telefono = tel;
        }
        public static void SetCosto(float co)
        {
            costo = co;
        }
        public static void SetDescuento(float desc)
        {
            descuento = desc;
        }
        public static void SetSubtotal(float st)
        {
            subtotal = st;
        }
        public static void SetIva(float i)
        {
            iva = i;
        }
        public static void SetTotal(float t)
        {
            total = t;
        }
        public static void SetFactura()
        {
           factura++;
        }
       

        public static Boolean ConsultarUsuario()
        {

            return true;
        }
        public static void SetSevicio(string ser)
        {
            servicio = ser;
        }
        public static Boolean AgregarCliente()
        { 
            Boolean existe = false;
            String strConnString = ConfigurationManager.ConnectionStrings["Examen2VanessaAlvaradoConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            try
           {
                con.Open();
                SqlCommand command = new SqlCommand("sp_AgregarCliente", con);
                command.Parameters.Add(new SqlParameter("nombre", nombre));
                command.Parameters.Add(new SqlParameter("cedula", cedula));
                command.Parameters.Add(new SqlParameter("direccion", direccion));
                command.Parameters.Add(new SqlParameter("telefono", telefono));
                command.Parameters.Add(new SqlParameter("costo", costo));
                command.Parameters.Add(new SqlParameter("descuento", descuento));
                command.Parameters.Add(new SqlParameter("subtotal", subtotal));
                command.Parameters.Add(new SqlParameter("iva", iva));
                command.Parameters.Add(new SqlParameter("total", total));
                command.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                existe = true;
           }
           catch (Exception ex)
           {
            }
            finally
            {
              con.Close();
            }
            return existe;
        }
    }
}