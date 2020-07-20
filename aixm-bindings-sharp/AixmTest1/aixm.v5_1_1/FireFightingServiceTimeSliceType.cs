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
    [System.Xml.Serialization.XmlTypeAttribute("FireFightingServiceTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("FireFightingServiceTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class FireFightingServiceTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("flightOperations", IsNullable=true)]
        public aixm.v5_1_1.CodeFlightDestinationType FlightOperations { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("rank", IsNullable=true)]
        public aixm.v5_1_1.CodeFacilityRankingType Rank { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("compliantICAO", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType CompliantICAO { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("name", IsNullable=true)]
        public aixm.v5_1_1.TextNameType Name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("location", IsNullable=true)]
        public ElevatedPointPropertyType Location { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("serviceProvider", IsNullable=true)]
        public UnitPropertyType ServiceProvider { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CallsignDetailPropertyType> _call_Sign;
        
        [System.Xml.Serialization.XmlElementAttribute("call-sign", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<CallsignDetailPropertyType> Call_Sign
        {
            get
            {
                return this._call_Sign;
            }
            private set
            {
                this._call_Sign = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Call_Sign-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Call_Sign collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Call_SignSpecified
        {
            get
            {
                return (this.Call_Sign.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="FireFightingServiceTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="FireFightingServiceTimeSliceType" /> class.</para>
        /// </summary>
        public FireFightingServiceTimeSliceType()
        {
            this._call_Sign = new System.Collections.ObjectModel.Collection<CallsignDetailPropertyType>();
            this._radioCommunication = new System.Collections.ObjectModel.Collection<RadioCommunicationChannelPropertyType>();
            this._groundCommunication = new System.Collections.ObjectModel.Collection<ContactInformationPropertyType>();
            this._availability = new System.Collections.ObjectModel.Collection<ServiceOperationalStatusPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._airportHeliport = new System.Collections.ObjectModel.Collection<AirportHeliportPropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<FireFightingServiceTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RadioCommunicationChannelPropertyType> _radioCommunication;
        
        [System.Xml.Serialization.XmlElementAttribute("radioCommunication", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<RadioCommunicationChannelPropertyType> RadioCommunication
        {
            get
            {
                return this._radioCommunication;
            }
            private set
            {
                this._radioCommunication = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RadioCommunication-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RadioCommunication collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RadioCommunicationSpecified
        {
            get
            {
                return (this.RadioCommunication.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ContactInformationPropertyType> _groundCommunication;
        
        [System.Xml.Serialization.XmlElementAttribute("groundCommunication", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<ContactInformationPropertyType> GroundCommunication
        {
            get
            {
                return this._groundCommunication;
            }
            private set
            {
                this._groundCommunication = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die GroundCommunication-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the GroundCommunication collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool GroundCommunicationSpecified
        {
            get
            {
                return (this.GroundCommunication.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ServiceOperationalStatusPropertyType> _availability;
        
        [System.Xml.Serialization.XmlElementAttribute("availability", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<ServiceOperationalStatusPropertyType> Availability
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
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AirportHeliportPropertyType> _airportHeliport;
        
        [System.Xml.Serialization.XmlElementAttribute("airportHeliport", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AirportHeliportPropertyType> AirportHeliport
        {
            get
            {
                return this._airportHeliport;
            }
            private set
            {
                this._airportHeliport = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AirportHeliport-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AirportHeliport collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AirportHeliportSpecified
        {
            get
            {
                return (this.AirportHeliport.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("category", IsNullable=true)]
        public aixm.v5_1_1.CodeFireFightingType Category { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("standard", IsNullable=true)]
        public aixm.v5_1_1.CodeAviationStandardsType Standard { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<FireFightingServiceTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<FireFightingServiceTimeSliceTypeExtension> Extension
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
