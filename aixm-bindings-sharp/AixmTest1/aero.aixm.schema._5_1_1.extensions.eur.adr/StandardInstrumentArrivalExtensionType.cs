//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0.

using aixm.v5_1_1;

namespace aero.aixm.schema._5_1_1.extensions.eur.adr
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("StandardInstrumentArrivalExtensionType", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("StandardInstrumentArrivalExtension", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    public partial class StandardInstrumentArrivalExtensionType : AbstractExtensionType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TerminalSegmentPointPropertyType> _connectingPoint;
        
        [System.Xml.Serialization.XmlElementAttribute("connectingPoint", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<TerminalSegmentPointPropertyType> ConnectingPoint
        {
            get
            {
                return this._connectingPoint;
            }
            private set
            {
                this._connectingPoint = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ConnectingPoint-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ConnectingPoint collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConnectingPointSpecified
        {
            get
            {
                return (this.ConnectingPoint.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="StandardInstrumentArrivalExtensionType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="StandardInstrumentArrivalExtensionType" /> class.</para>
        /// </summary>
        public StandardInstrumentArrivalExtensionType()
        {
            this._connectingPoint = new System.Collections.ObjectModel.Collection<TerminalSegmentPointPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("initialApproachFix", IsNullable=true)]
        public TerminalSegmentPointPropertyType InitialApproachFix { get; set; }
        
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
    }
}
