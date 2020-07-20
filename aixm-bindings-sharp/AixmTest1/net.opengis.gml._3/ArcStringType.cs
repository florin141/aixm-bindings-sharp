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
    /// <para>An ArcString is a curve segment that uses three-point circular arc interpolation ("circularArc3Points"). The number of arcs in the arc string may be explicitly stated in the attribute numArc. The number of control points in the arc string shall be 2 * numArc + 1.
    ///The content model follows the general pattern for the encoding of curve segments.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ArcStringType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("ArcString", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ArcType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CircleType))]
    public partial class ArcStringType : AbstractCurveSegmentType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<net.opengis.gml._3.DirectPositionType> _pos;
        
        [System.Xml.Serialization.XmlElementAttribute("pos")]
        public System.Collections.ObjectModel.Collection<net.opengis.gml._3.DirectPositionType> Pos
        {
            get
            {
                return this._pos;
            }
            private set
            {
                this._pos = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Pos-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Pos collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PosSpecified
        {
            get
            {
                return (this.Pos.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ArcStringType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ArcStringType" /> class.</para>
        /// </summary>
        public ArcStringType()
        {
            this._pos = new System.Collections.ObjectModel.Collection<net.opengis.gml._3.DirectPositionType>();
            this._pointProperty = new System.Collections.ObjectModel.Collection<net.opengis.gml._3.PointPropertyType>();
            this._pointRep = new System.Collections.ObjectModel.Collection<net.opengis.gml._3.PointPropertyType>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<net.opengis.gml._3.PointPropertyType> _pointProperty;
        
        [System.Xml.Serialization.XmlElementAttribute("pointProperty")]
        public System.Collections.ObjectModel.Collection<net.opengis.gml._3.PointPropertyType> PointProperty
        {
            get
            {
                return this._pointProperty;
            }
            private set
            {
                this._pointProperty = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PointProperty-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PointProperty collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PointPropertySpecified
        {
            get
            {
                return (this.PointProperty.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<net.opengis.gml._3.PointPropertyType> _pointRep;
        
        [System.Xml.Serialization.XmlElementAttribute("pointRep")]
        public System.Collections.ObjectModel.Collection<net.opengis.gml._3.PointPropertyType> PointRep
        {
            get
            {
                return this._pointRep;
            }
            private set
            {
                this._pointRep = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PointRep-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PointRep collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PointRepSpecified
        {
            get
            {
                return (this.PointRep.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("posList")]
        public net.opengis.gml._3.DirectPositionListType PosList { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("coordinates")]
        public net.opengis.gml._3.CoordinatesType Coordinates { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private CurveInterpolationType _interpolation = net.opengis.gml._3.CurveInterpolationType.CircularArc3Points;
        
        [System.ComponentModel.DefaultValueAttribute(net.opengis.gml._3.CurveInterpolationType.CircularArc3Points)]
        [System.Xml.Serialization.XmlAttributeAttribute("interpolation")]
        public CurveInterpolationType Interpolation
        {
            get
            {
                return this._interpolation;
            }
            set
            {
                this._interpolation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("numArc")]
        public string NumArc { get; set; }
    }
}
