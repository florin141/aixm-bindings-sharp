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
    [System.Xml.Serialization.XmlTypeAttribute("ArrestingGearTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ArrestingGearTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class ArrestingGearTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("status", IsNullable=true)]
        public aixm.v5_1_1.CodeStatusOperationsType Status { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("length", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType Length { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("width", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType Width { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("engageDevice", IsNullable=true)]
        public aixm.v5_1_1.CodeArrestingGearEngageDeviceType EngageDevice { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("absorbType", IsNullable=true)]
        public aixm.v5_1_1.CodeArrestingGearEnergyAbsorbType AbsorbType { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("bidirectional", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType Bidirectional { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("location", IsNullable=true)]
        public aixm.v5_1_1.ValDistanceType Location { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<RunwayDirectionPropertyType> _runwayDirection;
        
        [System.Xml.Serialization.XmlElementAttribute("runwayDirection", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<RunwayDirectionPropertyType> RunwayDirection
        {
            get
            {
                return this._runwayDirection;
            }
            private set
            {
                this._runwayDirection = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RunwayDirection-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the RunwayDirection collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RunwayDirectionSpecified
        {
            get
            {
                return (this.RunwayDirection.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ArrestingGearTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ArrestingGearTimeSliceType" /> class.</para>
        /// </summary>
        public ArrestingGearTimeSliceType()
        {
            this._runwayDirection = new System.Collections.ObjectModel.Collection<RunwayDirectionPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<ArrestingGearTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("surfaceProperties", IsNullable=true)]
        public SurfaceCharacteristicsPropertyType SurfaceProperties { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("extent_surfaceExtent", IsNullable=true)]
        public ElevatedSurfacePropertyType Extent_SurfaceExtent { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("extent_curveExtent", IsNullable=true)]
        public ElevatedCurvePropertyType Extent_CurveExtent { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("extent_pointExtent", IsNullable=true)]
        public ElevatedPointPropertyType Extent_PointExtent { get; set; }
        
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
        private System.Collections.ObjectModel.Collection<ArrestingGearTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<ArrestingGearTimeSliceTypeExtension> Extension
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
