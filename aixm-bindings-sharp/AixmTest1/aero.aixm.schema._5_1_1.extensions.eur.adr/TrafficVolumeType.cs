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
    [System.Xml.Serialization.XmlTypeAttribute("TrafficVolumeType", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("TrafficVolume", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    public partial class TrafficVolumeType : AbstractAIXMFeatureType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TrafficVolumeTimeSlicePropertyType> _timeSlice;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("timeSlice")]
        public System.Collections.ObjectModel.Collection<TrafficVolumeTimeSlicePropertyType> TimeSlice
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TrafficVolumeType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TrafficVolumeType" /> class.</para>
        /// </summary>
        public TrafficVolumeType()
        {
            this._timeSlice = new System.Collections.ObjectModel.Collection<TrafficVolumeTimeSlicePropertyType>();
        }
    }
}
