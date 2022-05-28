﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsII.Cap9
{
    public class EmpresaFacadeSingleton
    {
        private static EmpresaFacade instancia = new EmpresaFacade();

        public EmpresaFacade Instancia
        {
            get
            {
                return instancia;
            }
        }
    }
}
