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
    /// <para>The gml:Grid implicitly defines an unrectified grid, which is a network composed of two or more sets of curves in which the members of each set intersect the members of the other sets in an algorithmic way.  The region of interest within the grid is given in terms of its gml:limits, being the grid coordinates of  diagonally opposed corners of a rectangular region.  gml:axisLabels is provided with a list of labels of the axes of the grid (gml:axisName has been deprecated). gml:dimension specifies the dimension of the grid.  
    ///The gml:limits element contains a single gml:GridEnvelope. The gml:low and gml:high property elements of the envelope are each integerLists, which are coordinate tuples, the coordinates being measured as offsets from the origin of the grid along each axis, of the diagonally opposing corners of a "rectangular" region of interest.</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GridType", Namespace="http://www.opengis.net/gml/3.2")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("Grid", Namespace="http://www.opengis.net/gml/3.2")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RectifiedGridType))]
    public partial class GridType : net.opengis.gml._3.AbstractGeometryType
    {
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("limits")]
        public GridLimitsType Limits { get; set; }
        
        /// <summary>
        /// <para>A type for a list of values of the respective simple type.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("axisLabels")]
        public string AxisLabels { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<string> _axisName;
        
        [System.Xml.Serialization.XmlElementAttribute("axisName")]
        public System.Collections.ObjectModel.Collection<string> AxisName
        {
            get
            {
                return this._axisName;
            }
            private set
            {
                this._axisName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AxisName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AxisName collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AxisNameSpecified
        {
            get
            {
                return (this.AxisName.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="GridType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="GridType" /> class.</para>
        /// </summary>
        public GridType()
        {
            this._axisName = new System.Collections.ObjectModel.Collection<string>();
        }
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("dimension")]
        public string Dimension { get; set; }
    }
}
