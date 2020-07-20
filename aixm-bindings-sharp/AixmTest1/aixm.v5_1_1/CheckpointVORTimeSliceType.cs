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
    [System.Xml.Serialization.XmlTypeAttribute("CheckpointVORTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("CheckpointVORTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class CheckpointVORTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("category", IsNullable=true)]
        public aixm.v5_1_1.CodeCheckpointCategoryType Category { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("upperLimit", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType UpperLimit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("upperLimitReference", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalReferenceType UpperLimitReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("lowerLimit", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType LowerLimit { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("lowerLimitReference", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalReferenceType LowerLimitReference { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("altitudeInterpretation", IsNullable=true)]
        public aixm.v5_1_1.CodeAltitudeUseType AltitudeInterpretation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("distance", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType Distance { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("angle", IsNullable=true)]
        public aixm.v5_1_1.ValBearingType Angle { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("position", IsNullable=true)]
        public ElevatedPointPropertyType Position { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("airportHeliport", IsNullable=true)]
        public AirportHeliportPropertyType AirportHeliport { get; set; }
        
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
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="CheckpointVORTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="CheckpointVORTimeSliceType" /> class.</para>
        /// </summary>
        public CheckpointVORTimeSliceType()
        {
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<CheckpointVORTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("checkPointFacility", IsNullable=true)]
        public VORPropertyType CheckPointFacility { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CheckpointVORTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<CheckpointVORTimeSliceTypeExtension> Extension
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
