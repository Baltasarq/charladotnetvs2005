namespace PersonaCharla3 {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.edNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edApellidos = new System.Windows.Forms.TextBox();
            this.edEmail = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point( 7, 24 );
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size( 75, 23 );
            this.button1.TabIndex = 0;
            this.button1.Text = "&Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler( this.button1_Click );
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point( 7, 69 );
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size( 75, 23 );
            this.button2.TabIndex = 1;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler( this.button2_Click );
            // 
            // edNombre
            // 
            this.edNombre.Location = new System.Drawing.Point( 76, 19 );
            this.edNombre.Name = "edNombre";
            this.edNombre.Size = new System.Drawing.Size( 188, 20 );
            this.edNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 16, 22 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 44, 13 );
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add( this.edEmail );
            this.groupBox1.Controls.Add( this.edApellidos );
            this.groupBox1.Controls.Add( this.label3 );
            this.groupBox1.Controls.Add( this.label2 );
            this.groupBox1.Controls.Add( this.edNombre );
            this.groupBox1.Controls.Add( this.label1 );
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point( 0, 0 );
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size( 364, 140 );
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Persona";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 16, 57 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 49, 13 );
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 16, 94 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 32, 13 );
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // edApellidos
            // 
            this.edApellidos.Location = new System.Drawing.Point( 76, 54 );
            this.edApellidos.Name = "edApellidos";
            this.edApellidos.Size = new System.Drawing.Size( 188, 20 );
            this.edApellidos.TabIndex = 6;
            // 
            // edEmail
            // 
            this.edEmail.Location = new System.Drawing.Point( 76, 91 );
            this.edEmail.Name = "edEmail";
            this.edEmail.Size = new System.Drawing.Size( 188, 20 );
            this.edEmail.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.button1 );
            this.panel1.Controls.Add( this.button2 );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point( 270, 0 );
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size( 94, 140 );
            this.panel1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 364, 140 );
            this.Controls.Add( this.panel1 );
            this.Controls.Add( this.groupBox1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout( false );
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout( false );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox edNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edEmail;
        private System.Windows.Forms.TextBox edApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}