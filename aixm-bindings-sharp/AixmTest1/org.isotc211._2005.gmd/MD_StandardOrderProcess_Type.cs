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
    /// <para>Common ways in which the dataset may be obtained or received, and related instructions and fee information</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MD_StandardOrderProcess_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("MD_StandardOrderProcess", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_StandardOrderProcess_Type : org.isotc211._2005.gco.AbstractObject_Type
    {
        
        [System.Xml.Serialization.XmlElementAttribute("fees")]
        public org.isotc211._2005.gco.CharacterString_PropertyType Fees { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("plannedAvailableDateTime")]
        public org.isotc211._2005.gco.DateTime_PropertyType PlannedAvailableDateTime { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("orderingInstructions")]
        public org.isotc211._2005.gco.CharacterString_PropertyType OrderingInstructions { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("turnaround")]
        public org.isotc211._2005.gco.CharacterString_PropertyType Turnaround { get; set; }
    }
}
