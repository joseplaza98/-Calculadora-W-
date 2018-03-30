using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AppWEB_WS
{
    public partial class Defult : System.Web.UI.Page
    {

        WS_Calculadora.WS_Test serviCal = new WS_Calculadora.WS_Test();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSumar_Click(object sender, EventArgs e)
        {
            //Convertir de texto a entero los valores obtenidos
            //Caja de texto
            int num1 = Int32.Parse(txtNumero1.Text);
            int num2 = Int32.Parse(txtNumero2.Text);

            //Usar metdo web sumar y obtener una variable el resultado de la suma
            int resultado = serviCal.sumar(num1, num2);
            //mostrar resultado
            txtResultado.Text = resultado.ToString();
        }
    }
}