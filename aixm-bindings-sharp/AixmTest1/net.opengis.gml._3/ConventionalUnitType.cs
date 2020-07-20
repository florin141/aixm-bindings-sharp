//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace net.opengis.gml._3
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>Conventional units that are neither base units nor defined by direct combination of base units are used in many application domains.  For example electronVolt for energy, feet and nautical miles for length.  In most cases there is a known, usually linear, conversion to a preferred unit which is either a base unit or derived by direct combination of base units.
    ///The gml:ConventionalUnit extends gml:UnitDefinition with a property that describes a conversion to a preferred unit for this physical quantity.  When the conversion is exact, the element gml:conversionToPreferredUnit should be used, or when the conversion is not exact the element gml:roughConversionToPreferredUnit is available. Both of these elements have the same content model.  The gml:derivationUnitTerm property defined above is included to allow a user to optionally record how this unit may be derived from other ("more primitive") units.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ConventionalUnitType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ConventionalUnit", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class ConventionalUnitType : UnitDefinitionType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("conversionToPreferredUnit")]
        public ConversionToPreferredUnitType ConversionToPreferredUnit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("roughConversionToPreferredUnit")]
        public ConversionToPreferredUnitType RoughConversionToPreferredUnit { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DerivationUnitTermType> _derivationUnitTerm;
        
        [System.Xml.Serialization.XmlElementAttribute("derivationUnitTerm")]
        public System.Collections.ObjectModel.Collection<DerivationUnitTermType> DerivationUnitTerm
        {
            get
            {
                return this._derivationUnitTerm;
            }
            private set
            {
                this._derivationUnitTerm = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DerivationUnitTerm-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DerivationUnitTerm collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DerivationUnitTermSpecified
        {
            get
            {
                return (this.DerivationUnitTerm.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ConventionalUnitType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ConventionalUnitType" /> class.</para>
        /// </summary>
        public ConventionalUnitType()
        {
            this._derivationUnitTerm = new System.Collections.ObjectModel.Collection<DerivationUnitTermType>();
        }
    }
}
