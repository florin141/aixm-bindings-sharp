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
    [System.Xml.Serialization.XmlTypeAttribute("MD_Band_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("MD_Band", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_Band_Type : MD_RangeDimension_Type
    {
        
        [System.Xml.Serialization.XmlElementAttribute("maxValue")]
        public org.isotc211._2005.gco.Real_PropertyType MaxValue { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("minValue")]
        public org.isotc211._2005.gco.Real_PropertyType MinValue { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("units")]
        public org.isotc211._2005.gco.UomLength_PropertyType Units { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("peakResponse")]
        public org.isotc211._2005.gco.Real_PropertyType PeakResponse { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("bitsPerValue")]
        public org.isotc211._2005.gco.Integer_PropertyType BitsPerValue { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("toneGradation")]
        public org.isotc211._2005.gco.Integer_PropertyType ToneGradation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("scaleFactor")]
        public org.isotc211._2005.gco.Real_PropertyType ScaleFactor { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("offset")]
        public org.isotc211._2005.gco.Real_PropertyType Offset { get; set; }
    }
}
