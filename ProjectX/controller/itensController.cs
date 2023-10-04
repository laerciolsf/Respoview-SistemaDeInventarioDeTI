﻿using ProjectX.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Reflection;

namespace ProjectX.controller
{
    public class itensController
    {
        private MySqlConnection conexao;
        public itensController()
        {
            this.conexao = new conn().GetConnection();
        }
        public void cadastrarItens(Itens obj)
        {
            try
            {
                string sql = @"insert into itens 
                                (usuarioResponsavel,nomeEquipamento,quantidade,tipo,fabricante,
                                modelo,processador,memoria,hd_ssd,sistemaOperacional,valorEstimado,
                                idLoja,idDepartamento) values 
                                (@usuarioResponsavel,@nomeEquipamento,@quantidade,@tipo,@fabricante,
                                @modelo,@processador,@memoria,@hd_ssd,@sistemaOperacional,@valorEstimado,
                                @idLoja,@idDepartamento);";

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                executacmd.Parameters.AddWithValue("@usuarioResponsavel", obj.usuarioResponsavel);
                executacmd.Parameters.AddWithValue("@nomeEquipamento", obj.nomeEquipamento);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@tipo", obj.tipo);
                executacmd.Parameters.AddWithValue("@fabricante", obj.fabricante);
                executacmd.Parameters.AddWithValue("@modelo", obj.modelo);
                executacmd.Parameters.AddWithValue("@processador", obj.processador);
                executacmd.Parameters.AddWithValue("@memoria", obj.memoria);
                executacmd.Parameters.AddWithValue("@hd_ssd", obj.hd_ssd);
                executacmd.Parameters.AddWithValue("@sistemaOperacional", obj.sistemaOperacional);
                executacmd.Parameters.AddWithValue("@valorEstimado", obj.valorEstimado);
                executacmd.Parameters.AddWithValue("@idLoja", obj.idLoja);
                executacmd.Parameters.AddWithValue("@idDepartamento", obj.idDepartamento);
                
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Item cadastrado com sucesso");
                conexao.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }
        }
    }
}