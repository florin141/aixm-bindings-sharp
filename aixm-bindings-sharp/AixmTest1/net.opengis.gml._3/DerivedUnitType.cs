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
    /// <para>Derived units are defined by combination of other units.  Derived units are used for quantities other than those corresponding to the base units, such as hertz (s-1) for frequency, Newton (kg.m/s2) for force.  Derived units based directly on base units are usually preferred for quantities other than the fundamental quantities within a system. If a derived unit is not the preferred unit, the gml:ConventionalUnit element should be used instead.
    ///The gml:DerivedUnit extends gml:UnitDefinition with the property gml:derivationUnitTerms.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("DerivedUnitType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DerivedUnit", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class DerivedUnitType : UnitDefinitionType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DerivationUnitTermType> _derivationUnitTerm;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="DerivedUnitType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DerivedUnitType" /> class.</para>
        /// </summary>
        public DerivedUnitType()
        {
            this._derivationUnitTerm = new System.Collections.ObjectModel.Collection<DerivationUnitTermType>();
        }
    }
}
