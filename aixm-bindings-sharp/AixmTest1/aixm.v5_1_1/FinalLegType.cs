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
    [System.Xml.Serialization.XmlTypeAttribute("FinalLegType", Namespace="http://www.aixm.aero/schema/5.1.1")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("FinalLeg", Namespace="http://www.aixm.aero/schema/5.1.1")]
    public partial class FinalLegType : AbstractApproachLegType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<FinalLegTimeSlicePropertyType> _timeSlice;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("timeSlice")]
        public System.Collections.ObjectModel.Collection<FinalLegTimeSlicePropertyType> TimeSlice
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="FinalLegType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="FinalLegType" /> class.</para>
        /// </summary>
        public FinalLegType()
        {
            this._timeSlice = new System.Collections.ObjectModel.Collection<FinalLegTimeSlicePropertyType>();
        }
    }
}
