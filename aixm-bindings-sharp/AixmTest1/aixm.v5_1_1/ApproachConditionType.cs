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
    [System.Xml.Serialization.XmlTypeAttribute("ApproachConditionType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ApproachCondition", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class ApproachConditionType : aixm.v5_1_1.AbstractAIXMObjectType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("finalApproachPath", IsNullable=true)]
        public aixm.v5_1_1.CodeMinimaFinalApproachPathType FinalApproachPath { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("requiredNavigationPerformance", IsNullable=true)]
        public aixm.v5_1_1.CodeRNPType RequiredNavigationPerformance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("climbGradient", IsNullable=true)]
        public aixm.v5_1_1.ValSlopeType ClimbGradient { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("minimumSet", IsNullable=true)]
        public MinimaPropertyType MinimumSet { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CirclingRestrictionPropertyType> _circlingRestriction;
        
        [System.Xml.Serialization.XmlElementAttribute("circlingRestriction", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<CirclingRestrictionPropertyType> CirclingRestriction
        {
            get
            {
                return this._circlingRestriction;
            }
            private set
            {
                this._circlingRestriction = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CirclingRestriction-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CirclingRestriction collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CirclingRestrictionSpecified
        {
            get
            {
                return (this.CirclingRestriction.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ApproachConditionType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ApproachConditionType" /> class.</para>
        /// </summary>
        public ApproachConditionType()
        {
            this._circlingRestriction = new System.Collections.ObjectModel.Collection<CirclingRestrictionPropertyType>();
            this._aircraftCategory = new System.Collections.ObjectModel.Collection<AircraftCharacteristicPropertyType>();
            this._landingArea = new System.Collections.ObjectModel.Collection<LandingTakeoffAreaCollectionPropertyType>();
            this._designSurface = new System.Collections.ObjectModel.Collection<ObstacleAssessmentAreaPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<ApproachConditionTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AircraftCharacteristicPropertyType> _aircraftCategory;
        
        [System.Xml.Serialization.XmlElementAttribute("aircraftCategory", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AircraftCharacteristicPropertyType> AircraftCategory
        {
            get
            {
                return this._aircraftCategory;
            }
            private set
            {
                this._aircraftCategory = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AircraftCategory-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AircraftCategory collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AircraftCategorySpecified
        {
            get
            {
                return (this.AircraftCategory.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LandingTakeoffAreaCollectionPropertyType> _landingArea;
        
        [System.Xml.Serialization.XmlElementAttribute("landingArea", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<LandingTakeoffAreaCollectionPropertyType> LandingArea
        {
            get
            {
                return this._landingArea;
            }
            private set
            {
                this._landingArea = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LandingArea-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the LandingArea collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LandingAreaSpecified
        {
            get
            {
                return (this.LandingArea.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("altimeter", IsNullable=true)]
        public AltimeterSourcePropertyType Altimeter { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ObstacleAssessmentAreaPropertyType> _designSurface;
        
        [System.Xml.Serialization.XmlElementAttribute("designSurface", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<ObstacleAssessmentAreaPropertyType> DesignSurface
        {
            get
            {
                return this._designSurface;
            }
            private set
            {
                this._designSurface = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DesignSurface-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DesignSurface collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DesignSurfaceSpecified
        {
            get
            {
                return (this.DesignSurface.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NotePropertyType> _annotation;
        
        [System.Xml.Serialization.XmlElementAttribute("annotation", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<NotePropertyType> Annotation
        {
            get
            {
                return this._annotation;
            }
            private set
            {
                this._annotation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Annotation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Annotation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AnnotationSpecified
        {
            get
            {
                return (this.Annotation.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ApproachConditionTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<ApproachConditionTypeExtension> Extension
        {
            get
            {
                return this._extension;
            }
            private set
            {
                this._extension = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Extension-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Extension collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExtensionSpecified
        {
            get
            {
                return (this.Extension.Count != 0);
            }
        }
    }
}
