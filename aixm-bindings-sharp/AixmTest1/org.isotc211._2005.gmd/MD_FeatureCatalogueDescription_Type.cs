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
    /// <para>Information identifing the feature catalogue</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MD_FeatureCatalogueDescription_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("MD_FeatureCatalogueDescription", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class MD_FeatureCatalogueDescription_Type : AbstractMD_ContentInformation_Type
    {
        
        [System.Xml.Serialization.XmlElementAttribute("complianceCode")]
        public org.isotc211._2005.gco.Boolean_PropertyType ComplianceCode { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType> _language;
        
        [System.Xml.Serialization.XmlElementAttribute("language")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType> Language
        {
            get
            {
                return this._language;
            }
            private set
            {
                this._language = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Language-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Language collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LanguageSpecified
        {
            get
            {
                return (this.Language.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="MD_FeatureCatalogueDescription_Type" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="MD_FeatureCatalogueDescription_Type" /> class.</para>
        /// </summary>
        public MD_FeatureCatalogueDescription_Type()
        {
            this._language = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType>();
            this._featureTypes = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.GenericName_PropertyType>();
            this._featureCatalogueCitation = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gmd.CI_Citation_PropertyType>();
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("includedWithDataset")]
        public org.isotc211._2005.gco.Boolean_PropertyType IncludedWithDataset { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.GenericName_PropertyType> _featureTypes;
        
        [System.Xml.Serialization.XmlElementAttribute("featureTypes")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.GenericName_PropertyType> FeatureTypes
        {
            get
            {
                return this._featureTypes;
            }
            private set
            {
                this._featureTypes = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FeatureTypes-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FeatureTypes collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeatureTypesSpecified
        {
            get
            {
                return (this.FeatureTypes.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gmd.CI_Citation_PropertyType> _featureCatalogueCitation;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("featureCatalogueCitation")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gmd.CI_Citation_PropertyType> FeatureCatalogueCitation
        {
            get
            {
                return this._featureCatalogueCitation;
            }
            private set
            {
                this._featureCatalogueCitation = value;
            }
        }
    }
}
