using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMNWebServices
{
    class Efemeries
    {
    }
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Datos_de_INGC011_CAT_INDICADORECONOMIC
    {

        private Datos_de_INGC011_CAT_INDICADORECONOMICINGC011_CAT_INDICADORECONOMIC iNGC011_CAT_INDICADORECONOMICField;

        /// <remarks/>
        public Datos_de_INGC011_CAT_INDICADORECONOMICINGC011_CAT_INDICADORECONOMIC INGC011_CAT_INDICADORECONOMIC
        {
            get
            {
                return this.iNGC011_CAT_INDICADORECONOMICField;
            }
            set
            {
                this.iNGC011_CAT_INDICADORECONOMICField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Datos_de_INGC011_CAT_INDICADORECONOMICINGC011_CAT_INDICADORECONOMIC
    {

        private ushort cOD_INDICADORINTERNOField;

        private System.DateTime dES_FECHAField;

        private double nUM_VALORField;

        /// <remarks/>
        public ushort COD_INDICADORINTERNO
        {
            get
            {
                return this.cOD_INDICADORINTERNOField;
            }
            set
            {
                this.cOD_INDICADORINTERNOField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DES_FECHA
        {
            get
            {
                return this.dES_FECHAField;
            }
            set
            {
                this.dES_FECHAField = value;
            }
        }

        /// <remarks/>
        public double NUM_VALOR
        {
            get
            {
                return this.nUM_VALORField;
            }
            set
            {
                this.nUM_VALORField = value;
            }
        }
    }



    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class EFEMERIDES
    {

        private EFEMERIDESEFEMERIDE_SOL eFEMERIDE_SOLField;

        private EFEMERIDESEFEMERIDE_LUNA eFEMERIDE_LUNAField;

        private EFEMERIDESFASELUNAR fASELUNARField;

        /// <remarks/>
        public EFEMERIDESEFEMERIDE_SOL EFEMERIDE_SOL
        {
            get
            {
                return this.eFEMERIDE_SOLField;
            }
            set
            {
                this.eFEMERIDE_SOLField = value;
            }
        }

        /// <remarks/>
        public EFEMERIDESEFEMERIDE_LUNA EFEMERIDE_LUNA
        {
            get
            {
                return this.eFEMERIDE_LUNAField;
            }
            set
            {
                this.eFEMERIDE_LUNAField = value;
            }
        }

        /// <remarks/>
        public EFEMERIDESFASELUNAR FASELUNAR
        {
            get
            {
                return this.fASELUNARField;
            }
            set
            {
                this.fASELUNARField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EFEMERIDESEFEMERIDE_SOL
    {

        private string sALEField;

        private string sEPONEField;

        /// <remarks/>
        public string SALE
        {
            get
            {
                return this.sALEField;
            }
            set
            {
                this.sALEField = value;
            }
        }

        /// <remarks/>
        public string SEPONE
        {
            get
            {
                return this.sEPONEField;
            }
            set
            {
                this.sEPONEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EFEMERIDESEFEMERIDE_LUNA
    {

        private string sALEField;

        private string sEPONEField;

        /// <remarks/>
        public string SALE
        {
            get
            {
                return this.sALEField;
            }
            set
            {
                this.sALEField = value;
            }
        }

        /// <remarks/>
        public string SEPONE
        {
            get
            {
                return this.sEPONEField;
            }
            set
            {
                this.sEPONEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class EFEMERIDESFASELUNAR
    {

        private byte idField;

        private string valueField;

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
