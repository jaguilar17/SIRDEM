using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BE_Jugador
    {
        private string codjugador;

        public string Codjugador
        {
            get { return codjugador; }
            set { codjugador = value; }
        }
        private float peso;

        public float Peso
        {
            get { return peso; }
            set { peso = value; }
        }
        private float talla;

        public float Talla
        {
            get { return talla; }
            set { talla = value; }
        }
        private int estadoJugador;

        public int EstadoJugador
        {
            get { return estadoJugador; }
            set { estadoJugador = value; }
        }
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        private int idCodigo;

        public int IdCodigo
        {
            get { return idCodigo; }
            set { idCodigo = value; }
        }

        public BE_Jugador()
        {
            codjugador = "";
            peso = 0.0f;
            talla = 0.0f;
            estadoJugador = 0;
            categoria = "";
            idCodigo = 0;
        }
        public BE_Jugador(string codju, float p, float ta, int est, string cat, int indCo)
        {
            codjugador = codju;
            peso = p;
            talla = ta;
            estadoJugador = est;
            categoria = cat;
            idCodigo = indCo;
        }
    }
}
