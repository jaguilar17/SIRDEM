using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Microsoft.ApplicationBlocks.Data;

namespace DAO
{
    public class DaoUsuario : DaoB
    {
        protected Conexion con = new Conexion();
        SqlConnection cn;

        public DaoUsuario()
        {
            cn = new SqlConnection(con.StrCon);
        }
        public ClassResultV Usp_PersonaDirectorTecnico_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_PersonaDirectorTecnico_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoUsuario dtoC = new DtoUsuario();
                    dtoC.codUsuario = getValue("codUsuario", reader).Value_String;
                    dtoC.personaDatos = getValue("personaDatos", reader).Value_String;
                    cr.List.Add(dtoC);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar directores tecnicos";
            }
            objCn.Close();
            return cr;
        }
        public ClassResultV Usp_PersonaAsistenteTecnico_GetAll(TipoCons tip)
        {
            ClassResultV cr = new ClassResultV();
            var pr = new SqlParameter[1];
            try
            {
                pr[0] = new SqlParameter("@TipoCons", SqlDbType.Int);
                pr[0].Value = (Int32)tip;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_PersonaAsistenteTecnico_GetAll", pr);
                cr.List = new List<DtoB>();
                while (reader.Read())
                {
                    DtoUsuario dtoC = new DtoUsuario();
                    dtoC.codUsuario = getValue("codUsuario", reader).Value_String;
                    dtoC.personaDatos = getValue("personaDatos", reader).Value_String;
                    cr.List.Add(dtoC);
                }
            }
            catch (Exception ex)
            {
                cr.DT = null;
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al consultar asistentes tecnicos";
            }
            objCn.Close();
            return cr;
        }
        public DtoUsuario Usp_Usuario_Insert(DtoUsuario dtoBase)
        {
            var cr = new ClassResultV();
            var dto = (DtoUsuario)dtoBase;
            var pr = new SqlParameter[14];
            DtoUsuario dtoC = dto;

            try
            {
                //pr[0] = new SqlParameter("@Co_Usuario", SqlDbType.Int);
                //pr[0].Value = dtoC.Co_Usuario;
                pr[0] = new SqlParameter("@codPerfil", SqlDbType.Int);
                pr[0].Value = dtoC.codPerfil;
                pr[1] = new SqlParameter("@usuario", SqlDbType.VarChar, 50);
                pr[1].Value = dtoC.usuario;
                pr[2] = new SqlParameter("@usuarioClave", SqlDbType.VarChar, 50);
                pr[2].Value = dtoC.usuarioClave;
                pr[3] = new SqlParameter("@usuarioNombre", SqlDbType.VarChar, 50);
                pr[3].Value = dtoC.usuarioNombre;
                pr[4] = new SqlParameter("@usuarioApePaterno", SqlDbType.VarChar, 50);
                pr[4].Value = dtoC.usuarioApePaterno;
                pr[5] = new SqlParameter("@usuarioApeMaterno", SqlDbType.VarChar, 50);
                pr[5].Value = dtoC.usuarioApeMaterno;
                pr[6] = new SqlParameter("@usuarioCorreo", SqlDbType.VarChar, 50);
                pr[6].Value = dtoC.usuarioCorreo;
                pr[7] = new SqlParameter("@usuarioDireccion", SqlDbType.VarChar, 100);
                pr[7].Value = dtoC.usuarioDireccion;
                pr[8] = new SqlParameter("@usuarioNumDNI", SqlDbType.Int);
                pr[8].Value = dtoC.usuarioNumDNI;
                pr[9] = new SqlParameter("@usuarioTelefono", SqlDbType.Int);
                pr[9].Value = dtoC.usuarioTelefono;
                pr[10] = new SqlParameter("@usuarioEstado", SqlDbType.Char, 2);
                pr[10].Value = dtoC.usuarioEstado;
                pr[11] = new SqlParameter("@anio", SqlDbType.Char, 4);
                pr[11].Value = dtoC.anio;
                pr[12] = new SqlParameter("@mes", SqlDbType.Char, 2);
                pr[12].Value = dtoC.mes;
                pr[13] = new SqlParameter("@codUsuario", SqlDbType.Char, 9);
                pr[13].Direction = ParameterDirection.Output;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Usuario_Insert", pr);

                dtoC.codUsuario = Convert.ToString(pr[13].Value);
            }
            catch (Exception ex)
            {
                cr.LugarError = ex.StackTrace;
                cr.ErrorEx = ex.Message;
                cr.ErrorMsj = "Error al registrar usuario";
            }

            objCn.Close();
            return dtoC;
        }

        public DtoUsuario iniciarSesion(DtoUsuario objDto_Usuario)
        {
            ClassResultV cr = new ClassResultV();
            DtoUsuario dto = new DtoUsuario();
            dto = objDto_Usuario;
            var pr = new SqlParameter[3];

            DtoUsuario dtoU = new DtoUsuario();

            try
            {
                pr[0] = new SqlParameter("@usuario", SqlDbType.VarChar, 50);
                pr[0].Value = V_ValidaPrNull(dto.usuario);
                pr[1] = new SqlParameter("@usuarioClave", SqlDbType.VarChar, 50);
                pr[1].Value = V_ValidaPrNull(dto.usuarioClave);
                pr[2] = new SqlParameter("@msj", SqlDbType.VarChar, 255);
                pr[2].Direction = ParameterDirection.Output;

                SqlDataReader reader = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_Usuario_Login", pr);

                if (Convert.ToString(pr[2].Value) != string.Empty)
                {
                    dto.LugarError = ToString("Iniciar Sesion");
                    dto.ErrorMsj = Convert.ToString(pr[2].Value);
                }
                else
                {
                    while (reader.Read())
                    {
                        dtoU.codUsuario = reader.GetValue(reader.GetOrdinal("codUsuario")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("codUsuario")));
                        dtoU.codPerfil = reader.GetValue(reader.GetOrdinal("codPerfil")) == DBNull.Value ? 0 : Convert.ToInt32(reader.GetValue(reader.GetOrdinal("codPerfil")));
                        dtoU.usuarioClave = reader.GetValue(reader.GetOrdinal("usuarioClave")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("usuarioClave")));
                        dtoU.usuarioNombre = reader.GetValue(reader.GetOrdinal("usuarioNombre")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("usuarioNombre")));
                        dtoU.usuarioApePaterno = reader.GetValue(reader.GetOrdinal("usuarioApePaterno")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("usuarioApePaterno")));
                        dtoU.usuarioApeMaterno = reader.GetValue(reader.GetOrdinal("usuarioApeMaterno")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("usuarioApeMaterno")));
                        dtoU.usuarioCorreo = reader.GetValue(reader.GetOrdinal("usuarioCorreo")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("usuarioCorreo")));
                        dtoU.usuarioDireccion = reader.GetValue(reader.GetOrdinal("usuarioDireccion")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("usuarioDireccion")));
                        dtoU.usuarioNumDNI = reader.GetValue(reader.GetOrdinal("usuarioNumDNI")) == DBNull.Value ? 0 : Convert.ToInt32(reader.GetValue(reader.GetOrdinal("usuarioNumDNI")));
                        dtoU.usuarioTelefono = reader.GetValue(reader.GetOrdinal("usuarioTelefono")) == DBNull.Value ? 0 : Convert.ToInt32(reader.GetValue(reader.GetOrdinal("usuarioTelefono")));
                        dtoU.usuarioEstado = reader.GetValue(reader.GetOrdinal("usuarioEstado")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("usuarioEstado")));
                        //dtoU.correoElectronico = reader.GetValue(reader.GetOrdinal("correoElectronico")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("correoElectronico")));
                        dtoU.anio = reader.GetValue(reader.GetOrdinal("anio")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("anio")));
                        dtoU.mes = reader.GetValue(reader.GetOrdinal("mes")) == DBNull.Value ? string.Empty : Convert.ToString(reader.GetValue(reader.GetOrdinal("mes")));
                    }
                    reader.Close();

                    List<DtoModuloPadre> dtoListInterfacePadre = new List<DtoModuloPadre>();
                    List<DtoModulo> dtoListInterface = new List<DtoModulo>();
                    try
                    {
                        var pr2 = new SqlParameter[1];
                        pr2[0] = new SqlParameter("@codPerfil", SqlDbType.Int);
                        pr2[0].Value = V_ValidaPrNull(dtoU.codPerfil);

                        SqlDataReader reader2 = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_ListarModuloPadrexPerfil", pr2);

                        while (reader2.Read())
                        {
                            DtoModuloPadre dtoIPAux = new DtoModuloPadre();
                            dtoIPAux.codModuloPadre = reader2.GetValue(reader2.GetOrdinal("codModuloPadre")) == DBNull.Value ? 0 : Convert.ToInt32(reader2.GetValue(reader2.GetOrdinal("codModuloPadre")));
                            dtoIPAux.nombreExterno = reader2.GetValue(reader2.GetOrdinal("nombreExterno")) == DBNull.Value ? string.Empty : Convert.ToString(reader2.GetValue(reader2.GetOrdinal("nombreExterno")));
                            dtoIPAux.descripcion = reader2.GetValue(reader2.GetOrdinal("descripcion")) == DBNull.Value ? string.Empty : Convert.ToString(reader2.GetValue(reader2.GetOrdinal("descripcion")));
                            dtoIPAux.iconoCss = reader2.GetValue(reader2.GetOrdinal("iconoCss")) == DBNull.Value ? string.Empty : Convert.ToString(reader2.GetValue(reader2.GetOrdinal("iconoCss")));

                            dtoListInterfacePadre.Add(dtoIPAux);
                        }
                        reader2.Close();
                    }
                    catch (Exception ex)
                    {
                    }

                    try
                    {
                        var pr3 = new SqlParameter[1];
                        pr3[0] = new SqlParameter("@codPerfil", SqlDbType.Int);
                        pr3[0].Value = V_ValidaPrNull(dtoU.codPerfil);

                        SqlDataReader reader3 = SqlHelper.ExecuteReader(objCn, CommandType.StoredProcedure, "Usp_ListarModuloxPerfil", pr3);

                        while (reader3.Read())
                        {
                            DtoModulo dtoIAux = new DtoModulo();
                            dtoIAux.codModuloPadre = reader3.GetValue(reader3.GetOrdinal("codModuloPadre")) == DBNull.Value ? 0 : Convert.ToInt32(reader3.GetValue(reader3.GetOrdinal("codModuloPadre")));
                            dtoIAux.nombre = reader3.GetValue(reader3.GetOrdinal("nombre")) == DBNull.Value ? string.Empty : Convert.ToString(reader3.GetValue(reader3.GetOrdinal("nombre")));
                            dtoIAux.descripcion = reader3.GetValue(reader3.GetOrdinal("descripcion")) == DBNull.Value ? string.Empty : Convert.ToString(reader3.GetValue(reader3.GetOrdinal("descripcion")));
                            dtoIAux.url = reader3.GetValue(reader3.GetOrdinal("url")) == DBNull.Value ? string.Empty : Convert.ToString(reader3.GetValue(reader3.GetOrdinal("url")));

                            dtoListInterface.Add(dtoIAux);
                        }
                        reader3.Close();
                    }
                    catch (Exception ex)
                    {
                    }

                    dtoU.InterfacesPadre = ordenarListas(dtoListInterfacePadre, dtoListInterface);
                }
            }
            catch (Exception ex)
            {
                cr.List = null;
            }
            return dtoU;
        }

        private List<DtoModuloPadre> ordenarListas(List<DtoModuloPadre> x, List<DtoModulo> y)
        {
            List<DtoModuloPadre> listAux = new List<DtoModuloPadre>();
            DtoModuloPadre objENT_ModuloPadreAux = new DtoModuloPadre();
            int i, j;
            for (i = 0; i < x.Count; i++)
            {
                listAux.Add(x[i]);
                for (j = 0; j < y.Count; j++)
                {
                    if (listAux[i].codModuloPadre == y[j].codModuloPadre)
                    {
                        listAux[i].listaInterfaces.Add(y[j]);
                    }
                }
            }
            return listAux;
        }
       
    }
}

