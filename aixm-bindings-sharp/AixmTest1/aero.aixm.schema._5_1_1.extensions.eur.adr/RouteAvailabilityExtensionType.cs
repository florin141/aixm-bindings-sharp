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
    [System.Xml.Serialization.XmlTypeAttribute("RouteAvailabilityExtensionType", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("RouteAvailabilityExtension", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    public partial class RouteAvailabilityExtensionType : aixm.v5_1_1.AbstractExtensionType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("conditionalRouteType", IsNullable=true)]
        public aero.aixm.schema._5_1_1.extensions.eur.adr.CodeConditionalRouteType ConditionalRouteType { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<aixm.v5_1_1.AirspacePropertyType> _hostAirspace;
        
        [System.Xml.Serialization.XmlElementAttribute("hostAirspace", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<aixm.v5_1_1.AirspacePropertyType> HostAirspace
        {
            get
            {
                return this._hostAirspace;
            }
            private set
            {
                this._hostAirspace = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HostAirspace-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the HostAirspace collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HostAirspaceSpecified
        {
            get
            {
                return (this.HostAirspace.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="RouteAvailabilityExtensionType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="RouteAvailabilityExtensionType" /> class.</para>
        /// </summary>
        public RouteAvailabilityExtensionType()
        {
            this._hostAirspace = new System.Collections.ObjectModel.Collection<aixm.v5_1_1.AirspacePropertyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("isP3", IsNullable=true)]
        public aixm.v5_1_1.CodeYesNoType IsP3 { get; set; }
    }
}
