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
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AngleChoiceType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AngleChoiceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("angle")]
        public net.opengis.gml._3.AngleType Angle { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dmsAngle")]
        public net.opengis.gml._3.DMSAngleType DmsAngle { get; set; }
    }
}
