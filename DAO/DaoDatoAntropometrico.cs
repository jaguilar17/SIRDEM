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
    public class DaoDatoAntropometrico : DaoB
    {
        public ClassResultV Usp_DatosAntropometrico_Insert(DtoDatoAntropometrico dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoDatoAntropometrico)dtoBase;
            var pr = new SqlParameter[21];
            try
            {
                pr[0] = new SqlParameter("@brazoPerimetro", SqlDbType.Decimal);
                pr[0].Value = V_ValidaPrNull(dto.brazoPerimetro);
                pr[1] = new SqlParameter("@pechoPerimetro", SqlDbType.Decimal);
                pr[1].Value = V_ValidaPrNull(dto.pechoPerimetro);
                pr[2] = new SqlParameter("@abdomenPerimetro", SqlDbType.Decimal);
                pr[2].Value = V_ValidaPrNull(dto.abdomenPerimetro);
                pr[3] = new SqlParameter("@caderaPerimetro", SqlDbType.Decimal);
                pr[3].Value = V_ValidaPrNull(dto.caderaPerimetro);
                pr[4] = new SqlParameter("@musloPerimetro", SqlDbType.Decimal);
                pr[4].Value = V_ValidaPrNull(dto.musloPerimetro);
                pr[5] = new SqlParameter("@gemeloPerimetro", SqlDbType.Decimal);
                pr[5].Value = V_ValidaPrNull(dto.gemeloPerimetro);
                pr[6] = new SqlParameter("@humeroLongitud", SqlDbType.Decimal);
                pr[6].Value = V_ValidaPrNull(dto.humeroLongitud);
                pr[7] = new SqlParameter("@femurLongitud", SqlDbType.Decimal);
                pr[7].Value = V_ValidaPrNull(dto.femurLongitud);
                pr[8] = new SqlParameter("@munecaLongitud", SqlDbType.Decimal);
                pr[8].Value = V_ValidaPrNull(dto.munecaLongitud);
                pr[9] = new SqlParameter("@triceps", SqlDbType.Decimal);
                pr[9].Value = V_ValidaPrNull(dto.triceps);
                pr[10] = new SqlParameter("@musloPliegues", SqlDbType.Decimal);
                pr[10].Value = V_ValidaPrNull(dto.musloPerimetro);
                pr[11] = new SqlParameter("@supraespinal", SqlDbType.Decimal);
                pr[11].Value = V_ValidaPrNull(dto.supraespinal);
                pr[12] = new SqlParameter("@pectoral", SqlDbType.Decimal);
                pr[12].Value = V_ValidaPrNull(dto.pectoral);
                pr[13] = new SqlParameter("@abdominal", SqlDbType.Decimal);
                pr[13].Value = V_ValidaPrNull(dto.abdominal);
                pr[14] = new SqlParameter("@gemeloPliegues", SqlDbType.Decimal);
                pr[14].Value = V_ValidaPrNull(dto.gemeloPliegues);
                pr[15] = new SqlParameter("@tallaJug", SqlDbType.Decimal);
                pr[15].Value = V_ValidaPrNull(dto.tallaJug);
                pr[16] = new SqlParameter("@pesoJug", SqlDbType.Decimal);
                pr[16].Value = V_ValidaPrNull(dto.pesoJug);
                pr[17] = new SqlParameter("@codJugador", SqlDbType.Char, 9);
                pr[17].Value = dto.codJugador;
                pr[18] = new SqlParameter("@fechaControl", SqlDbType.Date);
                pr[18].Value = dto.fechaControl;
                pr[19] = new SqlParameter("@msj", SqlDbType.VarChar, 100);
                pr[19].Direction = ParameterDirection.Output;
                pr[20] = new SqlParameter("@codDatosAntropo", SqlDbType.VarChar, 4);
                pr[20].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(objCn, CommandType.StoredProcedure, "Usp_DatosAntropometrico_Insert", pr);
                dto.codDatosAntropo = Convert.ToString(pr[20].Value);
                if (Convert.ToString(pr[19].Value) != "")
                {
                    cr.LugarError = ToString("Usp_DatosAntropometrico_Insert");
                    cr.ErrorMsj = Convert.ToString(pr[19].Value);
                }
                else { }

            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar datos antropometricos";
            }

            objCn.Close();
            return cr;
        }
    }
}
