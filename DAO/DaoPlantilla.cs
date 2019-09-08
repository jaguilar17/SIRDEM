using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.ApplicationBlocks.Data;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DaoPlantilla : DaoB
    {
        public ClassResultV Usp_Plantilla_Insert(DtoPlantilla dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoPlantilla)dtoBase;
            var pr = new SqlParameter[4];

            try
            {
                pr[0] = new SqlParameter("@codEquipo", SqlDbType.VarChar, 4);
                pr[0].Value = dto.codEquipo;
                pr[1] = new SqlParameter("@codJugador", SqlDbType.Char, 9);
                pr[1].Value = dto.codJugador;
                pr[2] = new SqlParameter("@IB_Mostrar", SqlDbType.Bit);
                pr[2].Value = dto.IB_Mostrar;
                pr[3] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[3].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_Plantilla_Insert", pr);
                if (Convert.ToString(pr[3].Value) != "")
                {
                    cr.LugarError = ToString("Usp_Plantilla_Insert");
                    cr.ErrorMsj = Convert.ToString(pr[3].Value);
                }
                else { }

            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar plantillas";
            }

            objCn.Close();
            return cr;
        }

        public ClassResultV Usp_PlantillaxEquipo_GetAll(DtoB dtoBase)
        {
            ClassResultV cr = new ClassResultV();
            var dto = (DtoPlantilla)dtoBase;
            var pr = new SqlParameter[3];
            try
            {
                pr[0] = new SqlParameter("@codEquipo", SqlDbType.VarChar, 4);
                pr[0].Value = V_ValidaPrNull(dto.codEquipo);

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_PlantillaxEquipo_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoPlantilla dtoP = new DtoPlantilla();
                    dtoP.codPlantilla = getValue("codPlantilla", reader).Value_String;
                    dtoP.codEquipo = getValue("codEquipo", reader).Value_String;
                    dtoP.nombreCompleto = getValue("nombreCompleto", reader).Value_String;
                    dtoP.descripcionPosicion = getValue("Posicion", reader).Value_String;
                    dtoP.peso = getValue("pesoInicial", reader).Value_String;
                    dtoP.talla = getValue("tallaInicial", reader).Value_String;
                    dtoP.codJugador = getValue("codJugador", reader).Value_String;


                    /*
                     TPo.descripcionPosicion [Posicion]
, TJ.pesoInicial, TJ.tallaInicial
                     
                     */
                    cr.List.Add(dtoP);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar plantillas";
            }
            objCn.Close();
            return cr;
        }

        public ClassResultV Usp_TotalJugadores_GetAll()
        {
            ClassResultV cr = new ClassResultV();
            try
            {
                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_TotalJugadores_GetAll");
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoPlantilla dtoS = new DtoPlantilla();
                    dtoS.codPlantilla = getValue("codPlantilla", reader).Value_String;
                    dtoS.codEquipo = getValue("codEquipo", reader).Value_String;
                    dtoS.equipoNombre = getValue("equipoNombre", reader).Value_String;
                    dtoS.codJugador = getValue("codJugador", reader).Value_String;
                    dtoS.nombreCompleto = getValue("nombreCompleto", reader).Value_String;
                    dtoS.descripcionPosicion = getValue("descripcionPosicion", reader).Value_String;
                    cr.List.Add(dtoS);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar todos los jugadores";
            }
            objCn.Close();
            return cr;
        }
    }
}
