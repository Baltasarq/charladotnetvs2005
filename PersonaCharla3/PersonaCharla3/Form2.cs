using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonaCharla3 {
    public partial class Form2 : Form {
        Persona persona;

        public Form2(Persona p)
        {
            InitializeComponent();

            persona = p;

            edNombre.Text = p.Nombre;
            edApellidos.Text = p.Apellidos;
            edEmail.Text = p.Email;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            persona.Nombre = edNombre.Text;
            persona.Apellidos = edApellidos.Text;
            persona.Email = edEmail.Text;

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}