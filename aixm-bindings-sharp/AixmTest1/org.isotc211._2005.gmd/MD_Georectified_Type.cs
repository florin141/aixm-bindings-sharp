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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MD_Georectified_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Georectified", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_Georectified_Type : MD_GridSpatialRepresentation_Type
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("checkPointAvailability")]
        public org.isotc211._2005.gco.Boolean_PropertyType CheckPointAvailability { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("checkPointDescription")]
        public org.isotc211._2005.gco.CharacterString_PropertyType CheckPointDescription { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gss.GM_Point_PropertyType> _cornerPoints;
        
        [System.Xml.Serialization.XmlElementAttribute("cornerPoints")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gss.GM_Point_PropertyType> CornerPoints
        {
            get
            {
                return this._cornerPoints;
            }
            private set
            {
                this._cornerPoints = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CornerPoints-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CornerPoints collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CornerPointsSpecified
        {
            get
            {
                return (this.CornerPoints.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="MD_Georectified_Type" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="MD_Georectified_Type" /> class.</para>
        /// </summary>
        public MD_Georectified_Type()
        {
            this._cornerPoints = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gss.GM_Point_PropertyType>();
            this._transformationDimensionMapping = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("centerPoint")]
        public org.isotc211._2005.gss.GM_Point_PropertyType CenterPoint { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("pointInPixel")]
        public MD_PixelOrientationCode_PropertyType PointInPixel { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("transformationDimensionDescription")]
        public org.isotc211._2005.gco.CharacterString_PropertyType TransformationDimensionDescription { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType> _transformationDimensionMapping;
        
        [System.Xml.Serialization.XmlElementAttribute("transformationDimensionMapping")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType> TransformationDimensionMapping
        {
            get
            {
                return this._transformationDimensionMapping;
            }
            private set
            {
                this._transformationDimensionMapping = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransformationDimensionMapping-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TransformationDimensionMapping collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransformationDimensionMappingSpecified
        {
            get
            {
                return (this.TransformationDimensionMapping.Count != 0);
            }
        }
    }
}
