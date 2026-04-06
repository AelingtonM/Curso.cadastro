
using System.Globalization;
using System.Windows.Forms;

namespace Curso.cadastro
{
    internal class funcoes
    {
        public static void PRImaiuscula(Control CTR)

        {
            TextInfo TextInfo = new CultureInfo("pt-br", false).TextInfo;

            CTR.Text = TextInfo.ToTitleCase(CTR.Text);

            if (CTR is TextBox txt)
            {
                txt.SelectionStart = txt.Text.Length;
            }
            else if (CTR is ComboBox CB)
            {
                CB.SelectionStart = CB.Text.Length;

            }
        }
    }
}
