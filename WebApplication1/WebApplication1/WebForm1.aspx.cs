using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public class Conta
    {
        public int NumeroConta;
        public string NomeConta;
        public double SaldoConta;

        public bool Sacar(double ValorDoSaque)
        {
            if(this.SaldoConta >= ValorDoSaque)
            {
                SaldoConta = SaldoConta - ValorDoSaque;
                return true;
            }
            return false;
        }
    }
    
    public partial class WebForm1 : System.Web.UI.Page
    {
        Conta C = new Conta();
        protected void Page_Load(object sender, EventArgs e)
        {
            C.SaldoConta = 1000;
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Response.Write("É Nóis");
        }

        protected void NroConta_TextChanged(object sender, EventArgs e)
        {
            C.NumeroConta = int.Parse(NroConta.Text);                           
        }

        protected void NomeTitular_TextChanged(object sender, EventArgs e)
        {
            C.NomeConta = NomeTitular.Text;
        }

        protected void Sacar_Click(object sender, EventArgs e)
        {
            double ValorSaque;
            ValorSaque = double.Parse(Saque.Text);
            C.Sacar(ValorSaque);
            C.SaldoConta = C.SaldoConta - ValorSaque;
            Response.Write(C.SaldoConta);
        }
    }
}