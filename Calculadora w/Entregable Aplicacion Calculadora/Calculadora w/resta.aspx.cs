using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculadora_w
{
    public partial class resta : System.Web.UI.Page
    {
        ServidorCalculadoraW.WS_TestClient Servidor = new ServidorCalculadoraW.WS_TestClient();

        protected void btnRestar_Click(object sender, EventArgs e)
        {
            //Convertir de texto a entero los valores obtenidos
            //Caja de texto
            int num1 = Int32.Parse(txtNumero1.Text);
            int num2 = Int32.Parse(txtNumero2.Text);

            //Usar metdo web sumar y obtener una variable el resultado de la suma
            int resultado = Servidor.resta(num1, num2);
            //mostrar resultado
            txtResultado.Text = resultado.ToString();
        }
    }
}