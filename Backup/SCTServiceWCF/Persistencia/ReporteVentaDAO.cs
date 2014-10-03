using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using SCTServiceWCF.Dominio;
using NHibernate;


namespace SCTServiceWCF.Persistencia.AccesoDatos
{
    public class ReporteDAO : BaseDAO<ReporteVenta, int>
    {
        public List<ReporteVenta> ListarReporteVentas()
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                IQuery query = sesion.CreateSQLQuery("exec T_SCT_SP_CHART_VENTAS");
                //query.SetInt32("CategoryId", 1);
                return null;
            }
        }





        //public List<ReporteVenta> ListarReporteVentas()
        //{
        //    List<ReporteVenta> todos = new List<ReporteVenta>();
        //    ReporteVenta encontrado = null;
        //    //List<object> lstEntity = new List<object>();
        //    string sql = "T_SCT_SP_CHART_VENTAS";
        //    using (SqlConnection con = new SqlConnection(ConexionUtil.ObtenerCadena()))
        //    {
        //        con.Open();
        //        using (SqlCommand com = new SqlCommand(sql, con))
        //        {
        //            com.CommandType = CommandType.StoredProcedure;
        //            using (SqlDataReader resultado = com.ExecuteReader())
        //            {
        //                while (resultado.Read())
        //                {
        //                    encontrado = new ReporteVenta()
        //                    {
        //                        ID_TARIFA = (int)resultado["ID_TARIFA"],
        //                        NOM_TARIFA = (string)resultado["NOM_TARIFA"],
        //                        PRECIO = (decimal)resultado["PRECIO"],
        //                        MONEDA = (string)resultado["MONEDA"]
        //                    };
        //                    todos.Add(encontrado);
        //                }

        //                //while (resultado.Read())
        //                //{
        //                //    Dictionary<string, object> values = new Dictionary<string, object>();
        //                //    for (int i = 0; i < resultado.FieldCount; i++)
        //                //    {
        //                //        values.Add(resultado.GetName(i), resultado[i]);
        //                //    }
        //                //    lstEntity.Add(values);
        //                //}

        //            }
        //        }
        //    }
        //    return todos;
        //}

   }
}