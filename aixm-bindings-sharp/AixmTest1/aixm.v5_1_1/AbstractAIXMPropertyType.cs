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
    
    
    /// <summary>
    /// <para>It provides a basis for deriving AIXM feature/object properties. It defines the nilReason attribute and currently, it is only used for properties that are derived from association with an AIM object.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbstractAIXMPropertyType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AerialRefuellingAnchorPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AerialRefuellingPointPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AerialRefuellingTrackPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AircraftCharacteristicPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AircraftStandContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportHeliportAvailabilityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportHeliportContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportHeliportResponsibilityOrganisationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirportHeliportSetPatternPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportHeliportUsagePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceActivationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirspaceBorderCrossingObjectPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceGeometryComponentPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceLayerClassPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceLayerPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceVolumeDependencyPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceVolumePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AltimeterSourceStatusPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AltitudeAdjustmentPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AngleUsePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApproachAltitudeTablePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApproachConditionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApproachDistanceTablePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApproachTimingTablePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApronAreaAvailabilityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApronAreaUsagePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApronContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AuthorityForAerialRefuellingPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AuthorityForNavaidEquipmentPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AuthorityForSpecialNavigationStationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AuthorityForSpecialNavigationSystemPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CallsignDetailPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CircleSectorPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CirclingRestrictionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ConditionCombinationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ContactInformationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CurvePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DepartureArrivalConditionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DirectFlightClassPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DirectFlightPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DirectFlightSegmentPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevatedCurvePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevatedPointPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevatedSurfacePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.EnRouteSegmentPointPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.EquipmentUnavailableAdjustmentColumnPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.EquipmentUnavailableAdjustmentPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FASDataBlockPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FinalProfilePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightCharacteristicPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightConditionCircumstancePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightConditionCombinationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightConditionElementPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightRestrictionLevelPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightRestrictionRoutePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightRoutingElementPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlowLocationElementPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FUARestrictionActivationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FuelPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.GroundLightingAvailabilityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.HoldingPatternDistancePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.HoldingPatternDurationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.HoldingUsePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.IntermediateSignificantPointPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.LandingTakeoffAreaCollectionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.LightActivationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.LightElementPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.LightElementStatusPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.LinguisticNotePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ManoeuvringAreaAvailabilityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ManoeuvringAreaUsagePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.MarkingElementPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.MeteorologyPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.MinimaPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.MissedApproachGroupPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavaidComponentPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavaidEquipmentDistancePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavaidEquipmentMonitoringPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavaidOperationalStatusPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavigationAreaSectorPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NitrogenPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NotePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ObstacleAssessmentAreaPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ObstaclePlacementPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ObstructionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.OilPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.OnlineContactPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.OrganisationAuthorityAssociationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.OxygenPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PointPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PointReferencePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.PointUsagePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PostalAddressPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ProcedureAvailabilityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ProcedureTransitionLegPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ProcedureTransitionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PropertiesWithSchedulePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RadarComponentPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RadioCommunicationOperationalStatusPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ReflectorPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RidgePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RouteAvailabilityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RoutePortionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RouteSegmentVerticalLimitPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayDeclaredDistancePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayDeclaredDistanceValuePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwaySectionContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SafeAltitudeAreaSectorPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SectorDesignPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SegmentPointPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ServiceOperationalStatusPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SpecialNavigationStationStatusPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.StandardLevelPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.SunriseSunsetRowPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurfaceCharacteristicsPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurfaceContaminationLayerPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurfaceContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurfacePropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurveillanceGroundStationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.SynonymPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiwayContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TelephoneContactPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TerminalArrivalAreaSectorPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TerminalSegmentPointPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TimesheetPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TouchDownLiftOffContaminationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.TrafficVolumeActivationPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.TrafficVolumeLinkedFlowPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.UnitAvailabilityPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.UnitDependencyPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.UsageConditionPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.VerticalStructureLightingStatusPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.VerticalStructurePartPropertyType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.WorkareaActivityPropertyType))]
    public abstract partial class AbstractAIXMPropertyType
    {
        
        /// <summary>
        /// <para xml:lang="en">Pattern: other:\w{2,}.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("other:\\w{2,}")]
        [System.Xml.Serialization.XmlAttributeAttribute("nilReason")]
        public string NilReason { get; set; }
    }
}
