using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.model
{
    public class Itens
    {
        //Declaração dos atributos
        public int id { get; set; }
        public string usuarioResponsavel { get; set; }
        public string nomeEquipamento { get; set; }
        public string quantidade { get; set; }
        public string tipo { get; set; }
        public string fabricante { get; set; }
        public string modelo { get; set; }
        public string processador { get; set; }
        public string memoria { get; set; }
        public string hd_ssd { get; set; }
        public string sistemaOperacional { get; set; }
        public double valorEstimado { get; set; }
        public int idLoja { get; set; }
        public int idDepartamento { get; set; }
        public string idBitLocker { get; set; }
        public string chaveBitLocker { get; set; }

    }
}