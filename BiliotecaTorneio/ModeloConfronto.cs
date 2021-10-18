using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torneio.BiliotecaTorneio
{
   public class ModeloConfronto
    {
        /// <summary>
        /// represena lista de inscricoes
        /// </summary>
        public List<ModeloConfrontoEntrada> entradas { get; set; }
        /// <summary>
        /// representa o time ganhador
        /// </summary>
        public ModeloTime ganhador { get; set; }
        /// <summary>
        /// representa o round que esta on confronto
        /// </summary>
        public int roundConfronto { get; set; }




    }
}
