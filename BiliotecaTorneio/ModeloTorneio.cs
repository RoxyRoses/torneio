using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torneio.BiliotecaTorneio
{
    public class ModeloTorneio
    {
        public string nomeTorneio { get; set; }
        public decimal taxaTorneio { get; set; }
        public List<ModeloTime> timesParticipando { get; set; } = new List<ModeloTime>();

        public List<ModeloPremio> premios { get; set; } = new List<ModeloPremio>();
        public List<ModeloConfronto> rounds { get; set; } = new List<ModeloConfronto>();

    }
}
