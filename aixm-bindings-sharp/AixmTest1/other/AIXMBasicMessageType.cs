//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace other
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AIXMBasicMessageType", Namespace="http://www.aixm.aero/schema/5.1.1/message")]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("AIXMBasicMessage", Namespace="http://www.aixm.aero/schema/5.1.1/message")]
    public partial class AIXMBasicMessageType : aixm.v5_1_1.AbstractAIXMMessageType
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<BasicMessageMemberAIXMPropertyType> _hasMember;
        
        [System.ComponentModel.DataAnnotations.RequiredAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("hasMember")]
        public System.Collections.ObjectModel.Collection<BasicMessageMemberAIXMPropertyType> HasMember
        {
            get
            {
                return this._hasMember;
            }
            private set
            {
                this._hasMember = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="AIXMBasicMessageType" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="AIXMBasicMessageType" /> class.</para>
        /// </summary>
        public AIXMBasicMessageType()
        {
            this._hasMember = new System.Collections.ObjectModel.Collection<BasicMessageMemberAIXMPropertyType>();
        }
    }
}
