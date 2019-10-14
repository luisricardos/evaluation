using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluation.Framework.ResourceAccess.Interfaces
{
    public interface IOperador
    {
        List<Entity.Operador> ConsultarOperadores(decimal? percentual, string nome);

        bool ConsultarOperador(int codOperador);

        int IncluirOperador(Entity.Operador operador);

        void AlterarOperador(Entity.Operador operador);

        void ExcluirOperador(int id);
    }
}