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
    [System.Xml.Serialization.XmlTypeAttribute("DesignatedPointExtensionType", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("DesignatedPointExtension", Namespace="http://www.aixm.aero/schema/5.1.1/extensions/EUR/ADR")]
    public partial class DesignatedPointExtensionType : AbstractExtensionType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<PointUsagePropertyType> _pointUsage;
        
        [System.Xml.Serialization.XmlElementAttribute("pointUsage", IsNullable=true)]
        public System.Collections.ObjectModel.Collection<PointUsagePropertyType> PointUsage
        {
            get
            {
                return this._pointUsage;
            }
            private set
            {
                this._pointUsage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PointUsage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PointUsage collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PointUsageSpecified
        {
            get
            {
                return (this.PointUsage.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="DesignatedPointExtensionType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="DesignatedPointExtensionType" /> class.</para>
        /// </summary>
        public DesignatedPointExtensionType()
        {
            this._pointUsage = new System.Collections.ObjectModel.Collection<PointUsagePropertyType>();
        }
    }
}
