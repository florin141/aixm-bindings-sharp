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
    [System.Xml.Serialization.XmlTypeAttribute("DQ_DataQuality_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DQ_DataQuality", Namespace="http://www.isotc211.org/2005/gmd")]
    public partial class DQ_DataQuality_Type : org.isotc211._2005.gco.AbstractObject_Type
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("scope")]
        public DQ_Scope_PropertyType Scope { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DQ_Element_PropertyType> _report;
        
        [System.Xml.Serialization.XmlElementAttribute("report")]
        public System.Collections.ObjectModel.Collection<DQ_Element_PropertyType> Report
        {
            get
            {
                return this._report;
            }
            private set
            {
                this._report = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Report-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Report collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportSpecified
        {
            get
            {
                return (this.Report.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="DQ_DataQuality_Type" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DQ_DataQuality_Type" /> class.</para>
        /// </summary>
        public DQ_DataQuality_Type()
        {
            this._report = new System.Collections.ObjectModel.Collection<DQ_Element_PropertyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("lineage")]
        public LI_Lineage_PropertyType Lineage { get; set; }
    }
}
