//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace org.isotc211._2005.gmd
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>Boundary enclosing the dataset expressed as the closed set of (x,y) coordinates of the polygon (last point replicates first point)</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("EX_BoundingPolygon_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("EX_BoundingPolygon", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class EX_BoundingPolygon_Type : org.isotc211._2005.gmd.AbstractEX_GeographicExtent_Type
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gss.GM_Object_PropertyType> _polygon;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("polygon")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gss.GM_Object_PropertyType> Polygon
        {
            get
            {
                return this._polygon;
            }
            private set
            {
                this._polygon = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EX_BoundingPolygon_Type" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EX_BoundingPolygon_Type" /> class.</para>
        /// </summary>
        public EX_BoundingPolygon_Type()
        {
            this._polygon = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gss.GM_Object_PropertyType>();
        }
    }
}
