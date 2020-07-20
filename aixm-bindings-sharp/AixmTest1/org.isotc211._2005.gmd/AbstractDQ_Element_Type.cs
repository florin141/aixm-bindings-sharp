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
    [System.Xml.Serialization.XmlTypeAttribute("AbstractDQ_Element_Type", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractDQ_Element", Namespace="http://www.isotc211.org/2005/gmd")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_Completeness_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_LogicalConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_PositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_TemporalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AbstractDQ_ThematicAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_AbsoluteExternalPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_AccuracyOfATimeMeasurement_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_CompletenessCommission_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_CompletenessOmission_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_ConceptualConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_DomainConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_FormatConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_GriddedDataPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_NonQuantitativeAttributeAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_QuantitativeAttributeAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_RelativeInternalPositionalAccuracy_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TemporalConsistency_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TemporalValidity_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_ThematicClassificationCorrectness_Type))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DQ_TopologicalConsistency_Type))]
    public abstract partial class AbstractDQ_Element_Type : org.isotc211._2005.gco.AbstractObject_Type
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType> _nameOfMeasure;
        
        [System.Xml.Serialization.XmlElementAttribute("nameOfMeasure")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType> NameOfMeasure
        {
            get
            {
                return this._nameOfMeasure;
            }
            private set
            {
                this._nameOfMeasure = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NameOfMeasure-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the NameOfMeasure collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NameOfMeasureSpecified
        {
            get
            {
                return (this.NameOfMeasure.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AbstractDQ_Element_Type" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AbstractDQ_Element_Type" /> class.</para>
        /// </summary>
        public AbstractDQ_Element_Type()
        {
            this._nameOfMeasure = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.CharacterString_PropertyType>();
            this._dateTime = new System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.DateTime_PropertyType>();
            this._result = new System.Collections.ObjectModel.Collection<DQ_Result_PropertyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("measureIdentification")]
        public org.isotc211._2005.gmd.MD_Identifier_PropertyType MeasureIdentification { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("measureDescription")]
        public org.isotc211._2005.gco.CharacterString_PropertyType MeasureDescription { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("evaluationMethodType")]
        public DQ_EvaluationMethodTypeCode_PropertyType EvaluationMethodType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("evaluationMethodDescription")]
        public org.isotc211._2005.gco.CharacterString_PropertyType EvaluationMethodDescription { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("evaluationProcedure")]
        public org.isotc211._2005.gmd.CI_Citation_PropertyType EvaluationProcedure { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.DateTime_PropertyType> _dateTime;
        
        [System.Xml.Serialization.XmlElementAttribute("dateTime")]
        public System.Collections.ObjectModel.Collection<org.isotc211._2005.gco.DateTime_PropertyType> DateTime
        {
            get
            {
                return this._dateTime;
            }
            private set
            {
                this._dateTime = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DateTime-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DateTime collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateTimeSpecified
        {
            get
            {
                return (this.DateTime.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DQ_Result_PropertyType> _result;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("result")]
        public System.Collections.ObjectModel.Collection<DQ_Result_PropertyType> Result
        {
            get
            {
                return this._result;
            }
            private set
            {
                this._result = value;
            }
        }
    }
}
