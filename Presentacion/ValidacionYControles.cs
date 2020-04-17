using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentacion
{
    public class ValidacionYControles
    {
        public void GenericValidarDatoSoloDecimal(TextBox textBox1, object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.Contains("."))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }

                if (e.KeyChar == '.' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }

        public void GenericValidarDatoSoloNumero(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public void GenericValidarDatoSoloLetra(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public bool ControlCampoNoVacio(List<TextBox> lista)
        {
            bool condicion = true;
            foreach (TextBox elemento in lista)
            {
                if (elemento.Text == "")
                {
                    condicion = false;
                    MessageBox.Show("El campo " + elemento.Name.ToString() + " no debe ser vacio! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    elemento.Focus();
                    break;
                }
            }
            return condicion;
            /*
            if (elemt.Text == "")
            {
                MessageBox.Show("El campo -.- debe ser completado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                elemt.Focus();
            }
            */
        }
    }
}
