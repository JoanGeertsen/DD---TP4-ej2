namespace DD_TP3_ej2
{
    partial class FFiguras
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
            components = new System.ComponentModel.Container();
            pCreacion = new Panel();
            gbRectangulo = new GroupBox();
            tLado2 = new TextBox();
            label7 = new Label();
            tLado1 = new TextBox();
            label6 = new Label();
            gbTriangulo = new GroupBox();
            tLado3Triangulo = new TextBox();
            label5 = new Label();
            tLado2Triangulo = new TextBox();
            label4 = new Label();
            tLado1Triangulo = new TextBox();
            label3 = new Label();
            bAgregar = new Button();
            gbFigura = new GroupBox();
            rbRectangulo = new RadioButton();
            rbTriangulo = new RadioButton();
            rbCuadrado = new RadioButton();
            rbCirculo = new RadioButton();
            gbCuadrado = new GroupBox();
            label1 = new Label();
            tLadoCuadrado = new TextBox();
            gbCirculo = new GroupBox();
            tRadioCirculo = new TextBox();
            label2 = new Label();
            lbFiguras = new ListBox();
            bArea = new Button();
            bPerimetro = new Button();
            lCantidadCuadrados = new Label();
            lCantidadFiguras = new Label();
            bCerrar = new Button();
            lCantidadCirculos = new Label();
            lCantidadTriangulos = new Label();
            lCantidadRectangulos = new Label();
            errorProvider = new ErrorProvider(components);
            pCreacion.SuspendLayout();
            gbRectangulo.SuspendLayout();
            gbTriangulo.SuspendLayout();
            gbFigura.SuspendLayout();
            gbCuadrado.SuspendLayout();
            gbCirculo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // pCreacion
            // 
            pCreacion.BackColor = Color.PaleGreen;
            pCreacion.Controls.Add(gbRectangulo);
            pCreacion.Controls.Add(gbTriangulo);
            pCreacion.Controls.Add(bAgregar);
            pCreacion.Controls.Add(gbFigura);
            pCreacion.Controls.Add(gbCuadrado);
            pCreacion.Controls.Add(gbCirculo);
            pCreacion.Location = new Point(12, 12);
            pCreacion.Name = "pCreacion";
            pCreacion.Size = new Size(410, 151);
            pCreacion.TabIndex = 0;
            // 
            // gbRectangulo
            // 
            gbRectangulo.Controls.Add(tLado2);
            gbRectangulo.Controls.Add(label7);
            gbRectangulo.Controls.Add(tLado1);
            gbRectangulo.Controls.Add(label6);
            gbRectangulo.Location = new Point(170, 8);
            gbRectangulo.Name = "gbRectangulo";
            gbRectangulo.Size = new Size(214, 96);
            gbRectangulo.TabIndex = 6;
            gbRectangulo.TabStop = false;
            gbRectangulo.Text = "Rectangulo";
            // 
            // tLado2
            // 
            tLado2.Location = new Point(82, 55);
            tLado2.Name = "tLado2";
            tLado2.Size = new Size(100, 23);
            tLado2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 59);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 2;
            label7.Text = "Lado2:";
            // 
            // tLado1
            // 
            tLado1.Location = new Point(82, 26);
            tLado1.Name = "tLado1";
            tLado1.Size = new Size(100, 23);
            tLado1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 30);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 0;
            label6.Text = "Lado1:";
            // 
            // gbTriangulo
            // 
            gbTriangulo.Controls.Add(tLado3Triangulo);
            gbTriangulo.Controls.Add(label5);
            gbTriangulo.Controls.Add(tLado2Triangulo);
            gbTriangulo.Controls.Add(label4);
            gbTriangulo.Controls.Add(tLado1Triangulo);
            gbTriangulo.Controls.Add(label3);
            gbTriangulo.Location = new Point(176, 8);
            gbTriangulo.Name = "gbTriangulo";
            gbTriangulo.Size = new Size(214, 96);
            gbTriangulo.TabIndex = 11;
            gbTriangulo.TabStop = false;
            gbTriangulo.Text = "Triangulo";
            gbTriangulo.Visible = false;
            // 
            // tLado3Triangulo
            // 
            tLado3Triangulo.Location = new Point(76, 68);
            tLado3Triangulo.Name = "tLado3Triangulo";
            tLado3Triangulo.Size = new Size(100, 23);
            tLado3Triangulo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 70);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Lado3:";
            // 
            // tLado2Triangulo
            // 
            tLado2Triangulo.Location = new Point(76, 43);
            tLado2Triangulo.Name = "tLado2Triangulo";
            tLado2Triangulo.Size = new Size(100, 23);
            tLado2Triangulo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 46);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 2;
            label4.Text = "Lado2:";
            // 
            // tLado1Triangulo
            // 
            tLado1Triangulo.Location = new Point(76, 17);
            tLado1Triangulo.Name = "tLado1Triangulo";
            tLado1Triangulo.Size = new Size(100, 23);
            tLado1Triangulo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 20);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 0;
            label3.Text = "Lado1:";
            // 
            // bAgregar
            // 
            bAgregar.Location = new Point(321, 114);
            bAgregar.Name = "bAgregar";
            bAgregar.Size = new Size(75, 34);
            bAgregar.TabIndex = 5;
            bAgregar.Text = "&Agregar";
            bAgregar.UseVisualStyleBackColor = true;
            bAgregar.Click += bAgregar_Click;
            // 
            // gbFigura
            // 
            gbFigura.Controls.Add(rbRectangulo);
            gbFigura.Controls.Add(rbTriangulo);
            gbFigura.Controls.Add(rbCuadrado);
            gbFigura.Controls.Add(rbCirculo);
            gbFigura.Location = new Point(12, 12);
            gbFigura.Name = "gbFigura";
            gbFigura.Size = new Size(103, 125);
            gbFigura.TabIndex = 1;
            gbFigura.TabStop = false;
            gbFigura.Text = "Figura";
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Checked = true;
            rbRectangulo.Location = new Point(6, 97);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(85, 19);
            rbRectangulo.TabIndex = 3;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectangulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            rbRectangulo.CheckedChanged += rbRectangulo_CheckedChanged;
            // 
            // rbTriangulo
            // 
            rbTriangulo.AutoSize = true;
            rbTriangulo.Location = new Point(6, 72);
            rbTriangulo.Name = "rbTriangulo";
            rbTriangulo.Size = new Size(74, 19);
            rbTriangulo.TabIndex = 2;
            rbTriangulo.Text = "Triangulo";
            rbTriangulo.UseVisualStyleBackColor = true;
            rbTriangulo.CheckedChanged += rbTriangulo_CheckedChanged;
            // 
            // rbCuadrado
            // 
            rbCuadrado.AutoSize = true;
            rbCuadrado.Location = new Point(6, 47);
            rbCuadrado.Name = "rbCuadrado";
            rbCuadrado.Size = new Size(77, 19);
            rbCuadrado.TabIndex = 1;
            rbCuadrado.Text = "Cuadrado";
            rbCuadrado.UseVisualStyleBackColor = true;
            rbCuadrado.CheckedChanged += rbCuadrado_CheckedChanged;
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(6, 22);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(63, 19);
            rbCirculo.TabIndex = 0;
            rbCirculo.Text = "Circulo";
            rbCirculo.UseVisualStyleBackColor = true;
            rbCirculo.CheckedChanged += rbCirculo_CheckedChanged;
            // 
            // gbCuadrado
            // 
            gbCuadrado.Controls.Add(label1);
            gbCuadrado.Controls.Add(tLadoCuadrado);
            gbCuadrado.Location = new Point(182, 12);
            gbCuadrado.Name = "gbCuadrado";
            gbCuadrado.Size = new Size(214, 96);
            gbCuadrado.TabIndex = 4;
            gbCuadrado.TabStop = false;
            gbCuadrado.Text = "Cuadrado";
            gbCuadrado.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 47);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado:";
            // 
            // tLadoCuadrado
            // 
            tLadoCuadrado.Location = new Point(76, 44);
            tLadoCuadrado.Name = "tLadoCuadrado";
            tLadoCuadrado.Size = new Size(100, 23);
            tLadoCuadrado.TabIndex = 1;
            // 
            // gbCirculo
            // 
            gbCirculo.Controls.Add(tRadioCirculo);
            gbCirculo.Controls.Add(label2);
            gbCirculo.Location = new Point(182, 8);
            gbCirculo.Name = "gbCirculo";
            gbCirculo.Size = new Size(214, 96);
            gbCirculo.TabIndex = 5;
            gbCirculo.TabStop = false;
            gbCirculo.Text = "Circulo";
            gbCirculo.Visible = false;
            // 
            // tRadioCirculo
            // 
            tRadioCirculo.Location = new Point(76, 34);
            tRadioCirculo.Name = "tRadioCirculo";
            tRadioCirculo.Size = new Size(100, 23);
            tRadioCirculo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 38);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Radio:";
            // 
            // lbFiguras
            // 
            lbFiguras.FormattingEnabled = true;
            lbFiguras.ItemHeight = 15;
            lbFiguras.Location = new Point(24, 169);
            lbFiguras.Name = "lbFiguras";
            lbFiguras.Size = new Size(301, 169);
            lbFiguras.TabIndex = 1;
            // 
            // bArea
            // 
            bArea.Location = new Point(333, 169);
            bArea.Name = "bArea";
            bArea.Size = new Size(75, 34);
            bArea.TabIndex = 6;
            bArea.Text = "&Area";
            bArea.UseVisualStyleBackColor = true;
            bArea.Click += bArea_Click;
            // 
            // bPerimetro
            // 
            bPerimetro.Location = new Point(333, 209);
            bPerimetro.Name = "bPerimetro";
            bPerimetro.Size = new Size(75, 34);
            bPerimetro.TabIndex = 7;
            bPerimetro.Text = "&Perímetro";
            bPerimetro.UseVisualStyleBackColor = true;
            bPerimetro.Click += bPerimetro_Click;
            // 
            // lCantidadCuadrados
            // 
            lCantidadCuadrados.AutoSize = true;
            lCantidadCuadrados.Location = new Point(31, 348);
            lCantidadCuadrados.Name = "lCantidadCuadrados";
            lCantidadCuadrados.Size = new Size(143, 15);
            lCantidadCuadrados.TabIndex = 8;
            lCantidadCuadrados.Text = "Cantidad de Cuadrados: 0";
            lCantidadCuadrados.Visible = false;
            // 
            // lCantidadFiguras
            // 
            lCantidadFiguras.AutoSize = true;
            lCantidadFiguras.Location = new Point(31, 369);
            lCantidadFiguras.Name = "lCantidadFiguras";
            lCantidadFiguras.Size = new Size(124, 15);
            lCantidadFiguras.TabIndex = 9;
            lCantidadFiguras.Text = "Cantidad de Figuras: 0";
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(333, 348);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(75, 34);
            bCerrar.TabIndex = 10;
            bCerrar.Text = "&Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // lCantidadCirculos
            // 
            lCantidadCirculos.AutoSize = true;
            lCantidadCirculos.Location = new Point(31, 349);
            lCantidadCirculos.Name = "lCantidadCirculos";
            lCantidadCirculos.Size = new Size(129, 15);
            lCantidadCirculos.TabIndex = 11;
            lCantidadCirculos.Text = "Cantidad de Circulos: 0";
            lCantidadCirculos.Visible = false;
            // 
            // lCantidadTriangulos
            // 
            lCantidadTriangulos.AutoSize = true;
            lCantidadTriangulos.Location = new Point(34, 349);
            lCantidadTriangulos.Name = "lCantidadTriangulos";
            lCantidadTriangulos.Size = new Size(140, 15);
            lCantidadTriangulos.TabIndex = 12;
            lCantidadTriangulos.Text = "Cantidad de Triangulos: 0";
            lCantidadTriangulos.Visible = false;
            // 
            // lCantidadRectangulos
            // 
            lCantidadRectangulos.AutoSize = true;
            lCantidadRectangulos.Location = new Point(31, 349);
            lCantidadRectangulos.Name = "lCantidadRectangulos";
            lCantidadRectangulos.Size = new Size(151, 15);
            lCantidadRectangulos.TabIndex = 13;
            lCantidadRectangulos.Text = "Cantidad de Rectangulos: 0";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FFiguras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 394);
            Controls.Add(lCantidadRectangulos);
            Controls.Add(lCantidadTriangulos);
            Controls.Add(lCantidadCirculos);
            Controls.Add(bCerrar);
            Controls.Add(lCantidadFiguras);
            Controls.Add(lCantidadCuadrados);
            Controls.Add(bPerimetro);
            Controls.Add(bArea);
            Controls.Add(lbFiguras);
            Controls.Add(pCreacion);
            Name = "FFiguras";
            Text = "Figuras";
            Shown += FFiguras_Shown;
            pCreacion.ResumeLayout(false);
            gbRectangulo.ResumeLayout(false);
            gbRectangulo.PerformLayout();
            gbTriangulo.ResumeLayout(false);
            gbTriangulo.PerformLayout();
            gbFigura.ResumeLayout(false);
            gbFigura.PerformLayout();
            gbCuadrado.ResumeLayout(false);
            gbCuadrado.PerformLayout();
            gbCirculo.ResumeLayout(false);
            gbCirculo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pCreacion;
        private GroupBox gbFigura;
        private RadioButton rbRectangulo;
        private RadioButton rbTriangulo;
        private RadioButton rbCuadrado;
        private RadioButton rbCirculo;
        private Button bAgregar;
        private GroupBox gbCuadrado;
        private TextBox tLadoCuadrado;
        private Label label1;
        private ListBox lbFiguras;
        private Button bArea;
        private Button bPerimetro;
        private Label lCantidadCuadrados;
        private Label lCantidadFiguras;
        private Button bCerrar;
        private GroupBox gbCirculo;
        private TextBox tRadioCirculo;
        private Label label2;
        private GroupBox gbTriangulo;
        private TextBox tLado3Triangulo;
        private Label label5;
        private TextBox tLado2Triangulo;
        private Label label4;
        private TextBox tLado1Triangulo;
        private Label label3;
        private GroupBox gbRectangulo;
        private TextBox tLado1;
        private Label label6;
        private TextBox tLado2;
        private Label label7;
        private Label lCantidadCirculos;
        private Label lCantidadTriangulos;
        private Label lCantidadRectangulos;
        private ErrorProvider errorProvider;
    }
}