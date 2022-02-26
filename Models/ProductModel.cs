using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTrader.Models
{
    public class ProductModel
    {
        public ProductModel(int idProduct, string nome, string precoMercado, string precoDesejado, string marca, string modelo)
        {
            IdProduct = 1;
            Nome = nome;
            PrecoMercado = "R$ " + precoMercado;
            PrecoDesejado = "R$ " + precoDesejado;
            Marca = marca;
            Modelo = modelo;
        }

        public ProductModel()
        {
        }

        public int IdProduct { get; set; }
        public string Nome { get; set; }
        public string PrecoMercado { get; set; }
        public string PrecoDesejado { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}