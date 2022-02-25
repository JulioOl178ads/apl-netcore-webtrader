﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebTrader.Models
{
    public class ProductModel
    {
        public ProductModel(string nome, string precoMercado, string precoDesejado, string marca, string modelo)
        {
            Nome = nome;
            PrecoMercado = precoMercado;
            PrecoDesejado = precoDesejado;
            Marca = marca;
            Modelo = modelo;
        }

        public string Nome { get; set; }
        public string PrecoMercado { get; set; }
        public string PrecoDesejado { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}