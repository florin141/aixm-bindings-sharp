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
    /// <para>Information describing metadata extensions.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MD_MetadataExtensionInformation_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("MD_MetadataExtensionInformation", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_MetadataExtensionInformation_Type : org.isotc211._2005.gco.AbstractObject_Type
    {
        
        [System.Xml.Serialization.XmlElementAttribute("extensionOnLineResource")]
        public org.isotc211._2005.gmd.CI_OnlineResource_PropertyType ExtensionOnLineResource { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MD_ExtendedElementInformation_PropertyType> _extendedElementInformation;
        
        [System.Xml.Serialization.XmlElementAttribute("extendedElementInformation")]
        public System.Collections.ObjectModel.Collection<MD_ExtendedElementInformation_PropertyType> ExtendedElementInformation
        {
            get
            {
                return this._extendedElementInformation;
            }
            private set
            {
                this._extendedElementInformation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ExtendedElementInformation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ExtendedElementInformation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtendedElementInformationSpecified
        {
            get
            {
                return (this.ExtendedElementInformation.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="MD_MetadataExtensionInformation_Type" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="MD_MetadataExtensionInformation_Type" /> class.</para>
        /// </summary>
        public MD_MetadataExtensionInformation_Type()
        {
            this._extendedElementInformation = new System.Collections.ObjectModel.Collection<MD_ExtendedElementInformation_PropertyType>();
        }
    }
}
