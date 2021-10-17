using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torneio.BiliotecaTorneio
{
    public class ModeloConfrontoEntrada
    {
        /// <summary>
        /// representa um time no confronto
        /// </summary>
        public ModeloTime timeCompetindo { get; set; }
        /// <summary>
        /// representa pontos do time respectivo
        /// </summary>
        public double pontos { get; set; }
        /// <summary>
        /// representa o confronto que o time saiu vencedor
        /// </summary>
        public ModeloConfronto confrontoPai { get; set; }

    }
}
