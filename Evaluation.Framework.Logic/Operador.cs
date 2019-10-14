using System;
using System.Collections.Generic;
using Evaluation.Framework.Entity;

namespace Evaluation.Framework.Logic
{
    public class Operador
    {
        public bool ConsultarOperadorPorId(int codOperador)
        {
            ResourceAccess.Operador operador = new ResourceAccess.Operador();

            return operador.ConsultarOperador(codOperador);
        }

        public List<Entity.Operador> ConsultarOperadores(string nome, decimal? percentual)
        {
            ResourceAccess.Operador operador = new ResourceAccess.Operador();

            return operador.ConsultarOperadores(percentual, nome);
        }

        public List<Entity.Praca> ListaPraca()
        {
            ResourceAccess.Praca praca = new ResourceAccess.Praca();

            return praca.ConsultarPraca();
        }

        public int IncluirOperador(Entity.Operador operador)
        {
            ResourceAccess.Operador operadorData = new ResourceAccess.Operador();

            return operadorData.IncluirOperador(operador);
        }

        public void AlterarOperador(Entity.Operador operador)
        {
            ResourceAccess.Operador operadorData = new ResourceAccess.Operador();

            operadorData.AlterarOperador(operador);
        }

        public void ExcluirOperador(int id)
        {
            ResourceAccess.Operador operadorData = new ResourceAccess.Operador();

            operadorData.ExcluirOperador(id);
        }
    }
}