using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DD_TP3_ej2
{
    public partial class FFiguras : Form
    {
        #region Atributos
        private List<Figura> listFiguras;
        private int cantFiguras;
        #endregion
        public FFiguras()
        {
            InitializeComponent();
            listFiguras = new List<Figura>();
            cantFiguras = 0;
        }

        #region Funcionalidades
        private void FFiguras_Shown(object sender, EventArgs e)
        {
            asignarKeyPress(); asignarValidaciones();
        }
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
            if (obtenerYValidarIndex(out int i)) ;
                //MessageBox.Show($"El área es: {a[i].area()}cm²", "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            if (obtenerYValidarIndex(out int i)) ;
                //MessageBox.Show($"El perímetro es: {a[i].perimetro()}cm", "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void actualizarGruposVisibles(GroupBox gb, Label l)
        {
            gbCirculo.Visible = true; gbCuadrado.Visible = false; gbTriangulo.Visible = false; gbRectangulo.Visible = false;
            gb.Visible = true;
            lCantidadCirculos.Visible = false; lCantidadCuadrados.Visible = false; lCantidadTriangulos.Visible = false; lCantidadRectangulos.Visible = false;
            l.Visible = true;
            errorProvider.Clear();
        }

        private void actualizarListBox()
        {
            lbFiguras.Items.Clear();
            foreach (Figura f in listFiguras)
                lbFiguras.Items.Add(f.ToString());
        }
        private void bAgregar_Click(object sender, EventArgs e)
        {
            Figura fNueva = new Circulo(1);
            if (rbCirculo.Checked)
            {
                if (tRadioCirculo.Text == "")
                {
                    MessageBox.Show("El radio ingresado es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tRadioCirculo.Focus();
                }
                else fNueva = new Circulo(double.Parse(tRadioCirculo.Text));
            }
            else if (rbCuadrado.Checked)
            {
                if (tLadoCuadrado.Text == "")
                {
                    MessageBox.Show("El cuadrado es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tLadoCuadrado.Focus();
                }
                else fNueva = new Cuadrado(double.Parse(tLadoCuadrado.Text));
            }
            else if (rbTriangulo.Checked)
            {
                double lado1 = (tLado1Triangulo.Text != "") ? double.Parse(tLado1Triangulo.Text) : 0;
                double lado2 = (tLado2Triangulo.Text != "") ? double.Parse(tLado2Triangulo.Text) : 0;
                double lado3 = (tLado3Triangulo.Text != "") ? double.Parse(tLado3Triangulo.Text) : 0;
                if (!Triangulo.trianguloValido(lado1, lado2, lado3))
                {
                    MessageBox.Show("El cuadrado es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tLado1Triangulo.Focus(); tLado2Triangulo.Focus(); tLado3Triangulo.Focus(); tLado1Triangulo.Focus();
                }
                else fNueva = new Triangulo(lado1, lado2, lado3);
            }
            else if(rbRectangulo.Checked)
            {
                if (tLado1.Text == "" || tLado2.Text == "")
                {
                    MessageBox.Show("El rectangulo es INVALIDO", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tLado1.Focus();
                }
                else fNueva = new Rectangulo(double.Parse(tLado1.Text), double.Parse(tLado2.Text));
            }

            listFiguras.Add(fNueva); cantFiguras++;
            actualizarListBox();
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
            actualizarListBox();
        }

        private void rbCuadrado_CheckedChanged(object sender, EventArgs e)
        {
            lbFiguras.Items.Clear();
            actualizarGruposVisibles(gbCuadrado, lCantidadCuadrados);
            actualizarListBox();
        }
        private void rbTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            lbFiguras.Items.Clear();
            actualizarGruposVisibles(gbTriangulo, lCantidadTriangulos);
            actualizarListBox();
        }
        private void rbRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            lbFiguras.Items.Clear();
            actualizarGruposVisibles(gbRectangulo, lCantidadRectangulos);
            actualizarListBox();
        }
        #endregion

        #region validación de capos

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