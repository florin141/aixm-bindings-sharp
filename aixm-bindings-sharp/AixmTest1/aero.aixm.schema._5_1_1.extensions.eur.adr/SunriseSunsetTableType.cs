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
    [System.Xml.Serialization.XmlTypeAttribute("SunriseSunsetTableType", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("SunriseSunsetTable", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    public partial class SunriseSunsetTableType : aixm.v5_1_1.AbstractAIXMFeatureType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<SunriseSunsetTableTimeSlicePropertyType> _timeSlice;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("timeSlice")]
        public System.Collections.ObjectModel.Collection<SunriseSunsetTableTimeSlicePropertyType> TimeSlice
        {
            get
            {
                return this._timeSlice;
            }
            private set
            {
                this._timeSlice = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="SunriseSunsetTableType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="SunriseSunsetTableType" /> class.</para>
        /// </summary>
        public SunriseSunsetTableType()
        {
            this._timeSlice = new System.Collections.ObjectModel.Collection<SunriseSunsetTableTimeSlicePropertyType>();
        }
    }
}
