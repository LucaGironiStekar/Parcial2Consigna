using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region Atributos
        private string nombre_user;
        private int DNI_user;
        private DateTime fechanacimiento_user;
        #endregion


        #region Propiedades

        public string Vnombre_user
        {
            set { nombre_user = value; }
            get { return nombre_user; }
        }

        public int VDNI_user
        {
            set { DNI_user = value; }
            get { return DNI_user; }
        }

        public DateTime Vfechanacimiento_user
        {
            set { fechanacimiento_user = value; }
            get { return fechanacimiento_user; }
        }

        #endregion


        #region Constructores
        public Usuario()
        { }

        public Usuario(string nomb, int dni, DateTime fechanac)
        {
            nombre_user = nomb;
            DNI_user = dni;
            fechanacimiento_user = fechanac;
        }
        #endregion

        #region Metodos
        public void CalcularEdad(TimeSpan cantidad)
        {

            fechanacimiento_user = fechanacimiento_user - cantidad;

        }
        //Aca debería restarse la fecha ingresada, con la fecha actual de la computadora, pero aún no me salió.

        #endregion

    }
}
