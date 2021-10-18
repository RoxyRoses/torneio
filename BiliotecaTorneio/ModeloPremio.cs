using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torneio.BiliotecaTorneio
{
    public class ModeloPremio
    {
        /// <summary>
        /// representa a colocacao do premio
        /// </summary>
        public int colocacao { get; set; }
        /// <summary>
        /// representa o nome do lugar que do premio
        /// </summary>
        public string nomeLugar { get; set; }
        /// <summary>
        /// representa o valor do premio
        /// </summary>
        public decimal quantidadePremio { get; set; }
        /// <summary>
        /// representa a porcentagem do premio
        /// </summary>
        public double porcentagemPremio { get; set; }
    }
}
