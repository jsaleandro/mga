using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalizaDomestica.Folha.Dominio.Entidades
{
    public class Pessoa
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DtNascimento { get; set; }
        public string EstCivil { get; set; }
        public string Sexo { get; set; }
        public string Nacionalidade { get; set; }
        public string GrauInstrucao { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string CartIdentidade { get; set; }
        public string UfCartIdentidade { get; set; }
        public string OrigemEmissorIdentidade { get; set; }
        public DateTime DtEmissaoIdentidade { get; set; }
        public string TituloEleitor { get; set; }
        public string ZonaTituloEleitor { get; set; }
        public string SecaoTitEleitor { get; set; }
        public string CarteiraTrab { get; set; }
        public string SerieCartTrab { get; set; }
        public string UfCartTrab { get; set; }
        public DateTime DtCarteiraTrab { get; set; }
        public string Cpf { get; set; }
        public string NomeMae { get; set; }
        public string Cargo { get; set; }
        public string Cei { get; set; }
        public string Cnae { get; set; }
        public string Fpas { get; set; }
        public string Email { get; set; }
        public string Apelido { get; set; }
        public string Foto { get; set; }
        public string IdPais { get; set; }
        public string Tipo { get; set; }
        public string CodUsuario { get; set; }

    }
}
