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
    [System.Xml.Serialization.XmlTypeAttribute("RouteAvailabilityType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("RouteAvailability", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class RouteAvailabilityType : AbstractPropertiesWithScheduleType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TimesheetPropertyType> _timeInterval;
        
        [System.Xml.Serialization.XmlElementAttribute("timeInterval", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<TimesheetPropertyType> TimeInterval
        {
            get
            {
                return this._timeInterval;
            }
            private set
            {
                this._timeInterval = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TimeInterval-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TimeInterval collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeIntervalSpecified
        {
            get
            {
                return (this.TimeInterval.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="RouteAvailabilityType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RouteAvailabilityType" /> class.</para>
        /// </summary>
        public RouteAvailabilityType()
        {
            this._timeInterval = new System.Collections.ObjectModel.Collection<TimesheetPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._specialDateAuthority = new System.Collections.ObjectModel.Collection<OrganisationAuthorityPropertyType>();
            this._levels = new System.Collections.ObjectModel.Collection<AirspaceLayerPropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<RouteAvailabilityTypeExtension>();
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
        private System.Collections.ObjectModel.Collection<OrganisationAuthorityPropertyType> _specialDateAuthority;
        
        [System.Xml.Serialization.XmlElementAttribute("specialDateAuthority", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<OrganisationAuthorityPropertyType> SpecialDateAuthority
        {
            get
            {
                return this._specialDateAuthority;
            }
            private set
            {
                this._specialDateAuthority = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SpecialDateAuthority-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SpecialDateAuthority collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SpecialDateAuthoritySpecified
        {
            get
            {
                return (this.SpecialDateAuthority.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("direction", IsNullable=true)]
        public aixm.v5_1_1.CodeDirectionType Direction { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("cardinalDirection", IsNullable=true)]
        public aixm.v5_1_1.CodeCardinalDirectionType CardinalDirection { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("status", IsNullable=true)]
        public aixm.v5_1_1.CodeRouteAvailabilityType Status { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AirspaceLayerPropertyType> _levels;
        
        [System.Xml.Serialization.XmlElementAttribute("levels", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<AirspaceLayerPropertyType> Levels
        {
            get
            {
                return this._levels;
            }
            private set
            {
                this._levels = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Levels-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Levels collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelsSpecified
        {
            get
            {
                return (this.Levels.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RouteAvailabilityTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<RouteAvailabilityTypeExtension> Extension
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
