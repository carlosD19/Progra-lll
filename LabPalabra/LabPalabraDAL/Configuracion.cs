﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPalabraDAL
{
    public static class Configuracion
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public static string ConStr
        {
            get { return conStr; }
        }
    }
}
