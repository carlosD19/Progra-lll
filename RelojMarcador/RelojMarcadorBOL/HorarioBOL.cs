using RelojMarcadorDAL;
using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.Text;

namespace RelojMarcadorBOL
{
    public class HorarioBOL
    {
        public HorarioDAL dal = new HorarioDAL();

        public bool AgregarHorario(Horario horario, bool funcion)
        {
            if (String.IsNullOrEmpty(horario.Dia))
            {
                throw new Exception("Día requerido.");
            }
            if (String.IsNullOrEmpty(horario.Codigo))
            {
                throw new Exception("Código requerido.");
            }
            if (String.IsNullOrEmpty(horario.HoraIni.ToString())
                || String.IsNullOrEmpty(horario.HoraIni.ToString()))
            {
                throw new Exception("Hora de inicio y fin requeridas.");
            }
            if (!funcion)
            {
                return dal.ModificarHorario(horario);
            }
            return dal.GuardarHorario(horario);
        }
        public bool EliminarHorario(string cod)
        {
            return dal.EliminarHorario(cod);
        }
    }
}
