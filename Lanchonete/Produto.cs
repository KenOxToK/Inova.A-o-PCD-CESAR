using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete
{
    public class Produto
    {
        #region Propriedades
        int _id;
        string _codigoInterno;
        string _codigoBarras;
        string _nome;
        float _preco;
        float _peso;
        int _tempoPreparoEmMinutos;
        string _descricao;
        int _validadeEmDias;


        public int Id { get => _id; set => _id = value; }
        public string CodigoInterno { get => _codigoInterno; set => _codigoInterno = value; }
        public string CodigoBarras { get => _codigoBarras; set => _codigoBarras = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public float Preco { get => _preco; set => _preco = value; }
        public float Peso { get => _peso; set => _peso = value; }
        public int TempoPreparoEmMinutos { get => _tempoPreparoEmMinutos; set => _tempoPreparoEmMinutos = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int ValidadeEmDias { get => _validadeEmDias; set => _validadeEmDias = value; }
        #endregion  
        public Produto(string nome, string codigoBarras, string codigoInterno, float preco, float peso, string descricao = "...", int tempoPreparoEmMinutos = 0, int validadeEmdias = 0)
        {
            _nome = nome;
            _codigoBarras = codigoBarras;
            _codigoInterno = codigoInterno;
            _preco = preco;
            _peso = peso;
            _descricao = descricao;
            _tempoPreparoEmMinutos = tempoPreparoEmMinutos;
            _validadeEmDias = validadeEmdias;
        }
        public Produto()
            {

            }
    }
}

