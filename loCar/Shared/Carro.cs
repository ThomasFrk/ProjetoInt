using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoCar.Models
{
    public class Carro
    {
        public int id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Categoria { get; set; }
        public int Ano { get; set; }
        public int Passageiros { get; set; }
        public int Portas { get; set; }
        public bool CambioAutomatico { get; set; }
        public string Placa { get; set; }
        public bool DirecaoHidraulica { get; set; }
        public bool Ac { get; set; }
        public string Combustivel { get; set; }
        public string Descricao { get; set; }

        
    }
}
