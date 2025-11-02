
namespace CapaPresentacion
{
    partial class frClientes
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNombres = new TextBox();
            txtApellidos = new TextBox();
            txtID = new NumericUpDown();
            lnkFoto = new LinkLabel();
            picFoto = new PictureBox();
            ofdFoto = new OpenFileDialog();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            gridDatos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)txtID).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 46);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 92);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Nombres";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 139);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 187);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 3;
            label4.Text = "Foto";
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(134, 92);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(135, 27);
            txtNombres.TabIndex = 5;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(134, 139);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(135, 27);
            txtApellidos.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(134, 46);
            txtID.Name = "txtID";
            txtID.Size = new Size(135, 27);
            txtID.TabIndex = 7;
            // 
            // lnkFoto
            // 
            lnkFoto.AutoSize = true;
            lnkFoto.Location = new Point(25, 223);
            lnkFoto.Name = "lnkFoto";
            lnkFoto.Size = new Size(85, 20);
            lnkFoto.TabIndex = 8;
            lnkFoto.TabStop = true;
            lnkFoto.Text = "Seleccionar";
            lnkFoto.LinkClicked += lnkFoto_LinkClicked;
            // 
            // picFoto
            // 
            picFoto.BackColor = SystemColors.ActiveCaption;
            picFoto.Location = new Point(134, 187);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(175, 181);
            picFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoto.TabIndex = 9;
            picFoto.TabStop = false;
            // 
            // ofdFoto
            // 
            ofdFoto.FileName = "openFileDialog1";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(23, 384);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(122, 34);
            btnNuevo.TabIndex = 10;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(167, 384);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 34);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(318, 384);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 34);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gridDatos
            // 
            gridDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridDatos.Location = new Point(346, 46);
            gridDatos.Name = "gridDatos";
            gridDatos.RowHeadersWidth = 51;
            gridDatos.Size = new Size(725, 314);
            gridDatos.TabIndex = 13;
            gridDatos.CellContentClick += GridDatos_CellContentClick;
            gridDatos.CellDoubleClick += gridDatos_CellDoubleClick;
            // 
            // frClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 430);
            Controls.Add(gridDatos);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(picFoto);
            Controls.Add(lnkFoto);
            Controls.Add(txtID);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombres);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frClientes";
            Text = "Clientes";
            Load += frClientes_Load;
            ((System.ComponentModel.ISupportInitialize)txtID).EndInit();
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        //private void btnEliminar_Click(object sender, EventArgs e) //tuve que volverlo a poner
        //{

        //  }//se me elimino el boton de eliminar y me mandba un error

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNombres;
        private TextBox txtApellidos;
        private NumericUpDown txtID;
        private LinkLabel lnkFoto;
        private PictureBox picFoto;
        private OpenFileDialog ofdFoto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnGuardar;
        private DataGridView gridDatos;
    }
}
