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
    [System.Xml.Serialization.XmlTypeAttribute("AbstractExtensionType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractExtension", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAerialRefuellingAnchorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAerialRefuellingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAerialRefuellingPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAerialRefuellingTrackExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAeronauticalGroundLightExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAircraftCharacteristicExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAircraftGroundServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAircraftStandContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAircraftStandExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportClearanceServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportGroundServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHeliportAvailabilityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHeliportCollocationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHeliportContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHeliportExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHeliportProtectionAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHeliportResponsibilityOrganisationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractAirportHeliportSetExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractAirportHeliportSetPatternExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHeliportUsageExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportHotSpotExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportProtectionAreaMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirportSuppliesServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceActivationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceBorderCrossingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractAirspaceBorderCrossingObjectExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceGeometryComponentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceLayerClassExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceLayerExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceVolumeDependencyExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirspaceVolumeExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirTrafficControlServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAirTrafficManagementServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAltimeterSourceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAltimeterSourceStatusExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAltitudeAdjustmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAngleIndicationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAngleUseExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApproachAltitudeTableExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApproachConditionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApproachDistanceTableExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApproachLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractApproachLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApproachLightingSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApproachTimingTableExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApronAreaAvailabilityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApronAreaUsageExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApronContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApronElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApronExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApronLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractApronMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractArrestingGearExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractArrivalFeederLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractArrivalLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAuthorityForAerialRefuellingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAuthorityForAirspaceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAuthorityForNavaidEquipmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAuthorityForSpecialNavigationStationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAuthorityForSpecialNavigationSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAzimuthExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractCallsignDetailExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractChangeOverPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractCheckpointINSExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractCheckpointVORExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractCircleSectorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractCirclingAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractCirclingRestrictionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractCityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractConditionCombinationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractContactInformationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDeicingAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDeicingAreaMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDepartureArrivalConditionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDepartureLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDesignatedPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDirectFlightClassExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDirectFlightExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDirectFlightSegmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDirectionFinderExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDistanceIndicationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractDMEExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractElevatedCurveExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractElevatedPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractElevatedSurfaceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractElevationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractEnRouteSegmentPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractEquipmentUnavailableAdjustmentColumnExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractEquipmentUnavailableAdjustmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFASDataBlockExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFinalLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFinalProfileExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFireFightingServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightCharacteristicExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightConditionCircumstanceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightConditionCombinationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightConditionElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightRestrictionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightRestrictionLevelExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightRestrictionRouteExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFlightRoutingElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFloatingDockSiteExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractFlowExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractFlowLocationElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractFUARestrictionActivationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractFuelExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGeoBorderExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGlidepathExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGroundLightingAvailabilityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGroundLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGroundTrafficControlServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGuidanceLineExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGuidanceLineLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractGuidanceLineMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractHoldingAssessmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractHoldingPatternDistanceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractHoldingPatternDurationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractHoldingPatternExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractHoldingUseExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractInformationServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractInitialLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractInstrumentApproachProcedureExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractIntermediateLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractIntermediateSignificantPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractLandingTakeoffAreaCollectionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractLightActivationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractLightElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractLightElementStatusExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractLinguisticNoteExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractLocalizerExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractManoeuvringAreaAvailabilityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractManoeuvringAreaUsageExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMarkerBeaconExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMarkingBuoyExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMarkingElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMeteorologyExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMinimaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMissedApproachGroupExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractMissedApproachLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavaidComponentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavaidEquipmentDistanceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavaidEquipmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavaidEquipmentMonitoringExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavaidExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavaidOperationalStatusExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavigationAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavigationAreaRestrictionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavigationAreaSectorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNavigationSystemCheckpointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNDBExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNitrogenExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNonMovementAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractNoteExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractObstacleAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractObstacleAssessmentAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractObstaclePlacementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractObstructionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractOilExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractOnlineContactExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractOrganisationAuthorityAssociationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractOrganisationAuthorityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractOxygenExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPassengerLoadingBridgeExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPassengerServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPilotControlledLightingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPointReferenceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractPointUsageExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPostalAddressExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPrecisionApproachRadarExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPrimarySurveillanceRadarExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractProcedureAvailabilityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractProcedureDMEExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractProcedureExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractProcedureTransitionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractProcedureTransitionLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractPropertiesWithScheduleExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRadarComponentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRadarEquipmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRadarSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRadioCommunicationChannelExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRadioCommunicationOperationalStatusExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRadioFrequencyAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractReferenceLocationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractReflectorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRidgeExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRoadExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRouteAvailabilityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRouteDMEExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRouteExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRoutePortionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRouteSegmentExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractRouteSegmentVerticalLimitExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRulesProceduresExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayBlastPadExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayCentrelinePointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayDeclaredDistanceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayDeclaredDistanceValueExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayDirectionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayDirectionLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayProtectAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayProtectAreaLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwaySectionContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractRunwayVisualRangeExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSafeAltitudeAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSafeAltitudeAreaSectorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSDFExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSeaplaneLandingAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSeaplaneRampSiteExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSearchRescueServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSecondarySurveillanceRadarExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSectorDesignExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSegmentLegExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSegmentPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractServiceOperationalStatusExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSignificantPointInAirspaceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSpecialDateExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSpecialNavigationStationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSpecialNavigationStationStatusExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSpecialNavigationSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractStandardInstrumentArrivalExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractStandardInstrumentDepartureExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractStandardLevelColumnExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractStandardLevelExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractStandardLevelSectorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractStandardLevelTableExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractStandMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractSunriseSunsetRowExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractSunriseSunsetTableExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSurfaceCharacteristicsExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSurfaceContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSurfaceContaminationLayerExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSurveillanceGroundStationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSurveillanceRadarExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractSurveyControlPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractSynonymExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTACANExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiHoldingPositionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiHoldingPositionLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiHoldingPositionMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiwayContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiwayElementExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiwayExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiwayLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTaxiwayMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTelephoneContactExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTerminalArrivalAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTerminalArrivalAreaSectorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTerminalSegmentPointExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTimesheetExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTouchDownLiftOffContaminationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTouchDownLiftOffExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTouchDownLiftOffLightSystemExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTouchDownLiftOffMarkingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTouchDownLiftOffSafeAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractTrafficSeparationServiceExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractTrafficVolumeActivationExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractTrafficVolumeExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractTrafficVolumeLinkedFlowExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AbstractTrafficVolumeSetExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractUnitAvailabilityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractUnitDependencyExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractUnitExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractUnplannedHoldingExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractUsageConditionExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractVerticalStructureExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractVerticalStructureLightingStatusExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractVerticalStructurePartExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractVisualGlideSlopeIndicatorExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractVORExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractWorkareaActivityExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractWorkAreaExtension))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AircraftCharacteristicExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirportHeliportExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirspaceActivationExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirspaceExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.DesignatedPointExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlightCharacteristicExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlightConditionElementExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlightRestrictionExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.NavaidExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.ProcedureExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RouteAvailabilityExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RouteExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RoutePortionExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.RouteSegmentExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.StandardInstrumentArrivalExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.StandardInstrumentDepartureExtensionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.TimesheetExtensionType))]
    public abstract partial class AbstractExtensionType : AbstractAIXMObjectType
    {
    }
}
