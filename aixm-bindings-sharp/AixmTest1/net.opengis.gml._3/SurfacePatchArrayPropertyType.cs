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
    /// <para>gml:SurfacePatchArrayPropertyType is a container for a sequence of surface patches.</para>
    /// <para>The patches property element contains the sequence of surface patches. The order of the elements is significant and shall be preserved when processing the array.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("SurfacePatchArrayPropertyType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("patches", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.PolygonPatches))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.TrianglePatches))]
    public partial class SurfacePatchArrayPropertyType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AbstractSurfacePatchType> _abstractSurfacePatch;
        
        [System.Xml.Serialization.XmlElementAttribute("PolygonPatch", Type=typeof(PolygonPatchType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("Triangle", Type=typeof(TriangleType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("Rectangle", Type=typeof(RectangleType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("AbstractParametricCurveSurface", Type=typeof(AbstractParametricCurveSurfaceType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("AbstractGriddedSurface", Type=typeof(AbstractGriddedSurfaceType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("Cone", Type=typeof(ConeType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("Cylinder", Type=typeof(CylinderType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("Sphere", Type=typeof(SphereType), Namespace="http://www.opengis.net/gml/3.2")]
        [System.Xml.Serialization.XmlElementAttribute("AbstractSurfacePatch")]
        public System.Collections.ObjectModel.Collection<AbstractSurfacePatchType> AbstractSurfacePatch
        {
            get
            {
                return this._abstractSurfacePatch;
            }
            private set
            {
                this._abstractSurfacePatch = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AbstractSurfacePatch-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AbstractSurfacePatch collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AbstractSurfacePatchSpecified
        {
            get
            {
                return (this.AbstractSurfacePatch.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="SurfacePatchArrayPropertyType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SurfacePatchArrayPropertyType" /> class.</para>
        /// </summary>
        public SurfacePatchArrayPropertyType()
        {
            this._abstractSurfacePatch = new System.Collections.ObjectModel.Collection<AbstractSurfacePatchType>();
        }
    }
}
