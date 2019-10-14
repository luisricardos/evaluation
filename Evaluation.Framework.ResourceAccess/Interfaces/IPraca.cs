using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Evaluation.Framework.ResourceAccess.Interfaces
{
    public interface IPraca
    {
        List<Entity.Praca> ConsultarPraca();
        bool ConsultarPracaPorId(int idPraca);
    }
}
