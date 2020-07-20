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
    /// <para>A shell is used to represent a single connected component of a solid boundary as specified in ISO 19107:2003, 6.3.8.
    ///Every gml:surfaceMember references or contains one surface, i.e. any element which is substitutable for gml:AbstractSurface. In the context of a shell, the surfaces describe the boundary of the solid. 
    ///If provided, the aggregationType attribute shall have the value "set".</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ShellType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Shell", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class ShellType : net.opengis.gml._3.AbstractSurfaceType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<net.opengis.gml._3.SurfacePropertyType> _surfaceMember;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
        public System.Collections.ObjectModel.Collection<net.opengis.gml._3.SurfacePropertyType> SurfaceMember
        {
            get
            {
                return this._surfaceMember;
            }
            private set
            {
                this._surfaceMember = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ShellType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ShellType" /> class.</para>
        /// </summary>
        public ShellType()
        {
            this._surfaceMember = new System.Collections.ObjectModel.Collection<net.opengis.gml._3.SurfacePropertyType>();
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
