using System;
using Xunit;
using Evaluation.Framework.Logic;
using Evaluation.Framework.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Evaluation.Framework.Test
{
    public class OperadorLogicTest
    {
        private Evaluation.Framework.Logic.Operador operadorLogic;

        [Fact]
        public void InserirOperadorTest()
        {
            int codOperadorEsperado = 0;
            int codOperadorNovo = 0;
            Evaluation.Framework.Entity.Operador operadorModel = new Framework.Entity.Operador()
            {
                Ativo = true,
                Nome = "João da Silva",
                Limite = 100,
                Percentual = (decimal)67.89,
                Praca = "1"
            };

            operadorLogic = new Evaluation.Framework.Logic.Operador();
            List<Entity.Operador> operadorCollection = new List<Entity.Operador>();
            operadorCollection = operadorLogic.ConsultarOperadores("", null);

            if (operadorCollection?.Count > 0)
            {
                codOperadorEsperado = operadorCollection.
                                        OrderByDescending(operador => operador.Id).
                                            First().Id;
            }

            codOperadorEsperado += 1;

            codOperadorNovo = operadorLogic.IncluirOperador(operadorModel);

            Assert.Equal(codOperadorEsperado, codOperadorNovo);
        }

        [Fact]
        public void AtualizarOperadorTest()
        {
            int codOperadorNovo = 0;
            Evaluation.Framework.Entity.Operador operadorModel = new Framework.Entity.Operador();
            operadorLogic = new Evaluation.Framework.Logic.Operador();
            operadorModel.Nome = "João da Silva";
            operadorModel.Ativo = false;
            operadorModel.Percentual = 100;
            operadorModel.Limite = 50;
            codOperadorNovo = operadorLogic.IncluirOperador(operadorModel);

            Evaluation.Framework.Entity.Operador operadorEsperadoModel = new Framework.Entity.Operador()
            {
                Ativo = true,
                Nome = "João da Silva",
                Limite = 100,
                Percentual = (decimal)90,
                Praca = "1"
            };


            operadorLogic.AlterarOperador(operadorEsperadoModel);


            List<Entity.Operador> operadorCollection = new List<Entity.Operador>();
            operadorCollection = operadorLogic.ConsultarOperadores("João da Silva", (decimal)90);
            Evaluation.Framework.Entity.Operador operadoraAtualizadoModel = new Framework.Entity.Operador();

            if (operadorCollection?.Count > 0)
            {
                operadoraAtualizadoModel = operadorCollection.
                                        Where(operador => operador.Id == codOperadorNovo).FirstOrDefault();
            }



            Assert.Equal(operadorEsperadoModel, operadoraAtualizadoModel);
        }
    }
}
