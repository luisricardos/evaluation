using System;
using System.Collections.Generic;

namespace Evaluation.Framework.Logic
{
	public class Praca
	{
        public List<Entity.Praca> ConsultarPraca()
		{
            ResourceAccess.Praca praca = new ResourceAccess.Praca();

            return praca.ConsultarPraca();
        }

        public bool ConsultarPracaPorId(int codPraca)
        {
            ResourceAccess.Praca praca = new ResourceAccess.Praca();

            return praca.ConsultarPracaPorId(codPraca);
        }
    }
}