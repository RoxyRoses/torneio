using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace torneio.BiliotecaTorneio
{
    public class ModeloTorneio
    {
        /// <summary>
        /// representa o nome do torneio
        /// </summary>
        public string nomeTorneio { get; set; }
        /// <summary>
        /// representa a taxa de inscricao do torneio
        /// </summary>
        public decimal taxaTorneio { get; set; }
       /// <summary>
       /// representa uma lista de times participando
       /// </summary>
        public List<ModeloTime> timesParticipando { get; set; } = new List<ModeloTime>();
        /// <summary>
        /// representa uma lista de premios do torneio
        /// </summary>
        public List<ModeloPremio> premios { get; set; } = new List<ModeloPremio>();
       /// <summary>
       /// representa a lista de rounds do torneio
       /// </summary>
        public List<ModeloConfronto> rounds { get; set; } = new List<ModeloConfronto>();

    }
}
