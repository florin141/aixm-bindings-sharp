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
    [System.Xml.Serialization.XmlTypeAttribute("ReferenceLocationTimeSliceType", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ReferenceLocationTimeSlice", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    public partial class ReferenceLocationTimeSliceType : AbstractAIXMTimeSliceType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("category", IsNullable=true)]
        public CodeFlightDestinationType Category { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("referenceLocationId", IsNullable=true)]
        public TextNameType ReferenceLocationId { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<FlowPropertyType> _associatedFlow;
        
        [System.Xml.Serialization.XmlElementAttribute("associatedFlow", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<FlowPropertyType> AssociatedFlow
        {
            get
            {
                return this._associatedFlow;
            }
            private set
            {
                this._associatedFlow = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AssociatedFlow-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AssociatedFlow collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AssociatedFlowSpecified
        {
            get
            {
                return (this.AssociatedFlow.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ReferenceLocationTimeSliceType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ReferenceLocationTimeSliceType" /> class.</para>
        /// </summary>
        public ReferenceLocationTimeSliceType()
        {
            this._associatedFlow = new System.Collections.ObjectModel.Collection<FlowPropertyType>();
            this._annotation = new System.Collections.ObjectModel.Collection<NotePropertyType>();
            this._extension = new System.Collections.ObjectModel.Collection<ReferenceLocationTimeSliceTypeExtension>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("airspaceLayer", IsNullable=true)]
        public AirspaceLayerPropertyType AirspaceLayer { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("locationChoice_airportHeliport", IsNullable=true)]
        public AirportHeliportPropertyType LocationChoice_AirportHeliport { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("locationChoice_airportHeliportSet", IsNullable=true)]
        public AirportHeliportSetPropertyType LocationChoice_AirportHeliportSet { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("locationChoice_airspace", IsNullable=true)]
        public AirspacePropertyType LocationChoice_Airspace { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("locationChoice_designatedPoint", IsNullable=true)]
        public DesignatedPointPropertyType LocationChoice_DesignatedPoint { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("locationChoice_navaid", IsNullable=true)]
        public NavaidPropertyType LocationChoice_Navaid { get; set; }
        
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
        private System.Collections.ObjectModel.Collection<ReferenceLocationTimeSliceTypeExtension> _extension;
        
        [System.Xml.Serialization.XmlElementAttribute("extension")]
        public System.Collections.ObjectModel.Collection<ReferenceLocationTimeSliceTypeExtension> Extension
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
