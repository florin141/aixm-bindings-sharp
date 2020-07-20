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
    [System.Xml.Serialization.XmlTypeAttribute("AirportHeliportTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AirportHeliportTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class AirportHeliportTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("designator", IsNullable=true)]
        public aixm.v5_1_1.CodeAirportHeliportDesignatorType Designator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("name", IsNullable=true)]
        public aixm.v5_1_1.TextNameType Name { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("locationIndicatorICAO", IsNullable=true)]
        public aixm.v5_1_1.CodeICAOType LocationIndicatorICAO { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("designatorIATA", IsNullable=true)]
        public aixm.v5_1_1.CodeIATAType DesignatorIATA { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("type", IsNullable=true)]
        public aixm.v5_1_1.CodeAirportHeliportType Type { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("certifiedICAO", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType CertifiedICAO { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("privateUse", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType PrivateUse { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("controlType", IsNullable=true)]
        public aixm.v5_1_1.CodeMilitaryOperationsType ControlType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("fieldElevation", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType FieldElevation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("fieldElevationAccuracy", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType FieldElevationAccuracy { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("verticalDatum", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalDatumType VerticalDatum { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("magneticVariation", IsNullable=true)]
        public aixm.v5_1_1.ValMagneticVariationType MagneticVariation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("magneticVariationAccuracy", IsNullable=true)]
        public aixm.v5_1_1.ValAngleType MagneticVariationAccuracy { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dateMagneticVariation", IsNullable=true)]
        public aixm.v5_1_1.DateYearType DateMagneticVariation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("magneticVariationChange", IsNullable=true)]
        public aixm.v5_1_1.ValMagneticVariationChangeType MagneticVariationChange { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("referenceTemperature", IsNullable=true)]
        public aixm.v5_1_1.ValTemperatureType ReferenceTemperature { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("altimeterCheckLocation", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType AltimeterCheckLocation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("secondaryPowerSupply", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType SecondaryPowerSupply { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("windDirectionIndicator", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType WindDirectionIndicator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("landingDirectionIndicator", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType LandingDirectionIndicator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("transitionAltitude", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType TransitionAltitude { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("transitionLevel", IsNullable=true)]
        public aixm.v5_1_1.ValFLType TransitionLevel { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("lowestTemperature", IsNullable=true)]
        public aixm.v5_1_1.ValTemperatureType LowestTemperature { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("abandoned", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType Abandoned { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("certificationDate", IsNullable=true)]
        public aixm.v5_1_1.DateType CertificationDate { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("certificationExpirationDate", IsNullable=true)]
        public aixm.v5_1_1.DateType CertificationExpirationDate { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AirportHeliportContaminationPropertyType> _contaminant;
        
        [System.Xml.Serialization.XmlElementAttribute("contaminant", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AirportHeliportContaminationPropertyType> Contaminant
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AirportHeliportTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AirportHeliportTimeSliceType" /> class.</para>
        /// </summary>
        public AirportHeliportTimeSliceType()
        {
            this._contaminant = new System.Collections.ObjectModel.Collection<AirportHeliportContaminationPropertyType>();
            this._servedCity = new System.Collections.ObjectModel.Collection<CityPropertyType>();
            this._altimeterSource = new System.Collections.ObjectModel.Collection<AltimeterSourcePropertyType>();
            this._contact = new System.Collections.ObjectModel.Collection<ContactInformationPropertyType>();
            this._availability = new System.Collections.ObjectModel.Collection<AirportHeliportAvailabilityPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<AirportHeliportTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<CityPropertyType> _servedCity;
        
        [System.Xml.Serialization.XmlElementAttribute("servedCity", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<CityPropertyType> ServedCity
        {
            get
            {
                return this._servedCity;
            }
            private set
            {
                this._servedCity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ServedCity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ServedCity collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ServedCitySpecified
        {
            get
            {
                return (this.ServedCity.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("responsibleOrganisation", IsNullable=true)]
        public AirportHeliportResponsibilityOrganisationPropertyType ResponsibleOrganisation { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("ARP", IsNullable=true)]
        public ElevatedPointPropertyType ARP { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("aviationBoundary", IsNullable=true)]
        public ElevatedSurfacePropertyType AviationBoundary { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AltimeterSourcePropertyType> _altimeterSource;
        
        [System.Xml.Serialization.XmlElementAttribute("altimeterSource", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AltimeterSourcePropertyType> AltimeterSource
        {
            get
            {
                return this._altimeterSource;
            }
            private set
            {
                this._altimeterSource = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AltimeterSource-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AltimeterSource collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AltimeterSourceSpecified
        {
            get
            {
                return (this.AltimeterSource.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ContactInformationPropertyType> _contact;
        
        [System.Xml.Serialization.XmlElementAttribute("contact", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<ContactInformationPropertyType> Contact
        {
            get
            {
                return this._contact;
            }
            private set
            {
                this._contact = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Contact-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Contact collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContactSpecified
        {
            get
            {
                return (this.Contact.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AirportHeliportAvailabilityPropertyType> _availability;
        
        [System.Xml.Serialization.XmlElementAttribute("availability", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AirportHeliportAvailabilityPropertyType> Availability
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
        private System.Collections.ObjectModel.Collection<AirportHeliportTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<AirportHeliportTimeSliceTypeExtension> Extension
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
