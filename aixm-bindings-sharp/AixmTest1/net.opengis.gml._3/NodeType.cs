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
    /// <para>gml:Node represents the 0-dimensional primitive.
    ///The optional coboundary of a node (gml:directedEdge) is a sequence of directed edges which are incident on this node. Edges emanating from this node appear in the node coboundary with a negative orientation. 
    ///If provided, the aggregationType attribute shall have the value "sequence".
    ///A node may optionally be realised by a 0-dimensional geometric primitive (gml:pointProperty).</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("NodeType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Node", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class NodeType : AbstractTopoPrimitiveType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("container")]
        public FaceOrTopoSolidPropertyType Container { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DirectedEdgePropertyType> _directedEdge;
        
        /// <summary>
        /// <para>In the case of planar topology, a gml:Node must have a clockwise sequence of gml:directedEdge properties, to ensure a lossless topology representation as defined by Kuijpers, et. al. (see OGC 05-102 Topology IPR).</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("directedEdge")]
        public System.Collections.ObjectModel.Collection<DirectedEdgePropertyType> DirectedEdge
        {
            get
            {
                return this._directedEdge;
            }
            private set
            {
                this._directedEdge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DirectedEdge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DirectedEdge collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectedEdgeSpecified
        {
            get
            {
                return (this.DirectedEdge.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="NodeType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="NodeType" /> class.</para>
        /// </summary>
        public NodeType()
        {
            this._directedEdge = new System.Collections.ObjectModel.Collection<DirectedEdgePropertyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("pointProperty")]
        public net.opengis.gml._3.PointPropertyType PointProperty { get; set; }
        
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
