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
    [System.Xml.Serialization.XmlTypeAttribute("AbstractAIXMMessageBaseType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractAIXMMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(_int.eurocontrol.cfmu.b2b.adrmessage.ADRMessageType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(other.AIXMBasicMessageType))]
    public abstract partial class AbstractAIXMMessageBaseType : AbstractAIXMFeatureBaseType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("sequenceNumber")]
        public uint SequenceNumber { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SequenceNumber-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SequenceNumber property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SequenceNumberSpecified { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("messageMetadata")]
        public MessageMetadataPropertyType MessageMetadata { get; set; }
    }
}
