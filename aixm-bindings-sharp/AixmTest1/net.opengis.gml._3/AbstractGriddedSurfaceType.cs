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
    /// <para>if provided, rows gives the number of rows, columns the number of columns in the parameter grid. The parameter grid is represented by an instance of the gml:PointGrid group.
    ///The element provides a substitution group head for the surface patches based on a grid. All derived subtypes shall conform to the constraints specified in ISO 19107:2003, 6.4.41.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbstractGriddedSurfaceType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractGriddedSurface", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CylinderType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SphereType))]
    public abstract partial class AbstractGriddedSurfaceType : AbstractParametricCurveSurfaceType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PointGridRowsRow> _rows;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlArrayAttribute("rows")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Row", Namespace="http://www.opengis.net/gml/3.2")]
        public System.Collections.ObjectModel.Collection<PointGridRowsRow> Rows
        {
            get
            {
                return this._rows;
            }
            private set
            {
                this._rows = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AbstractGriddedSurfaceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AbstractGriddedSurfaceType" /> class.</para>
        /// </summary>
        public AbstractGriddedSurfaceType()
        {
            this._rows = new System.Collections.ObjectModel.Collection<PointGridRowsRow>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("rows")]
        public string Rows_1 { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("columns")]
        public string Columns { get; set; }
    }
}
