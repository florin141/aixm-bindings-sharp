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
    [System.Xml.Serialization.XmlTypeAttribute("UnitTimeSliceTypeExtension", Namespace="http://www.aixm.aero/schema/5.1.1", AnonymousType=true)]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UnitTimeSliceTypeExtension
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("AircraftCharacteristicExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AircraftCharacteristicExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("AirportHeliportExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirportHeliportExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("AirspaceExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirspaceExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("AirspaceActivationExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirspaceActivationExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("DesignatedPointExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.DesignatedPointExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("FlightCharacteristicExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlightCharacteristicExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("FlightConditionElementExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlightConditionElementExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("FlightRestrictionExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlightRestrictionExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("NavaidExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.NavaidExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("ProcedureExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.ProcedureExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("RouteExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RouteExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("RouteAvailabilityExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RouteAvailabilityExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("RoutePortionExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RoutePortionExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("RouteSegmentExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RouteSegmentExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("StandardInstrumentArrivalExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.StandardInstrumentArrivalExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("StandardInstrumentDepartureExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.StandardInstrumentDepartureExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("TimesheetExtension", Type=typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.TimesheetExtensionType), Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
        [System.Xml.Serialization.XmlElementAttribute("AbstractUnitExtension")]
        public aixm.v5_1_1.AbstractExtensionType AbstractUnitExtension { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _owns = false;
        
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("owns")]
        public bool Owns
        {
            get
            {
                return this._owns;
            }
            set
            {
                this._owns = value;
            }
        }
    }
}
