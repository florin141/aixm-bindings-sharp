//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace net.opengis.gml._3
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>To describe an event — an action that occurs at an instant or over an interval of time — GML provides the gml:AbtractTimeSlice element. A timeslice encapsulates the time-varying properties of a dynamic feature -- it shall be extended to represent a time stamped projection of a specific feature. The gml:dataSource property describes how the temporal data was acquired.
    ///A gml:AbstractTimeSlice instance is a GML object that encapsulates updates of the dynamic—or volatile—properties that reflect some change event; it thus includes only those feature properties that have actually changed due to some process.
    ///gml:AbstractTimeSlice basically provides a facility for attribute-level time stamping, in contrast to the object-level time stamping of dynamic feature instances. 
    ///The time slice can thus be viewed as event or process-oriented, whereas a snapshot is more state or structure-oriented. A timeslice has richer causality, whereas a snapshot merely portrays the status of the whole.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbstractTimeSliceType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractTimeSlice", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAIXMTimeSliceBaseType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AbstractAIXMTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AerialRefuellingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AeronauticalGroundLightTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AircraftGroundServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AircraftStandTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportClearanceServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportHeliportCollocationTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.AirportHeliportSetTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportHeliportTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportHotSpotTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportProtectionAreaMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirportSuppliesServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceBorderCrossingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirspaceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirTrafficControlServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AirTrafficManagementServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AltimeterSourceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AngleIndicationTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.ApproachLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApproachLightingSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApronElementTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApronLightSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApronMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ApronTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ArrestingGearTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ArrivalFeederLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ArrivalLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AuthorityForAirspaceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.AzimuthTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ChangeOverPointTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CheckpointINSTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CheckpointVORTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.CirclingAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DeicingAreaMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DeicingAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DepartureLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DesignatedPointTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DirectionFinderTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DistanceIndicationTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.DMETimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ElevationTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FinalLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FireFightingServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FlightRestrictionTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.FloatingDockSiteTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.FlowTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.GeoBorderTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.GlidepathTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.GroundTrafficControlServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.GuidanceLineLightSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.GuidanceLineMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.GuidanceLineTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.HoldingAssessmentTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.HoldingPatternTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.InformationServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.InitialLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.InstrumentApproachProcedureTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.IntermediateLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.LocalizerTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.MarkerBeaconTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.MarkingBuoyTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.MissedApproachLegTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(net.opengis.gml._3.MovingObjectStatusType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavaidTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavigationAreaRestrictionTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NavigationAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NDBTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.NonMovementAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ObstacleAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.OrganisationAuthorityTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PassengerLoadingBridgeTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PassengerServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PilotControlledLightingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PrecisionApproachRadarTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.PrimarySurveillanceRadarTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.ProcedureDMETimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RadarSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RadioCommunicationChannelTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RadioFrequencyAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.ReferenceLocationTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RoadTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RouteDMETimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RouteSegmentTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RouteTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RulesProceduresTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayBlastPadTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayCentrelinePointTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayDirectionLightSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayDirectionTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayElementTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayProtectAreaLightSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayProtectAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.RunwayVisualRangeTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SafeAltitudeAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SDFTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SeaplaneLandingAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SeaplaneRampSiteTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SearchRescueServiceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SecondarySurveillanceRadarTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SignificantPointInAirspaceTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SpecialDateTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SpecialNavigationStationTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SpecialNavigationSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.StandardInstrumentArrivalTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.StandardInstrumentDepartureTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.StandardLevelColumnTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.StandardLevelSectorTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.StandardLevelTableTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.StandMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.SunriseSunsetTableTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.SurveyControlPointTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TACANTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiHoldingPositionLightSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiHoldingPositionMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiHoldingPositionTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiwayElementTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiwayLightSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiwayMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TaxiwayTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TerminalArrivalAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TouchDownLiftOffLightSystemTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TouchDownLiftOffMarkingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TouchDownLiftOffSafeAreaTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.TouchDownLiftOffTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.TrafficVolumeSetTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aero.aixm.schema._5_1_1.extensions.eur.adr.TrafficVolumeTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.UnitTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.UnplannedHoldingTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.VerticalStructureTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.VisualGlideSlopeIndicatorTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.VORTimeSliceType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(aixm.v5_1_1.WorkAreaTimeSliceType))]
    public abstract partial class AbstractTimeSliceType : net.opengis.gml._3.AbstractGMLType
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("validTime")]
        public net.opengis.gml._3.TimePrimitivePropertyType ValidTime { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("dataSource")]
        public net.opengis.gml._3.StringOrRefType DataSource { get; set; }
    }
}
