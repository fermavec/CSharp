using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazCurso
{

    public interface INotificacion
    {
        void MostrarNotificacion();
        string VerFecha();
    }

    public class Notificacion : INotificacion
    {
        //Variables
        private string enviadoPor;
        private string mensaje;
        private string fecha;

        //Constructor por defecto
        public Notificacion()
        {
            enviadoPor = "Fede";
            mensaje = "Hola";
            fecha = "01.01.2020";
        }

        //Constructor parametrizado
        public Notificacion (string miEnviadoPor, string miMensaje, string miFecha)
        {
            this.enviadoPor = miEnviadoPor;
            this.mensaje = miMensaje;
            this.fecha = miFecha;
        }

        public void MostrarNotificacion()
        {
            Console.WriteLine("El mensaje: {0} - fue enviado por {1} el día {2}", mensaje, enviadoPor, fecha);
        }
        public string VerFecha()
        {
            return fecha;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notificacion n1 = new Notificacion("Fede", "Como va todo?", "25.01.2020");
            Notificacion n2 = new Notificacion("Franco", "Está todo bien", "25.01.2020");

            n1.MostrarNotificacion();
            n2.MostrarNotificacion();
            Console.Read();
        }
    }
}
