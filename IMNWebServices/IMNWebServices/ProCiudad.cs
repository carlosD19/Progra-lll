using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMNWebServices
{
    public class ProCiudad
    {
    }

    // NOTA: El código generado puede requerir, como mínimo, .NET Framework 4.5 o .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class PRONOSTICO_PORCIUDADES
    {

        private string fECHAField;

        private string cOMENTARIOField;

        private PRONOSTICO_PORCIUDADESCIUDAD[] cIUDADESField;

        /// <remarks/>
        public string FECHA
        {
            get
            {
                return this.fECHAField;
            }
            set
            {
                this.fECHAField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIO
        {
            get
            {
                return this.cOMENTARIOField;
            }
            set
            {
                this.cOMENTARIOField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CIUDAD", IsNullable = false)]
        public PRONOSTICO_PORCIUDADESCIUDAD[] CIUDADES
        {
            get
            {
                return this.cIUDADESField;
            }
            set
            {
                this.cIUDADESField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_PORCIUDADESCIUDAD
    {

        private decimal tEMPMAXField;

        private decimal tEMPMINField;

        private PRONOSTICO_PORCIUDADESCIUDADESTADOMANANA eSTADOMANANAField;

        private PRONOSTICO_PORCIUDADESCIUDADESTADOTARDE eSTADOTARDEField;

        private PRONOSTICO_PORCIUDADESCIUDADESTADONOCHE eSTADONOCHEField;

        private string cOMENTARIOMANANAField;

        private string cOMENTARIOTARDEField;

        private string cOMENTARIONOCHEField;

        private byte idRegionField;

        private string nombreField;

        private byte idField;

        /// <remarks/>
        public decimal TEMPMAX
        {
            get
            {
                return this.tEMPMAXField;
            }
            set
            {
                this.tEMPMAXField = value;
            }
        }

        /// <remarks/>
        public decimal TEMPMIN
        {
            get
            {
                return this.tEMPMINField;
            }
            set
            {
                this.tEMPMINField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_PORCIUDADESCIUDADESTADOMANANA ESTADOMANANA
        {
            get
            {
                return this.eSTADOMANANAField;
            }
            set
            {
                this.eSTADOMANANAField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_PORCIUDADESCIUDADESTADOTARDE ESTADOTARDE
        {
            get
            {
                return this.eSTADOTARDEField;
            }
            set
            {
                this.eSTADOTARDEField = value;
            }
        }

        /// <remarks/>
        public PRONOSTICO_PORCIUDADESCIUDADESTADONOCHE ESTADONOCHE
        {
            get
            {
                return this.eSTADONOCHEField;
            }
            set
            {
                this.eSTADONOCHEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOMANANA
        {
            get
            {
                return this.cOMENTARIOMANANAField;
            }
            set
            {
                this.cOMENTARIOMANANAField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIOTARDE
        {
            get
            {
                return this.cOMENTARIOTARDEField;
            }
            set
            {
                this.cOMENTARIOTARDEField = value;
            }
        }

        /// <remarks/>
        public string COMENTARIONOCHE
        {
            get
            {
                return this.cOMENTARIONOCHEField;
            }
            set
            {
                this.cOMENTARIONOCHEField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte idRegion
        {
            get
            {
                return this.idRegionField;
            }
            set
            {
                this.idRegionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string nombre
        {
            get
            {
                return this.nombreField;
            }
            set
            {
                this.nombreField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_PORCIUDADESCIUDADESTADOMANANA
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_PORCIUDADESCIUDADESTADOTARDE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class PRONOSTICO_PORCIUDADESCIUDADESTADONOCHE
    {

        private string imgPathField;

        private byte idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string imgPath
        {
            get
            {
                return this.imgPathField;
            }
            set
            {
                this.imgPathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }


}
