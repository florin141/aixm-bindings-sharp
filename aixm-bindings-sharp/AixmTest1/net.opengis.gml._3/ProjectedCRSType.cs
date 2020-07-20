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
    /// <para>gml:ProjectedCRS is a 2D coordinate reference system used to approximate the shape of the earth on a planar surface, but in such a way that the distortion that is inherent to the approximation is carefully controlled and known. Distortion correction is commonly applied to calculated bearings and distances to produce values that are a close match to actual field values.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ProjectedCRSType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ProjectedCRS", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class ProjectedCRSType : AbstractGeneralDerivedCRSType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("baseGeodeticCRS")]
        public GeodeticCRSPropertyType BaseGeodeticCRS { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("baseGeographicCRS")]
        public GeographicCRSPropertyType BaseGeographicCRS { get; set; }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("cartesianCS")]
        public net.opengis.gml._3.CartesianCSPropertyType CartesianCS { get; set; }
    }
}
