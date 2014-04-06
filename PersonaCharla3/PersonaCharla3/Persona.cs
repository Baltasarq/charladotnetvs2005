using System;
using System.Collections.Generic;
using System.Text;

namespace PersonaCharla3 {
    public class Persona {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Obtener la información textual de la clase
        /// </summary>
        /// <returns>Una cadena con la información</returns>
        public override string ToString()
        {
            return apellidos + ',' + ' ' + nombre + ':' + ' ' + email;
        }

        public Persona(string apellidos, string nombre, string email)
        {
            Apellidos = apellidos;
            Nombre = nombre;
            Email = email;
        }
    }
}
