using System;

namespace API2.Model
{
    public class JuroComposto
    {
        public JuroComposto(double valorInicial, double juros, int tempo)
        {
            ValorFinal = Math.Pow(valorInicial * (1 + juros), (double)tempo);
        }
        public double ValorFinal { get; set; }
    }
}