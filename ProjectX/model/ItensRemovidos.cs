using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectX.model
{
    public class ItensRemovidos
    {
        public int IdLog { get; set; } // Identificador único do log, chave primária
        public int IdItem { get; set; } // Identificador do item
        public string UsuarioResponsavel { get; set; } // Usuário que realizou a remoção
        public string NomeEquipamento { get; set; } // Nome do equipamento
        public string Quantidade { get; set; } // Quantidade do item removido
        public string Tipo { get; set; } // Tipo do equipamento
        public string Fabricante { get; set; } // Fabricante do equipamento
        public string Modelo { get; set; } // Modelo do equipamento
        public string Processador { get; set; } // Informações do processador
        public string Memoria { get; set; } // Quantidade de memória
        public string HdSsd { get; set; } // Informações do HD ou SSD
        public string SistemaOperacional { get; set; } // Sistema operacional do equipamento
        public double ValorEstimado { get; set; } // Valor estimado do item
        public int IdLoja { get; set; } // Identificador da loja
        public int IdDepartamento { get; set; } // Identificador do departamento
        public string IdBitLocker { get; set; } // Identificador do BitLocker
        public string ChaveBitLocker { get; set; } // Chave do BitLocker
        public string UsuarioExclusao { get; set; } // Usuário que efetuou a exclusão
        public DateTime DataHoraExclusao { get; set; } // Data e hora da exclusão
    }
}
