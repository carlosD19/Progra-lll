using JuegoDadoDAL;
using JuegoDadoENL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDadoBOL
{
    public class DadoBOL
    { 
        public List<DadoENL> CargarTodo()
        {
            DadoDAL dal = new DadoDAL();
            return dal.CargarTodo();
        }
    }
}
