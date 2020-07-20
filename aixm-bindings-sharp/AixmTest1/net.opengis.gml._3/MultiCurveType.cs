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
    /// <para>A gml:MultiCurve is defined by one or more gml:AbstractCurves.
    ///The members of the geometric aggregate may be specified either using the "standard" property (gml:curveMember) or the array property (gml:curveMembers). It is also valid to use both the "standard" and the array properties in the same collection.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("MultiCurveType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("MultiCurve", Namespace="http://www.opengis.net/gml/3.2")]
    public partial class MultiCurveType : AbstractGeometricAggregateType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<net.opengis.gml._3.CurvePropertyType> _curveMember;
        
        [System.Xml.Serialization.XmlElementAttribute("curveMember")]
        public System.Collections.ObjectModel.Collection<net.opengis.gml._3.CurvePropertyType> CurveMember
        {
            get
            {
                return this._curveMember;
            }
            private set
            {
                this._curveMember = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CurveMember-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CurveMember collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurveMemberSpecified
        {
            get
            {
                return (this.CurveMember.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="MultiCurveType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="MultiCurveType" /> class.</para>
        /// </summary>
        public MultiCurveType()
        {
            this._curveMember = new System.Collections.ObjectModel.Collection<net.opengis.gml._3.CurvePropertyType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("curveMembers")]
        public net.opengis.gml._3.CurveArrayPropertyType CurveMembers { get; set; }
    }
}
