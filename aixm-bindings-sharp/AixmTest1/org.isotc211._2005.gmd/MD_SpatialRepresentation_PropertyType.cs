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
    [System.Xml.Serialization.XmlTypeAttribute("MD_SpatialRepresentation_PropertyType", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MD_SpatialRepresentation_PropertyType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("MD_GridSpatialRepresentation", Type=typeof(MD_GridSpatialRepresentation_Type), Namespace="http://www.isotc211.org/2005/gmd")]
        [System.Xml.Serialization.XmlElementAttribute("MD_VectorSpatialRepresentation", Type=typeof(MD_VectorSpatialRepresentation_Type), Namespace="http://www.isotc211.org/2005/gmd")]
        [System.Xml.Serialization.XmlElementAttribute("MD_Georeferenceable", Type=typeof(MD_Georeferenceable_Type), Namespace="http://www.isotc211.org/2005/gmd")]
        [System.Xml.Serialization.XmlElementAttribute("MD_Georectified", Type=typeof(MD_Georectified_Type), Namespace="http://www.isotc211.org/2005/gmd")]
        [System.Xml.Serialization.XmlElementAttribute("AbstractMD_SpatialRepresentation")]
        public AbstractMD_SpatialRepresentation_Type AbstractMD_SpatialRepresentation { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private org.w3._1999.xlink.TypeType _type = org.w3._1999.xlink.TypeType.Simple;
        
        [System.ComponentModel.DefaultValueAttribute(org.w3._1999.xlink.TypeType.Simple)]
        [System.Xml.Serialization.XmlAttributeAttribute("type", Namespace="http://www.w3.org/1999/xlink")]
        public org.w3._1999.xlink.TypeType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("href", Namespace="http://www.w3.org/1999/xlink")]
        public string Href { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("role", Namespace="http://www.w3.org/1999/xlink")]
        public string Role { get; set; }
        
        /// <summary>
        /// <para xml:lang="en">Minimum length: 1.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MinLengthAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("arcrole", Namespace="http://www.w3.org/1999/xlink")]
        public string Arcrole { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("title", Namespace="http://www.w3.org/1999/xlink")]
        public string Title { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("show", Namespace="http://www.w3.org/1999/xlink")]
        public org.w3._1999.xlink.ShowType Show { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Show-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Show property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShowSpecified { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("actuate", Namespace="http://www.w3.org/1999/xlink")]
        public org.w3._1999.xlink.ActuateType Actuate { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Actuate-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Actuate property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActuateSpecified { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("uuidref")]
        public string Uuidref { get; set; }
        
        /// <summary>
        /// <para>gml:NilReasonType defines a content model that allows recording of an explanation for a void value or other exception.
        ///gml:NilReasonType is a union of the following enumerated values:
        ///-	inapplicable there is no value
        ///-	missing the correct value is not readily available to the sender of this data. Furthermore, a correct value may not exist
        ///-	template the value will be available later
        ///-	unknown the correct value is not known to, and not computable by, the sender of this data. However, a correct value probably exists
        ///-	withheld the value is not divulged
        ///-	other:text other brief explanation, where text is a string of two or more characters with no included spaces
        ///and
        ///-	anyURI which should refer to a resource which describes the reason for the exception
        ///A particular community may choose to assign more detailed semantics to the standard values provided. Alternatively, the URI method enables a specific or more complete explanation for the absence of a value to be provided elsewhere and indicated by-reference in an instance document.
        ///gml:NilReasonType is used as a member of a union in a number of simple content types where it is necessary to permit a value from the NilReasonType union as an alternative to the primary type.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("nilReason", Namespace="http://www.isotc211.org/2005/gco")]
        public string NilReason { get; set; }
    }
}
