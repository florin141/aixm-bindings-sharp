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
    /// <para>Identifiable collection of datasets</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbstractDS_Aggregate_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDS_Aggregate", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(org.isotc211._2005.gmd.DS_Initiative_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(org.isotc211._2005.gmd.DS_OtherAggregate_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(org.isotc211._2005.gmd.DS_Platform_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(org.isotc211._2005.gmd.DS_ProductionSeries_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(org.isotc211._2005.gmd.DS_Sensor_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(org.isotc211._2005.gmd.DS_Series_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(org.isotc211._2005.gmd.DS_StereoMate_Type))]
    public abstract partial class AbstractDS_Aggregate_Type : org.isotc211._2005.gco.AbstractObject_Type
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DS_DataSet_PropertyType> _composedOf;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("composedOf")]
        public System.Collections.ObjectModel.Collection<DS_DataSet_PropertyType> ComposedOf
        {
            get
            {
                return this._composedOf;
            }
            private set
            {
                this._composedOf = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AbstractDS_Aggregate_Type" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AbstractDS_Aggregate_Type" /> class.</para>
        /// </summary>
        public AbstractDS_Aggregate_Type()
        {
            this._composedOf = new System.Collections.ObjectModel.Collection<DS_DataSet_PropertyType>();
            this._seriesMetadata = new System.Collections.ObjectModel.Collection<MD_Metadata_PropertyType>();
            this._subset = new System.Collections.ObjectModel.Collection<DS_Aggregate_PropertyType>();
            this._superset = new System.Collections.ObjectModel.Collection<DS_Aggregate_PropertyType>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<MD_Metadata_PropertyType> _seriesMetadata;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("seriesMetadata")]
        public System.Collections.ObjectModel.Collection<MD_Metadata_PropertyType> SeriesMetadata
        {
            get
            {
                return this._seriesMetadata;
            }
            private set
            {
                this._seriesMetadata = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DS_Aggregate_PropertyType> _subset;
        
        [System.Xml.Serialization.XmlElementAttribute("subset")]
        public System.Collections.ObjectModel.Collection<DS_Aggregate_PropertyType> Subset
        {
            get
            {
                return this._subset;
            }
            private set
            {
                this._subset = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Subset-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Subset collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubsetSpecified
        {
            get
            {
                return (this.Subset.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DS_Aggregate_PropertyType> _superset;
        
        [System.Xml.Serialization.XmlElementAttribute("superset")]
        public System.Collections.ObjectModel.Collection<DS_Aggregate_PropertyType> Superset
        {
            get
            {
                return this._superset;
            }
            private set
            {
                this._superset = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Superset-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Superset collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupersetSpecified
        {
            get
            {
                return (this.Superset.Count != 0);
            }
        }
    }
}
