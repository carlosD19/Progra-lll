using RelojMarcadorENL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RelojMarcadorDAL
{
    public class HorarioDAL
    {
        string rutaXML;
        XmlDocument doc;
        public void CrearArchivo(string ruta, string nodoRaiz)
        {
            this.rutaXML = ruta;
            doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlNode root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            XmlNode element1 = doc.CreateElement(nodoRaiz);
            doc.AppendChild(element1);
            doc.Save(ruta);
        }
        public bool ModificarHorario(Horario horario)
        {
            throw new NotImplementedException();
        }

        public bool GuardarHorario(Horario horario)
        {
            throw new NotImplementedException();
        }

        public bool EliminarHorario(string cod)
        {
            throw new NotImplementedException();
        }
    }
}
