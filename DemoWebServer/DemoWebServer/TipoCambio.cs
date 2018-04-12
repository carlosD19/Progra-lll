using DemoWebServer.BCCR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DemoWebServer
{
    public class TipoCambio
    {
        public Double Colon { get; set; }
        public Double Dolar { get; set; }

        public Double ValorCambio()
        {
            wsIndicadoresEconomicosSoapClient ws = new wsIndicadoresEconomicosSoapClient("wsIndicadoresEconomicosSoap");
            String xml = ws.ObtenerIndicadoresEconomicosXML("318", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("dd/MM/yyyy"), "UTN", "N");
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            XmlNodeList lista = doc.SelectNodes("Datos_de_INGC011_CAT_INDICADORECONOMIC/INGC011_CAT_INDICADORECONOMIC");
            XmlNode unTipo;
            unTipo = lista.Item(0);
            string x = unTipo.SelectSingleNode("NUM_VALOR").InnerText.Replace(".", ",");
            return Convert.ToDouble(x);
        }

        public double ColonesDolares(double colones)
        {
            return colones / ValorCambio();
        }

        public double DolaresColones(double dolares)
        {
            return dolares * ValorCambio();
        }
    }
}
