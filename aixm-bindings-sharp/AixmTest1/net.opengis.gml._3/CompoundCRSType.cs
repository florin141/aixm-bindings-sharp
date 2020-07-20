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
    /// <para>gml:CompundCRS is a coordinate reference system describing the position of points through two or more independent coordinate reference systems. It is associated with a non-repeating sequence of two or more instances of SingleCRS.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CompoundCRSType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("CompoundCRS", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class CompoundCRSType : net.opengis.gml._3.AbstractCRSType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<SingleCRSPropertyType> _componentReferenceSystem;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("componentReferenceSystem")]
        public System.Collections.ObjectModel.Collection<SingleCRSPropertyType> ComponentReferenceSystem
        {
            get
            {
                return this._componentReferenceSystem;
            }
            private set
            {
                this._componentReferenceSystem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="CompoundCRSType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CompoundCRSType" /> class.</para>
        /// </summary>
        public CompoundCRSType()
        {
            this._componentReferenceSystem = new System.Collections.ObjectModel.Collection<SingleCRSPropertyType>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("aggregationType")]
        public net.opengis.gml._3.AggregationType AggregationType { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AggregationType-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AggregationType property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AggregationTypeSpecified { get; set; }
    }
}
