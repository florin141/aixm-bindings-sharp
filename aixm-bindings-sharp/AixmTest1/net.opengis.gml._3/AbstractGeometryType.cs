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
    /// <para>All geometry elements are derived directly or indirectly from this abstract supertype. A geometry element may have an identifying attribute (gml:id), one or more names (elements identifier and name) and a description (elements description and descriptionReference) . It may be associated with a spatial reference system (attribute group gml:SRSReferenceGroup).
    ///The following rules shall be adhered to:
    ///-	Every geometry type shall derive from this abstract type.
    ///-	Every geometry element (i.e. an element of a geometry type) shall be directly or indirectly in the substitution group of AbstractGeometry.</para>
    /// <para>The AbstractGeometry element is the abstract head of the substitution group for all geometry elements of GML. This includes pre-defined and user-defined geometry elements. Any geometry element shall be a direct or indirect extension/restriction of AbstractGeometryType and shall be directly or indirectly in the substitution group of AbstractGeometry.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbstractGeometryType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGeometry", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.AbstractGeometricAggregateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractGeometricPrimitiveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.AbstractImplicitGeometry))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.AbstractRingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.AbstractSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.AbstractSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.CompositeCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.CompositeSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.CompositeSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.CurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevatedCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevatedPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.GeometricComplexType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.GridType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.LinearRingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LineStringType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.MultiCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.MultiGeometryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.MultiPointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.MultiSolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.MultiSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.OrientableCurveType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.OrientableSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.PolygonType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.PolyhedralSurface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.RectifiedGridType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.RingType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.ShellType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.SolidType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.TriangulatedSurface))]
    public abstract partial class AbstractGeometryType : net.opengis.gml._3.AbstractGMLType
    {
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsName")]
        public string SrsName { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("srsDimension")]
        public string SrsDimension { get; set; }
        
        /// <summary>
        /// <para>A type for a list of values of the respective simple type.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("axisLabels")]
        public System.Collections.ObjectModel.Collection<string> AxisLabels { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AxisLabels-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AxisLabels collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AxisLabelsSpecified
        {
            get
            {
                return (this.AxisLabels.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AbstractGeometryType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AbstractGeometryType" /> class.</para>
        /// </summary>
        public AbstractGeometryType()
        {
            this.AxisLabels = new System.Collections.ObjectModel.Collection<string>();
            this.UomLabels = new System.Collections.ObjectModel.Collection<string>();
        }
        
        /// <summary>
        /// <para>A type for a list of values of the respective simple type.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("uomLabels")]
        public System.Collections.ObjectModel.Collection<string> UomLabels { get; private set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die UomLabels-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the UomLabels collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UomLabelsSpecified
        {
            get
            {
                return (this.UomLabels.Count != 0);
            }
        }
    }
}
