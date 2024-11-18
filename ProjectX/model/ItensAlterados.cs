using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.model
{
    public class ItensAlterados
    {
        public int IdLog { get; set; }                 // idLog int AI PK
        public int IdItem { get; set; }               // idItem int
        public string UsuarioResponsavel { get; set; } // usuarioResponsavel varchar(45)
        public string NomeEquipamento { get; set; }   // nomeEquipamento varchar(45)
        public string Quantidade { get; set; }        // quantidade varchar(45)
        public string Tipo { get; set; }              // tipo varchar(45)
        public string Fabricante { get; set; }        // fabricante varchar(45)
        public string Modelo { get; set; }            // modelo varchar(45)
        public string Processador { get; set; }       // processador varchar(45)
        public string Memoria { get; set; }           // memoria varchar(45)
        public string HdSsd { get; set; }             // hd_ssd varchar(45)
        public string SistemaOperacional { get; set; }// sistemaOperacional varchar(45)
        public double ValorEstimado { get; set; }     // valorEstimado double
        public int IdLoja { get; set; }               // idLoja int
        public int IdDepartamento { get; set; }       // idDepartamento int
        public string IdBitLocker { get; set; }       // idBitLocker varchar(128)
        public string ChaveBitLocker { get; set; }    // chaveBitLocker varchar(128)
        public string UsuarioExclusao { get; set; }   // usuarioExclusao varchar(45)
        public DateTime DataHoraExclusao { get; set; }// dataHoraExclusao datetime
    }
}
