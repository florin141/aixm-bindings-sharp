//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace aero.aixm.schema._5_1_1.extensions.eur.adr
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AirspaceBorderCrossingObjectType", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AirspaceBorderCrossingObject", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    public partial class AirspaceBorderCrossingObjectType : aixm.v5_1_1.AbstractAIXMObjectType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("exitedAirspace", IsNullable=true)]
        public aixm.v5_1_1.AirspacePropertyType ExitedAirspace { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("enteredAirspace", IsNullable=true)]
        public aixm.v5_1_1.AirspacePropertyType EnteredAirspace { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<aixm.v5_1_1.NotePropertyType> _annotation;
        
        [System.Xml.Serialization.XmlElementAttribute("annotation", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<aixm.v5_1_1.NotePropertyType> Annotation
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AirspaceBorderCrossingObjectType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AirspaceBorderCrossingObjectType" /> class.</para>
        /// </summary>
        public AirspaceBorderCrossingObjectType()
        {
            this._annotation = new System.Collections.ObjectModel.Collection<aixm.v5_1_1.NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<AirspaceBorderCrossingObjectTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<AirspaceBorderCrossingObjectTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<AirspaceBorderCrossingObjectTypeExtension> Extension
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
