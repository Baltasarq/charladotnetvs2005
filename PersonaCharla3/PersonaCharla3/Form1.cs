using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Xml;

namespace PersonaCharla3 {
    public partial class Form1 : Form {
        public const string NomArchivoDatos = "personas.dat";
        public const string EtqPersonas = "PERSONAS";
        public const string EtqPersona = "PERSONA";
        public const string EtqNombre = "NOMBRE";
        public const string EtqApellidos = "APELLIDOS";
        public const string EtqEmail = "EMAIL";

        private ArrayList vPersonas;

        public Form1()
        {
            InitializeComponent();
            Text = "Agenda de personas";
            MinimumSize = new Size( Size.Width, Size.Height );
            barraProgreso.Visible = false;

            vPersonas = new ArrayList();
            ponEstado( "Preparado..." );

            cargar();
        }

        private void cargar()
        {
            XmlDocument docXml = new XmlDocument();
            docXml.Load( NomArchivoDatos );
            ponProgresoInic( "Cargando ...", 0, docXml.DocumentElement.ChildNodes.Count );

            foreach ( XmlNode nodo in docXml.DocumentElement.ChildNodes ) {
                Persona p = new Persona( "", "", "" );

                foreach ( XmlAttribute atr in nodo.Attributes ) {
                    if ( atr.Name.ToUpper() == EtqNombre ) {
                        p.Nombre = atr.InnerText;
                    }
                    else
                    if ( atr.Name.ToUpper() == EtqApellidos ) {
                        p.Apellidos = atr.InnerText;
                    }
                    else
                    if ( atr.Name.ToUpper() == EtqEmail ) {
                        p.Email = atr.InnerText;
                    }
                }

                ponProgresoInc();
                vPersonas.Add( p );
                listBox1.Items.Add( p.ToString() );
            }

            ponProgresoFin();
        }

        private void ponEstado(string p)
        {
            etqEstado.Text = p;
        }

        public void ponProgresoInic(string msg, int inicio, int final)
        {
            ponEstado( msg );

            barraProgreso.Visible = true;
            barraProgreso.Minimum = inicio;
            barraProgreso.Maximum = final;
            this.Enabled = false;
        }

        public void ponProgresoInc()
        {
            barraProgreso.PerformStep();
        }

        public void ponProgresoFin()
        {
            this.Enabled = true;
            barraProgreso.Visible = false;

            ponEstado( "Preparado..." );
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona p = new Persona( "Palotes", "Perico", "perico@palotes.com" );
            listBox1.Items.Add( p.ToString() );
            vPersonas.Add( p );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int pos = listBox1.SelectedIndex;

            if ( pos >= 0 ) {
                Persona p = ( Persona ) vPersonas[ pos ];

                Form2 editar = new Form2( p );
                editar.ShowDialog( this );

                listBox1.Items[ pos ] = p.ToString();
            } else MessageBox.Show( "No hay personas o no se ha seleccionado ninguno." );
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            save();
        }

        private void save()
        {
            XmlNode nodo;
            XmlNode nodoPpal;
            XmlAttribute atr;

            // Inicio
            XmlDocument docXml = new XmlDocument();
            ponProgresoInic( "Guardando ...", 0, vPersonas.Count );

            nodo = docXml.CreateNode( XmlNodeType.XmlDeclaration, "xml", "" );
            ( ( XmlDeclaration ) nodo ).Encoding = "iso-8859-1";
            docXml.AppendChild( nodo );

            nodoPpal = docXml.CreateNode( XmlNodeType.Element, EtqPersonas, "" );
            docXml.AppendChild( nodoPpal );

            foreach ( Persona p in vPersonas ) {
                nodo = docXml.CreateNode( XmlNodeType.Element, EtqPersona, "" );

                atr = docXml.CreateAttribute( EtqNombre );
                atr.InnerText = p.Nombre;
                nodo.Attributes.Append( atr );

                atr = docXml.CreateAttribute( EtqApellidos );
                atr.InnerText = p.Apellidos;
                nodo.Attributes.Append( atr );

                atr = docXml.CreateAttribute( EtqEmail );
                atr.InnerText = p.Email;
                nodo.Attributes.Append( atr );

                nodoPpal.AppendChild( nodo );
                ponProgresoInc();
            }


            // Final
            docXml.Save( NomArchivoDatos );
            ponProgresoFin();
        }
    }
}