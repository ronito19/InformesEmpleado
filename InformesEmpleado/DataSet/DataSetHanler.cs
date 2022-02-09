using InformesEmpleado.DataSet.ProyectoDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformesEmpleado.DataSet
{
    class DataSetHanler
    {
        //private static InformeTableAdapter adapter = new InformeTableAdapter();

        private static InformeTableAdapter adapter = new InformeTableAdapter();


        public static DataTable GetByIdDpto(int id_dpto)
        {
            return adapter.GetDataByIdDpto(id_dpto);
        }


        public static DataTable GetByIdProyecto(int id_proyecto)
        {
            return adapter.GetDataByIdProyecto(id_proyecto);
        }



        public static DataTable GetByIdDpto(int id_proyecto, int idDpto)
        {
            return adapter.GetDataByIdProyecto(id_proyecto);
        }

        internal static object GetByIdProyecto(int idProyecto, int idDpto)
        {
            return adapter.GetDataByDptoIdProyecto(idProyecto, idDpto);
        }


        public static DataTable GetByFecha(string fecha1, string fecha2)
        {
            return adapter.GetDataByFecha(fecha1, fecha2);
        }
    }
}
