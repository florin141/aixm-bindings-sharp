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
    [System.Xml.Serialization.XmlTypeAttribute("MD_Resolution_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Resolution", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_Resolution_Type
    {
        
        [System.Xml.Serialization.XmlElementAttribute("equivalentScale")]
        public MD_RepresentativeFraction_PropertyType EquivalentScale { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("distance")]
        public org.isotc211._2005.gco.Distance_PropertyType Distance { get; set; }
    }
}
