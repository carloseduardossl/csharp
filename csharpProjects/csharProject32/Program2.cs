using System;
namespace myApplication
{
    class Car
    {
        public string modelo;
        public string cor;
        public int ano;
        public Car(string modeloNome, string corNome, int anoLancamento)
        {
            modelo = modeloNome;
            cor = corNome;
            ano = anoLancamento;
        }
    }
}