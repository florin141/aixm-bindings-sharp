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
    [System.Xml.Serialization.XmlTypeAttribute("AircraftStandTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AircraftStandTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class AircraftStandTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("designator", IsNullable=true)]
        public aixm.v5_1_1.TextDesignatorType Designator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("type", IsNullable=true)]
        public aixm.v5_1_1.CodeAircraftStandType Type { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("visualDockingSystem", IsNullable=true)]
        public aixm.v5_1_1.CodeVisualDockingGuidanceType VisualDockingSystem { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("surfaceProperties", IsNullable=true)]
        public SurfaceCharacteristicsPropertyType SurfaceProperties { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("location", IsNullable=true)]
        public ElevatedPointPropertyType Location { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("apronLocation", IsNullable=true)]
        public ApronElementPropertyType ApronLocation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("extent", IsNullable=true)]
        public ElevatedSurfacePropertyType Extent { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AircraftStandContaminationPropertyType> _contaminant;
        
        [System.Xml.Serialization.XmlElementAttribute("contaminant", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AircraftStandContaminationPropertyType> Contaminant
        {
            get
            {
                return this._contaminant;
            }
            private set
            {
                this._contaminant = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Contaminant-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Contaminant collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContaminantSpecified
        {
            get
            {
                return (this.Contaminant.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AircraftStandTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AircraftStandTimeSliceType" /> class.</para>
        /// </summary>
        public AircraftStandTimeSliceType()
        {
            this._contaminant = new System.Collections.ObjectModel.Collection<AircraftStandContaminationPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._availability = new System.Collections.ObjectModel.Collection<ApronAreaAvailabilityPropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<AircraftStandTimeSliceTypeExtension>();
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
        private System.Collections.ObjectModel.Collection<ApronAreaAvailabilityPropertyType> _availability;
        
        [System.Xml.Serialization.XmlElementAttribute("availability", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<ApronAreaAvailabilityPropertyType> Availability
        {
            get
            {
                return this._availability;
            }
            private set
            {
                this._availability = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Availability-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Availability collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AvailabilitySpecified
        {
            get
            {
                return (this.Availability.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AircraftStandTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<AircraftStandTimeSliceTypeExtension> Extension
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
