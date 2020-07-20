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
    /// <para>gml:TimeGeometricPrimitive acts as the head of a substitution group for geometric temporal primitives.
    ///A temporal geometry shall be associated with a temporal reference system through the frame attribute that provides a URI reference that identifies a description of the reference system. Following ISO 19108, the Gregorian calendar with UTC is the default reference system, but others may also be used. The GPS calendar is an alternative reference systems in common use.
    ///The two geometric primitives in the temporal dimension are the instant and the period. GML components are defined to support these as follows.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AbstractTimeGeometricPrimitiveType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AbstractTimeGeometricPrimitive", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimeInstantType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TimePeriodType))]
    public abstract partial class AbstractTimeGeometricPrimitiveType : AbstractTimePrimitiveType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _frame = "#ISO-8601";
        
        [System.ComponentModel.DefaultValueAttribute("#ISO-8601")]
        [System.Xml.Serialization.XmlAttributeAttribute("frame")]
        public string Frame
        {
            get
            {
                return this._frame;
            }
            set
            {
                this._frame = value;
            }
        }
    }
}
