using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    internal class Imovel
    {
        public int Id { get; set; }
        public int NroQuartos { get; set; }
        public int NroVagas { get; set; }
        public int NroBanheiros { get; set; }
        public Address? Address { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
