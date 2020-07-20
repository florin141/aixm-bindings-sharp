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
    [System.Xml.Serialization.XmlTypeAttribute("DepartureLegTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DepartureLegTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class DepartureLegTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("endConditionDesignator", IsNullable=true)]
        public aixm.v5_1_1.CodeSegmentTerminationType EndConditionDesignator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("legPath", IsNullable=true)]
        public aixm.v5_1_1.CodeTrajectoryType LegPath { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("legTypeARINC", IsNullable=true)]
        public aixm.v5_1_1.CodeSegmentPathType LegTypeARINC { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("course", IsNullable=true)]
        public aixm.v5_1_1.ValBearingType Course { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("courseType", IsNullable=true)]
        public aixm.v5_1_1.CodeCourseType CourseType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("courseDirection", IsNullable=true)]
        public aixm.v5_1_1.CodeDirectionReferenceType CourseDirection { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("turnDirection", IsNullable=true)]
        public aixm.v5_1_1.CodeDirectionTurnType TurnDirection { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("speedLimit", IsNullable=true)]
        public aixm.v5_1_1.ValSpeedType SpeedLimit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("speedReference", IsNullable=true)]
        public aixm.v5_1_1.CodeSpeedReferenceType SpeedReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("speedInterpretation", IsNullable=true)]
        public aixm.v5_1_1.CodeAltitudeUseType SpeedInterpretation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("bankAngle", IsNullable=true)]
        public aixm.v5_1_1.ValAngleType BankAngle { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("length", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType Length { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("duration", IsNullable=true)]
        public aixm.v5_1_1.ValDurationType Duration { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("procedureTurnRequired", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType ProcedureTurnRequired { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("upperLimitAltitude", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType UpperLimitAltitude { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("upperLimitReference", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalReferenceType UpperLimitReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("lowerLimitAltitude", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType LowerLimitAltitude { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("lowerLimitReference", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalReferenceType LowerLimitReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("altitudeInterpretation", IsNullable=true)]
        public aixm.v5_1_1.CodeAltitudeUseType AltitudeInterpretation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("altitudeOverrideATC", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType AltitudeOverrideATC { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("altitudeOverrideReference", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalReferenceType AltitudeOverrideReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("verticalAngle", IsNullable=true)]
        public aixm.v5_1_1.ValAngleType VerticalAngle { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("startPoint", IsNullable=true)]
        public TerminalSegmentPointPropertyType StartPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("endPoint", IsNullable=true)]
        public TerminalSegmentPointPropertyType EndPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("trajectory", IsNullable=true)]
        public CurvePropertyType Trajectory { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("arcCentre", IsNullable=true)]
        public TerminalSegmentPointPropertyType ArcCentre { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("angle", IsNullable=true)]
        public AngleIndicationPropertyType Angle { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("distance", IsNullable=true)]
        public DistanceIndicationPropertyType Distance { get; set; }
        
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
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="DepartureLegTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DepartureLegTimeSliceType" /> class.</para>
        /// </summary>
        public DepartureLegTimeSliceType()
        {
            this._aircraftCategory = new System.Collections.ObjectModel.Collection<AircraftCharacteristicPropertyType>();
            this._designSurface = new System.Collections.ObjectModel.Collection<ObstacleAssessmentAreaPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._condition = new System.Collections.ObjectModel.Collection<DepartureArrivalConditionPropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<DepartureLegTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("holding", IsNullable=true)]
        public HoldingUsePropertyType Holding { get; set; }
        
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
        
        [System.Xml.Serialization.XmlElementAttribute("requiredNavigationPerformance", IsNullable=true)]
        public aixm.v5_1_1.CodeRNPType RequiredNavigationPerformance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("minimumObstacleClearanceAltitude", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType MinimumObstacleClearanceAltitude { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("departure", IsNullable=true)]
        public StandardInstrumentDeparturePropertyType Departure { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DepartureArrivalConditionPropertyType> _condition;
        
        [System.Xml.Serialization.XmlElementAttribute("condition", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<DepartureArrivalConditionPropertyType> Condition
        {
            get
            {
                return this._condition;
            }
            private set
            {
                this._condition = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Condition-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Condition collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConditionSpecified
        {
            get
            {
                return (this.Condition.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DepartureLegTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<DepartureLegTimeSliceTypeExtension> Extension
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
