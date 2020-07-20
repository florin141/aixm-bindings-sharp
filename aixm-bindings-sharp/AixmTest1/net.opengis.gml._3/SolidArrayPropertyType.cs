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
    /// <para>gml:SolidArrayPropertyType is a container for an array of solids. The elements are always contained in the array property, referencing geometry elements or arrays of geometry elements is not supported.</para>
    /// <para>This property element contains a list of solids. The order of the elements is significant and shall be preserved when processing the array.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SolidArrayPropertyType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("solidMembers", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.SolidArrayProperty))]
    public partial class SolidArrayPropertyType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AbstractSolidType> _abstractSolid;
        
        [System.Xml.Serialization.XmlElementAttribute("AbstractSolid")]
        public System.Collections.ObjectModel.Collection<AbstractSolidType> AbstractSolid
        {
            get
            {
                return this._abstractSolid;
            }
            private set
            {
                this._abstractSolid = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AbstractSolid-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AbstractSolid collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AbstractSolidSpecified
        {
            get
            {
                return (this.AbstractSolid.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="SolidArrayPropertyType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SolidArrayPropertyType" /> class.</para>
        /// </summary>
        public SolidArrayPropertyType()
        {
            this._abstractSolid = new System.Collections.ObjectModel.Collection<AbstractSolidType>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _owns = false;
        
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("owns")]
        public bool Owns
        {
            get
            {
                return this._owns;
            }
            set
            {
                this._owns = value;
            }
        }
    }
}
