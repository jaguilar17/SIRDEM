using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace WebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RegistrarRutas();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        public void RegistrarRutas()
        {
            try
            {
                //Usuario
                RouteTable.Routes.MapPageRoute("usuarioPrincipal", "{nombreUsuario}", "~/contenido/principal.aspx", true);
                //RouteTable.Routes.MapPageRoute("bienvenida", "{nombreUsuario}/bienvenida", "~/contenido/Bienvenida.aspx", true);
                RouteTable.Routes.MapPageRoute("bienvenida", "appPlantilla/{nombreUsuario}/bienvenida", "~/contenido/Bienvenida.aspx", true);

                RouteTable.Routes.MapPageRoute("registrarJugador", "{nombreUsuario}/jugador/nuevo-jugador", "~/contenido/jugador/frm_JugadorRegistrar.aspx", true);

                //Personal
                RouteTable.Routes.MapPageRoute("registrarPersonal", "{nombreUsuario}/personal/nuevo-personal", "~/contenido/personal/frm_PersonaRegistrar.aspx", true);

                //Temporada
                RouteTable.Routes.MapPageRoute("registrarTemporada", "{nombreUsuario}/temporada/nueva-temporada", "~/contenido/temporada/frm_TemporadaRegistrar.aspx", true);

                //Equipo
                RouteTable.Routes.MapPageRoute("registrarEquipo", "{nombreUsuario}/equipo/nuevo-equipo", "~/contenido/equipo/frm_EquipoRegistrar.aspx", true);

                //Antropometria
                RouteTable.Routes.MapPageRoute("registrarAntropometria", "{nombreUsuario}/antropometria/consulta-jugador", "~/contenido/antropometria/frm_VerTodosJugadores.aspx", true);

                //Administrador
                RouteTable.Routes.MapPageRoute("administrarAsistencia", "{nombreUsuario}/asistencia/nueva-Asistencia", "~/Asistencia.aspx", true);
                RouteTable.Routes.MapPageRoute("modificarAsistencia", "{nombreUsuario}/asistencia/modificar-Asistencia", "~/ModificarAsistencia.aspx", true);
                RouteTable.Routes.MapPageRoute("administrarHorario", "{nombreUsuario}/entrenamiento/horario", "~/Calendario/frm_Calendario.aspx", true);
                //RouteTable.Routes.MapPageRoute("administrarHorario", "{nombreUsuario}/entrenamiento/horario", "~/Calendariov2/Default.aspx", true);
                
                //Pruebas
                RouteTable.Routes.MapPageRoute("administrarPrueba", "{nombreUsuario}/prueba/administrar", "~/contenido/pruebas/AdmPruebas.aspx", true);
                RouteTable.Routes.MapPageRoute("registrarJugadorConvocatoria", "{nombreUsuario}/prueba/jugador", "~/contenido/pruebas/frm_JugadorConvocatoriaRegistrar.aspx", true);
                //frm_JugadorConvocatoriaRegistrar.aspx

                ////RouteTable.Routes.MapPageRoute("administrarPruebaDesempeño", "{nombreUsuario}/prueba/prueba-desempeño", "~/PruebaDesempeño.aspx", true);

                ////Usuario
                //RouteTable.Routes.MapPageRoute("usuarioPrincipal", "{nombreUsuario}", "~/contenido/principal.aspx", true);
                //RouteTable.Routes.MapPageRoute("bienvenida", "{nombreUsuario}/bienvenida", "~/contenido/Bienvenida.aspx", true);
                //RouteTable.Routes.MapPageRoute("registrarUsuario", "{nombreUsuario}/usuarios/nuevo-usuario", "~/contenido/usuario/frm_UsuarioRegistro.aspx", true);

                ////Administrador
                //RouteTable.Routes.MapPageRoute("administrarJugador", "{nombreUsuario}/jugadores/nuevo-jugador", "~/contenido/jugador/frm_JugadorAdministrar.aspx", true);
                //RouteTable.Routes.MapPageRoute("consultarReporteProducto", "{nombreUsuario}/torneos/nuevo-torneo", "~/contenido/torneos/frm_TorneoAdministrar.aspx", true);
                //RouteTable.Routes.MapPageRoute("consultarPersona", "{nombreUsuario}/persona/consultar-persona", "~/contenido/jugador/frm_JugadorConsultar.aspx", true);
                //RouteTable.Routes.MapPageRoute("administrarAsistencia", "{nombreUsuario}/asistencia/nueva-Asistencia", "~/Asistencia.aspx", true);
                //RouteTable.Routes.MapPageRoute("modificarAsistencia", "{nombreUsuario}/asistencia/modificar-Asistencia", "~/ModificarAsistencia.aspx", true);
                //RouteTable.Routes.MapPageRoute("administrarHorario", "{nombreUsuario}/entrenamiento/horario", "~/HorarioMenu.aspx", true);

                ////Gerente
                //RouteTable.Routes.MapPageRoute("reporteEstadisticas", "{nombreUsuario}/reportes/estadistica", "~/contenido/reporteEstadisticas/frm_estadisticasReporte.aspx", true);

                ////Equipo
                //RouteTable.Routes.MapPageRoute("equipo", "{nombreUsuario}/equipo/nuevo-equipo", "~/contenido/equipo/frm_Equipo.aspx", true);

                ////Categoria de Torneo
                //RouteTable.Routes.MapPageRoute("categoriaTorneo", "{nombreUsuario}/categoria/nueva-categoria", "~/contenido/categoria/frm_Categoria.aspx", true);

                ////Torneo
                //RouteTable.Routes.MapPageRoute("torneo", "{nombreUsuario}/torneo/nuevo-torneo", "~/contenido/torneo/frm_Torneo.aspx", true);

                ////Pruebas
                //RouteTable.Routes.MapPageRoute("administrarPrueba", "{nombreUsuario}/prueba/prueba", "~/Administrar_Prueba.aspx", true);
                ////RouteTable.Routes.MapPageRoute("administrarPruebaDesempeño", "{nombreUsuario}/prueba/prueba-desempeño", "~/PruebaDesempeño.aspx", true);

                ////Sedes
                //RouteTable.Routes.MapPageRoute("sede", "{nombreUsuario}/sede/nuevas-sedes", "~/contenido/sede/frm_Sede.aspx", true);

                ////Pagos
                //RouteTable.Routes.MapPageRoute("pago", "{nombreUsuario}/pago/nuevo-pago", "~/contenido/pago/frm_JugadorConsultaPago3.aspx", true);
                //RouteTable.Routes.MapPageRoute("pagoCancelado", "{nombreUsuario}/pagoCancelado/pago-cancelado", "~/contenido/pago/frm_JugadorConsultaPagoCancelado.aspx", true);

            }
            catch
            {

            }
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}