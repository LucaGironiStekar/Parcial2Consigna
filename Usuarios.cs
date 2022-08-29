using System;


namespace Parcial2Consigna
{
    public class Usuarios
    {
        #region Atributos
        private int nombre_user;
        private string DNI_user;
        private int fechanacimiento_user;
        #endregion

        #region Propiedades

        public int Vcodigo_prod
        {
            set { nombre_user = value; }
            get { return nombre_user; }
        }

        public string Vdescripcion_prod
        {
            set { DNI_user = value; }
            get { return DNI_user; }
        }

        public int Vstock_prod
        {
            get { return fechanacimiento_user; }

        }

        #endregion


        #region Constructores
        public Usuario()
        { }

        public Usuario(int cod, string desc)
        {
            nombre_user = cod;
            DNI_user = desc;
            fechanacimiento_user = 0;
        }
        #endregion

        #region Metodos
        public void IntgresoProd(int cantidad)
        {

            fechanacimiento_user = fechanacimiento_user + cantidad;

        }

        public void SalidaProd(int cantidad)
        {

            fechanacimiento_user = fechanacimiento_user - cantidad;

        }
        #endregion


    }



}

