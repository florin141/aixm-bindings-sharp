//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace aixm.v5_1_1
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MessageMetadataPropertyType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MessageMetadataPropertyType : net.opengis.gml._3.AbstractMetadataPropertyType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("MD_Metadata", Namespace="http://www.isotc211.org/2005/gmd")]
        public org.isotc211._2005.gmd.MD_Metadata_Type MD_Metadata { get; set; }
    }
}
