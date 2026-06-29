using System;
using System.Collections.Generic;
using System.Text;

namespace Controle_e_Solicitação_de_chamados
{

    public class Chamado
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public StatusChamado Status { get; set; }
        public DateTime DataAbertura { get; set; }

        public Chamado(int id, string matricula, string nome, string descricao, DateTime dataAbertura)
        {
            Id = id;
            Matricula = matricula;
            Nome = nome;
            Descricao = descricao;
            Status = StatusChamado.Aberto;
            DataAbertura = dataAbertura;
        }

        public override string ToString()
        {
            return $"ID: {Id}\n" +
                   $"Nome: {Nome}\n" +
                   $"Matrícula: {Matricula}\n" +
                   $"Status: {Status}\n" +
                   $"Data de Abertura: {DataAbertura:dd/MM/yyyy}\n" +
                   $"Descrição: {Descricao}\n";
        }
    }

}


