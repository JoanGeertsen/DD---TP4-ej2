using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DD_TP3_ej2
{
    public partial class FFiguras : Form
    {
        #region Atributos
        private Circulo[] aCirculos;
        private Rectangulo[] aRectangulos;
        private Cuadrado[] aCuadrados;
        private Triangulo[] aTriangulos;
        private int cantCirculos;
        private int cantRectangulos;
        private int cantCuadrados;
        private int cantTriangulos;
        private int max = 50;
        #endregion
        public FFiguras()
        {
            InitializeComponent();
            aCirculos = new Circulo[max]; cantCirculos = 0;
            aRectangulos = new Rectangulo[max]; cantRectangulos = 0;
            aCuadrados = new Cuadrado[max]; cantCuadrados = 0;
            aTriangulos = new Triangulo[max]; cantTriangulos = 0;
            asignarKeyPress(); asignarValidaciones(); //Tal vez mover esto a un Load o algo similar
        }

        #region Funcionalidades
        private bool obtenerYValidarIndex(out int index)
        {
            bool validez = true;
            index = lbFiguras.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Debe seleccionar una figura", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validez = false;
            }
            return validez;
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            Figura[] a = aRectangulos;
            if (rbCirculo.Checked) a = aCirculos;
            else if (rbCuadrado.Checked) a = aCuadrados;
            else if (rbTriangulo.Checked) a = aTriangulos;
            else if (rbRectangulo.Checked) a = aRectangulos;

            if (obtenerYValidarIndex(out int i))
                MessageBox.Show($"El �rea es: {a[i].area()}cm�", "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            Figura[] a = aRectangulos;
            if (rbCirculo.Checked) a = aCirculos;
            else if (rbCuadrado.Checked) a = aCuadrados;
            else if (rbTriangulo.Checked) a = aTriangulos;
            else if (rbRectangulo.Checked) a = aRectangulos;

            if (obtenerYValidarIndex(out int i))
                MessageBox.Show($"El �rea es: {a[i].perimetro()}cm", "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void actualizarGruposVisibles(GroupBox gb, Label l)
        {
            gbCirculo.Visible = true; gbCuadrado.Visible = false; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
            gb.Visible = true;
            lCantidadCirculos.Visible = false; lCantidadCuadrados.Visible = false; lCantidadTriangulos.Visible = false; lCantidadRectangulos.Visible = false;
            l.Visible = true;
            errorProvider.Clear();
        }

        private void actualizarListBox(Figura[] a, int cant)
        {
            lbFiguras.Items.Clear();
            for (int i = 0; i < cant; i++)
                lbFiguras.Items.Add(a[i].mostrar());
        }

        private void bAgregar_Click(object sender, EventArgs e)
        {
            if (rbCirculo.Checked)
            {
                if (tRadioCirculo.Text == "")
                {
                    MessageBox.Show("El radio ingresado es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tRadioCirculo.Focus();
                }
                else
                {
                    aCirculos[cantCirculos++] = new Circulo(double.Parse(tRadioCirculo.Text));
                    actualizarListBox(aCirculos, cantCirculos); lCantidadCirculos.Text = $"Cantidad de Cuadrados: {cantCirculos}";
                }
            }
            else if (rbCuadrado.Checked)
            {
                if (tLadoCuadrado.Text == "")
                {
                    MessageBox.Show("El lado ingresado es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tLadoCuadrado.Focus();
                }
                else
                {
                    aCuadrados[cantCuadrados++] = new Cuadrado(double.Parse(tLadoCuadrado.Text));
                    actualizarListBox(aCuadrados, cantCuadrados); lCantidadCuadrados.Text = $"Cantidad de Cuadrados: {cantCuadrados}";
                }
            }
            else if (rbTriangulo.Checked)
            {
                double lado1 = (tLado1Triangulo.Text != "") ? double.Parse(tLado1Triangulo.Text) : 0;
                double lado2 = (tLado2Triangulo.Text != "") ? double.Parse(tLado2Triangulo.Text) : 0;
                double lado3 = (tLado3Triangulo.Text != "") ? double.Parse(tLado3Triangulo.Text) : 0;

                if (!Triangulo.trianguloValido(lado1, lado2, lado3))
                {
                    MessageBox.Show("El triangulo ingresado es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    aTriangulos[cantTriangulos++] = new Triangulo(lado1, lado2, lado3);
                    actualizarListBox(aTriangulos, cantTriangulos); lCantidadTriangulos.Text = $"Cantidad de Triangulos: {cantTriangulos}";
                }
            }
            else if (rbRectangulo.Checked)
            {
                if (tLado1.Text == "" || tLado2.Text == "")
                {
                    MessageBox.Show("El rectangulo ingresado es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    aRectangulos[cantRectangulos++] = new Rectangulo(double.Parse(tLado1.Text), double.Parse(tLado2.Text));
                    actualizarListBox(aRectangulos, cantRectangulos); lCantidadRectangulos.Text = $"Cantidad de Rectangulos: {cantRectangulos}";
                }
            }           
            lCantidadFiguras.Text = $"Cantidad de Figuras: {cantCirculos + cantCuadrados + cantTriangulos + cantRectangulos}";
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region RadioButtons 
        //Todo esto se puede agrupar en 1 solo evento, como en el keyPress y el Leave...
        private void rbCirculo_CheckedChanged(object sender, EventArgs e)
        {
            lbFiguras.Items.Clear();
            actualizarGruposVisibles(gbCirculo, lCantidadCirculos);
            actualizarListBox(aCirculos, cantCirculos);
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            lbFiguras.Items.Clear();
            actualizarGruposVisibles(gbCuadrado, lCantidadCuadrados);
            actualizarListBox(aCuadrados, cantCuadrados);
        }
        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            lbFiguras.Items.Clear();
            actualizarGruposVisibles(gbTriangulo, lCantidadTriangulos);
            actualizarListBox(aTriangulos, cantTriangulos);
        }
        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            lbFiguras.Items.Clear();
            actualizarGruposVisibles(gbRectangulo, lCantidadRectangulos);
            actualizarListBox(aRectangulos, cantRectangulos);
        }
        #endregion

        #region validaci�n de capos

        private void asignarValidaciones()
        {
            tRadioCirculo.Leave += TextBox_Leave;
            tLado1.Leave += TextBox_Leave;
            tLado2.Leave += TextBox_Leave;
            tLado1Triangulo.Leave += TextBox_Leave;
            tLado2Triangulo.Leave += TextBox_Leave;
            tLado3Triangulo.Leave += TextBox_Leave;
            tLadoCuadrado.Leave += TextBox_Leave;
        }
        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text.Length <= 0 || int.Parse(textBox.Text) <= 0)
                errorProvider.SetError(textBox, "Valor invalido");
            else
                errorProvider.SetError(textBox, "");
        }

        #endregion

        #region KeyPress
        private void asignarKeyPress()
        {
            tRadioCirculo.KeyPress += TextBox_KeyPress;
            tLado1.KeyPress += TextBox_KeyPress;
            tLado2.KeyPress += TextBox_KeyPress;
            tLado1Triangulo.KeyPress += TextBox_KeyPress;
            tLado2Triangulo.KeyPress += TextBox_KeyPress;
            tLado3Triangulo.KeyPress += TextBox_KeyPress;
            tLadoCuadrado.KeyPress += TextBox_KeyPress;
        }
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
        }
        #endregion        
    }
}