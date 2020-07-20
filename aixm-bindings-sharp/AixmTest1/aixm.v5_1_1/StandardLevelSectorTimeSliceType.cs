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
    [System.Xml.Serialization.XmlTypeAttribute("StandardLevelSectorTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("StandardLevelSectorTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class StandardLevelSectorTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("flightRule", IsNullable=true)]
        public aixm.v5_1_1.CodeFlightRuleType FlightRule { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("fromTrack", IsNullable=true)]
        public aixm.v5_1_1.ValBearingType FromTrack { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("toTrack", IsNullable=true)]
        public aixm.v5_1_1.ValBearingType ToTrack { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("angleType", IsNullable=true)]
        public aixm.v5_1_1.CodeNorthReferenceType AngleType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AirspacePropertyType> _applicableAirspace;
        
        [System.Xml.Serialization.XmlElementAttribute("applicableAirspace", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AirspacePropertyType> ApplicableAirspace
        {
            get
            {
                return this._applicableAirspace;
            }
            private set
            {
                this._applicableAirspace = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ApplicableAirspace-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ApplicableAirspace collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ApplicableAirspaceSpecified
        {
            get
            {
                return (this.ApplicableAirspace.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="StandardLevelSectorTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="StandardLevelSectorTimeSliceType" /> class.</para>
        /// </summary>
        public StandardLevelSectorTimeSliceType()
        {
            this._applicableAirspace = new System.Collections.ObjectModel.Collection<AirspacePropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<StandardLevelSectorTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("applicableLevelColumn", IsNullable=true)]
        public StandardLevelColumnPropertyType ApplicableLevelColumn { get; set; }
        
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
        private System.Collections.ObjectModel.Collection<StandardLevelSectorTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<StandardLevelSectorTimeSliceTypeExtension> Extension
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
