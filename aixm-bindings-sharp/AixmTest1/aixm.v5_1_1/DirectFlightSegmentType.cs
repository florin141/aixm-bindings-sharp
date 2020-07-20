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
    [System.Xml.Serialization.XmlTypeAttribute("DirectFlightSegmentType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DirectFlightSegment", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class DirectFlightSegmentType : AbstractDirectFlightType
    {
        
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="DirectFlightSegmentType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DirectFlightSegmentType" /> class.</para>
        /// </summary>
        public DirectFlightSegmentType()
        {
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<DirectFlightSegmentTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("end_fixDesignatedPoint", IsNullable=true)]
        public DesignatedPointPropertyType End_FixDesignatedPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("end_navaidSystem", IsNullable=true)]
        public NavaidPropertyType End_NavaidSystem { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("end_position", IsNullable=true)]
        public PointPropertyType End_Position { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("end_runwayPoint", IsNullable=true)]
        public RunwayCentrelinePointPropertyType End_RunwayPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("end_aimingPoint", IsNullable=true)]
        public TouchDownLiftOffPropertyType End_AimingPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("end_airportReferencePoint", IsNullable=true)]
        public AirportHeliportPropertyType End_AirportReferencePoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("start_fixDesignatedPoint", IsNullable=true)]
        public DesignatedPointPropertyType Start_FixDesignatedPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("start_navaidSystem", IsNullable=true)]
        public NavaidPropertyType Start_NavaidSystem { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("start_position", IsNullable=true)]
        public PointPropertyType Start_Position { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("start_runwayPoint", IsNullable=true)]
        public RunwayCentrelinePointPropertyType Start_RunwayPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("start_aimingPoint", IsNullable=true)]
        public TouchDownLiftOffPropertyType Start_AimingPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("start_airportReferencePoint", IsNullable=true)]
        public AirportHeliportPropertyType Start_AirportReferencePoint { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<DirectFlightSegmentTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<DirectFlightSegmentTypeExtension> Extension
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
