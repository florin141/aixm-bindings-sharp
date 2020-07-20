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
    [System.Xml.Serialization.XmlTypeAttribute("NavigationAreaTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("NavigationAreaTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class NavigationAreaTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("navigationAreaType", IsNullable=true)]
        public aixm.v5_1_1.CodeNavigationAreaType NavigationAreaType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("minimumCeiling", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceVerticalType MinimumCeiling { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("minimumVisibility", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType MinimumVisibility { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("departure", IsNullable=true)]
        public StandardInstrumentDeparturePropertyType Departure { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<NavigationAreaSectorPropertyType> _sector;
        
        [System.Xml.Serialization.XmlElementAttribute("sector", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<NavigationAreaSectorPropertyType> Sector
        {
            get
            {
                return this._sector;
            }
            private set
            {
                this._sector = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Sector-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Sector collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SectorSpecified
        {
            get
            {
                return (this.Sector.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="NavigationAreaTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="NavigationAreaTimeSliceType" /> class.</para>
        /// </summary>
        public NavigationAreaTimeSliceType()
        {
            this._sector = new System.Collections.ObjectModel.Collection<NavigationAreaSectorPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<NavigationAreaTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("centrePoint_fixDesignatedPoint", IsNullable=true)]
        public DesignatedPointPropertyType CentrePoint_FixDesignatedPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("centrePoint_navaidSystem", IsNullable=true)]
        public NavaidPropertyType CentrePoint_NavaidSystem { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("centrePoint_position", IsNullable=true)]
        public PointPropertyType CentrePoint_Position { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("centrePoint_runwayPoint", IsNullable=true)]
        public RunwayCentrelinePointPropertyType CentrePoint_RunwayPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("centrePoint_aimingPoint", IsNullable=true)]
        public TouchDownLiftOffPropertyType CentrePoint_AimingPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("centrePoint_airportReferencePoint", IsNullable=true)]
        public AirportHeliportPropertyType CentrePoint_AirportReferencePoint { get; set; }
        
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
        private System.Collections.ObjectModel.Collection<NavigationAreaTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<NavigationAreaTimeSliceTypeExtension> Extension
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
