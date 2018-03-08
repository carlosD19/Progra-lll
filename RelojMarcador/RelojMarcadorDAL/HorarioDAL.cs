using RelojMarcadorENL;
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
        public bool GuardarHorario(Horario horario)
        {
            return true;
        }

        public bool ModificarHorario(Horario horario)
        {
            return true;
        }

        public bool EliminarHorario(string cod)
        {
            return true;
        }
    }
}
