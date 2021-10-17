using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torneio.BiliotecaTorneio
{
   public class ModeloConfronto
    {
        public List<ModeloConfrontoEntrada> entradas { get; set; } = List<ModeloConfrontoEntrada>();
        public ModeloTime ganhador { get; set; }
        public int roundConfronto { get; set; }



    }
}
