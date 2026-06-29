using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;

namespace Controle_e_Solicitação_de_chamados
{
    public class ChamadoService
    {
        private List<Chamado> chamados;
        private int contadorId;
        private string caminhoArquivo = "Data/chamados.json";

        public ChamadoService()
        {
            CarregarDados();
        }

        public void CriarChamado(string matricula, string nome, string descricao, DateTime data)
        {
            chamados.Add(new Chamado(contadorId++, matricula, nome, descricao, data));
            SalvarDados();
        }

        public List<Chamado> ListarChamados()
        {
            return chamados;
        }

        public bool ConcluirChamado(int id)
        {
            var chamado = chamados.Find(c => c.Id == id);
            if (chamado != null)
            {
                chamado.Status = StatusChamado.Concluido;           
                SalvarDados();                  
                return true;
            }
            return false;
        }

        private void SalvarDados()
        {
            var json = JsonSerializer.Serialize(chamados, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(caminhoArquivo, json);
            SalvarDados()
        }

        private void CarregarDados()
        {
            if (File.Exists(caminhoArquivo))
            {
                var json = File.ReadAllText(caminhoArquivo);
                chamados = JsonSerializer.Deserialize<List<Chamado>>(json) ?? new List<Chamado>();
            }
            else
            {
                chamados = new List<Chamado>();
            }

            contadorId = chamados.Count > 0 ? chamados[^1].Id + 1 : 1;
        }
    }

}
