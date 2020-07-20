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
    /// <para>A Surface is a 2-dimensional primitive and is composed of one or more surface patches as specified in ISO 19107:2003, 6.3.17.1. The surface patches are connected to one another.
    ///patches encapsulates the patches of the surface.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SurfaceType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Surface", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevatedSurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PolyhedralSurface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurfaceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TinType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriangulatedSurface))]
    public partial class SurfaceType : net.opengis.gml._3.AbstractSurfaceType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AbstractSurfacePatchType> _patches;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("patches")]
        [System.Xml.Serialization.XmlArrayItemAttribute("PolygonPatch", Type=typeof(PolygonPatchType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Triangle", Type=typeof(TriangleType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Rectangle", Type=typeof(RectangleType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("AbstractParametricCurveSurface", Type=typeof(AbstractParametricCurveSurfaceType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("AbstractGriddedSurface", Type=typeof(AbstractGriddedSurfaceType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Cone", Type=typeof(ConeType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Cylinder", Type=typeof(CylinderType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Sphere", Type=typeof(SphereType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlArrayItemAttribute("AbstractSurfacePatch", Namespace="http://www.opengis.net/gml/3.2")]
        public System.Collections.ObjectModel.Collection<AbstractSurfacePatchType> Patches
        {
            get
            {
                return this._patches;
            }
            private set
            {
                this._patches = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="SurfaceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SurfaceType" /> class.</para>
        /// </summary>
        public SurfaceType()
        {
            this._patches = new System.Collections.ObjectModel.Collection<AbstractSurfacePatchType>();
        }
    }
}
