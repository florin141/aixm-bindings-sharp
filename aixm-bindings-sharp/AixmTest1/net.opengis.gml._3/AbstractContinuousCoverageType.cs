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
    /// <para>A continuous coverage as defined in ISO 19123 is a coverage that can return different values for the same feature attribute at different direct positions within a single spatiotemporal object in its spatiotemporal domain. The base type for continuous coverages is AbstractContinuousCoverageType.
    ///The coverageFunction element describes the mapping function. 
    ///The abstract element gml:AbstractContinuousCoverage serves as the head of a substitution group which may contain any continuous coverage whose type is derived from gml:AbstractContinuousCoverageType.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbstractContinuousCoverageType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractContinuousCoverage", Namespace="http://www.opengis.net/gml/3.2")]
    public abstract partial class AbstractContinuousCoverageType : AbstractCoverageType
    {
        
        [System.Xml.Serialization.XmlElementAttribute("coverageFunction")]
        public CoverageFunctionType CoverageFunction { get; set; }
    }
}
