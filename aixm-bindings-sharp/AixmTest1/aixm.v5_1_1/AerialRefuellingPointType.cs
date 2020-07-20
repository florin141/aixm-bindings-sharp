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
    [System.Xml.Serialization.XmlTypeAttribute("AerialRefuellingPointType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AerialRefuellingPoint", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class AerialRefuellingPointType : AbstractSegmentPointType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("reportingATC", IsNullable=true)]
        public aixm.v5_1_1.CodeATCReportingType ReportingATC { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("flyOver", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType FlyOver { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("waypoint", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType Waypoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("radarGuidance", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType RadarGuidance { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PointReferencePropertyType> _facilityMakeup;
        
        [System.Xml.Serialization.XmlElementAttribute("facilityMakeup", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<PointReferencePropertyType> FacilityMakeup
        {
            get
            {
                return this._facilityMakeup;
            }
            private set
            {
                this._facilityMakeup = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FacilityMakeup-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the FacilityMakeup collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FacilityMakeupSpecified
        {
            get
            {
                return (this.FacilityMakeup.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AerialRefuellingPointType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AerialRefuellingPointType" /> class.</para>
        /// </summary>
        public AerialRefuellingPointType()
        {
            this._facilityMakeup = new System.Collections.ObjectModel.Collection<PointReferencePropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<AerialRefuellingPointTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("pointChoice_fixDesignatedPoint", IsNullable=true)]
        public DesignatedPointPropertyType PointChoice_FixDesignatedPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("pointChoice_navaidSystem", IsNullable=true)]
        public NavaidPropertyType PointChoice_NavaidSystem { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("pointChoice_position", IsNullable=true)]
        public PointPropertyType PointChoice_Position { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("pointChoice_runwayPoint", IsNullable=true)]
        public RunwayCentrelinePointPropertyType PointChoice_RunwayPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("pointChoice_aimingPoint", IsNullable=true)]
        public TouchDownLiftOffPropertyType PointChoice_AimingPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("pointChoice_airportReferencePoint", IsNullable=true)]
        public AirportHeliportPropertyType PointChoice_AirportReferencePoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("extendedServiceVolume", IsNullable=true)]
        public RadioFrequencyAreaPropertyType ExtendedServiceVolume { get; set; }
        
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
        
        [System.Xml.Serialization.XmlElementAttribute("sequence", IsNullable=true)]
        public aixm.v5_1_1.NoSequenceType Sequence { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("usageType", IsNullable=true)]
        public aixm.v5_1_1.CodeAerialRefuellingPointType UsageType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AerialRefuellingPointTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<AerialRefuellingPointTypeExtension> Extension
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
