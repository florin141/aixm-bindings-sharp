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
    /// <para>gml:TopoSurface represents a homogeneous topological expression, a set of directed faces, which if realised are isomorphic to a geometric surface primitive. The intended use of gml:TopoSurface is to appear within a surface feature to express the structural and possibly geometric relationships of this surface feature to other features via the shared face definitions.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TopoSurfaceType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TopoSurface", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class TopoSurfaceType : AbstractTopologyType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DirectedFacePropertyType> _directedFace;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("directedFace")]
        public System.Collections.ObjectModel.Collection<DirectedFacePropertyType> DirectedFace
        {
            get
            {
                return this._directedFace;
            }
            private set
            {
                this._directedFace = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TopoSurfaceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TopoSurfaceType" /> class.</para>
        /// </summary>
        public TopoSurfaceType()
        {
            this._directedFace = new System.Collections.ObjectModel.Collection<DirectedFacePropertyType>();
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
