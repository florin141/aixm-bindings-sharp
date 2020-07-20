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
    [System.Xml.Serialization.XmlTypeAttribute("VerticalStructurePartType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("VerticalStructurePart", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class VerticalStructurePartType : AbstractPropertiesWithScheduleType
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="VerticalStructurePartType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="VerticalStructurePartType" /> class.</para>
        /// </summary>
        public VerticalStructurePartType()
        {
            this._timeInterval = new System.Collections.ObjectModel.Collection<TimesheetPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._specialDateAuthority = new System.Collections.ObjectModel.Collection<OrganisationAuthorityPropertyType>();
            this._lighting = new System.Collections.ObjectModel.Collection<LightElementPropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<VerticalStructurePartTypeExtension>();
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
        
        [System.Xml.Serialization.XmlElementAttribute("verticalExtent", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType VerticalExtent { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("verticalExtentAccuracy", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType VerticalExtentAccuracy { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("type", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalStructureType Type { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("constructionStatus", IsNullable=true)]
        public aixm.v5_1_1.CodeStatusConstructionType ConstructionStatus { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("markingPattern", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalStructureMarkingType MarkingPattern { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("markingFirstColour", IsNullable=true)]
        public aixm.v5_1_1.CodeColourType MarkingFirstColour { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("markingSecondColour", IsNullable=true)]
        public aixm.v5_1_1.CodeColourType MarkingSecondColour { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("mobile", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType Mobile { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("frangible", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType Frangible { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("visibleMaterial", IsNullable=true)]
        public aixm.v5_1_1.CodeVerticalStructureMaterialType VisibleMaterial { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("designator", IsNullable=true)]
        public aixm.v5_1_1.TextDesignatorType Designator { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("horizontalProjection_surfaceExtent", IsNullable=true)]
        public ElevatedSurfacePropertyType HorizontalProjection_SurfaceExtent { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("horizontalProjection_linearExtent", IsNullable=true)]
        public ElevatedCurvePropertyType HorizontalProjection_LinearExtent { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("horizontalProjection_location", IsNullable=true)]
        public ElevatedPointPropertyType HorizontalProjection_Location { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<LightElementPropertyType> _lighting;
        
        [System.Xml.Serialization.XmlElementAttribute("lighting", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<LightElementPropertyType> Lighting
        {
            get
            {
                return this._lighting;
            }
            private set
            {
                this._lighting = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Lighting-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Lighting collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LightingSpecified
        {
            get
            {
                return (this.Lighting.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<VerticalStructurePartTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<VerticalStructurePartTypeExtension> Extension
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
