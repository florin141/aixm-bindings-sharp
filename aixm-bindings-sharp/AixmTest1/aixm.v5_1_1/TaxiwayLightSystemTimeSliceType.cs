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
    [System.Xml.Serialization.XmlTypeAttribute("TaxiwayLightSystemTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TaxiwayLightSystemTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class TaxiwayLightSystemTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("emergencyLighting", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType EmergencyLighting { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("intensityLevel", IsNullable=true)]
        public aixm.v5_1_1.CodeLightIntensityType IntensityLevel { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("colour", IsNullable=true)]
        public aixm.v5_1_1.CodeColourType Colour { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LightElementPropertyType> _element;
        
        [System.Xml.Serialization.XmlElementAttribute("element", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<LightElementPropertyType> Element
        {
            get
            {
                return this._element;
            }
            private set
            {
                this._element = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Element-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Element collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ElementSpecified
        {
            get
            {
                return (this.Element.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TaxiwayLightSystemTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TaxiwayLightSystemTimeSliceType" /> class.</para>
        /// </summary>
        public TaxiwayLightSystemTimeSliceType()
        {
            this._element = new System.Collections.ObjectModel.Collection<LightElementPropertyType>();
            this._availability = new System.Collections.ObjectModel.Collection<GroundLightingAvailabilityPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<TaxiwayLightSystemTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<GroundLightingAvailabilityPropertyType> _availability;
        
        [System.Xml.Serialization.XmlElementAttribute("availability", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<GroundLightingAvailabilityPropertyType> Availability
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
        
        [System.Xml.Serialization.XmlElementAttribute("position", IsNullable=true)]
        public aixm.v5_1_1.CodeTaxiwaySectionType Position { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("lightedTaxiway", IsNullable=true)]
        public TaxiwayPropertyType LightedTaxiway { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TaxiwayLightSystemTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<TaxiwayLightSystemTimeSliceTypeExtension> Extension
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
