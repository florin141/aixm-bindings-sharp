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
    [System.Xml.Serialization.XmlTypeAttribute("WorkAreaTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("WorkAreaTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class WorkAreaTimeSliceType : aixm.v5_1_1.AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("type", IsNullable=true)]
        public aixm.v5_1_1.CodeWorkAreaType Type { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("plannedOperational", IsNullable=true)]
        public aixm.v5_1_1.DateType PlannedOperational { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("associatedAirportHeliport", IsNullable=true)]
        public AirportHeliportPropertyType AssociatedAirportHeliport { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("extent", IsNullable=true)]
        public ElevatedSurfacePropertyType Extent { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<WorkareaActivityPropertyType> _activation;
        
        [System.Xml.Serialization.XmlElementAttribute("activation", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<WorkareaActivityPropertyType> Activation
        {
            get
            {
                return this._activation;
            }
            private set
            {
                this._activation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Activation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Activation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActivationSpecified
        {
            get
            {
                return (this.Activation.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="WorkAreaTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="WorkAreaTimeSliceType" /> class.</para>
        /// </summary>
        public WorkAreaTimeSliceType()
        {
            this._activation = new System.Collections.ObjectModel.Collection<WorkareaActivityPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<WorkAreaTimeSliceTypeExtension>();
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
        private System.Collections.ObjectModel.Collection<WorkAreaTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<WorkAreaTimeSliceTypeExtension> Extension
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
