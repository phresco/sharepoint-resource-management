/**
 * PHR_SharePointResourceManagement
 *
 * Copyright (C) 1999-2014 Photon Infotech Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *         http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phresco.XMLtoList
{
    // 
    // This source code was auto-generated by xsd, Version=2.0.50727.3038.
    // 
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Lists
    {

        private List[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("List", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public List[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class List
    {

        private Field[] fieldsField;

        private string nameField;

        private string descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fields", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Field[] Fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Field
    {

        private Choice[] choicesField;

        private string nameField;

        private string datatypeField;

        private string defaultvalueField;

        private string displaychoicesusingField;

        private string requiredField;

        private string lookuplistField;

        private string lookupfieldField;

        private string textformatField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Choice", typeof(Choice), Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public Choice[] Choices
        {
            get
            {
                return this.choicesField;
            }
            set
            {
                this.choicesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string datatype
        {
            get
            {
                return this.datatypeField;
            }
            set
            {
                this.datatypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string defaultvalue
        {
            get
            {
                return this.defaultvalueField;
            }
            set
            {
                this.defaultvalueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string displaychoicesusing
        {
            get
            {
                return this.displaychoicesusingField;
            }
            set
            {
                this.displaychoicesusingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string required
        {
            get
            {
                return this.requiredField;
            }
            set
            {
                this.requiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lookuplist
        {
            get
            {
                return this.lookuplistField;
            }
            set
            {
                this.lookuplistField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lookupfield
        {
            get
            {
                return this.lookupfieldField;
            }
            set
            {
                this.lookupfieldField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string textformat
        {
            get
            {
                return this.textformatField;
            }
            set
            {
                this.textformatField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Choice
    {

        private string selectedField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string selected
        {
            get
            {
                return this.selectedField;
            }
            set
            {
                this.selectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}
