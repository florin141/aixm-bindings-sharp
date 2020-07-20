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
    [System.Xml.Serialization.XmlTypeAttribute("AirspaceVolumeDependencyType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AirspaceVolumeDependency", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class AirspaceVolumeDependencyType : aixm.v5_1_1.AbstractAIXMObjectType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("dependency", IsNullable=true)]
        public aixm.v5_1_1.CodeAirspaceDependencyType Dependency { get; set; }
        
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AirspaceVolumeDependencyType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AirspaceVolumeDependencyType" /> class.</para>
        /// </summary>
        public AirspaceVolumeDependencyType()
        {
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<AirspaceVolumeDependencyTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("theAirspace")]
        public AirspacePropertyType TheAirspace { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AirspaceVolumeDependencyTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<AirspaceVolumeDependencyTypeExtension> Extension
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
