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
        {//No necesito recibir nada por parametro
            lbFiguras.Items.Clear();
            //for (int i = 0; i < cant; i++) ;
            //lbFiguras.Items.Add(a[i].mostrar()); //Acá va un ToString()
        }
        private void bAgregar_Click(object sender, EventArgs e)
        {
          
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