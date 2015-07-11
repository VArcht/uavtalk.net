using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace UavObjectGenerator
{
    public class XmlParser
    {
        private readonly string _mSourceFileName;

        public XmlParser(string fileName)
        {
            _mSourceFileName = fileName;
        }

        public void Generate(string targetFileName)
        {
            using (var reader = new XmlTextReader(_mSourceFileName))
            {
                using (var writer = new StreamWriter(targetFileName))
                {
                    Generate(reader, writer);
                }
            }
        }

        public void Generate(XDocument xmlDocument, string targetFileName)
        {
            using (var writer = new StreamWriter(targetFileName))
            {
                Generate(xmlDocument, writer);
            }
        }

        public static void Generate(XmlTextReader reader, TextWriter writer)
        {
            ObjectData data = GetObjectFromXml(reader);

            CSharpGenerator.Write(writer, data);
        }

        public static void Generate(XDocument reader, TextWriter writer)
        {
            ObjectData data = GetObjectFromXml(reader);

            CSharpGenerator.Write(writer, data);
        }

        // __ Impl _______________________________________________________

        private static ObjectData GetObjectFromXml(XDocument xmlDocument)
        {
            ObjectData currentObject = null;
            FieldData currentField = null;

            if (xmlDocument.DescendantNodes().Any())
            {
                currentObject = new ObjectData();
                IEnumerable<XNode> nodes = xmlDocument.DescendantNodes();

                foreach (dynamic node in nodes)
                {
                    if (node is XElement)
                    {
                        string name = node.Name.LocalName;
                        var xnode = node as XElement;
                        switch (name)
                        {
                            case "object":
                                var nameElement =
                                    xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "name");
                                if (nameElement != null)
                                    currentObject.Name = nameElement.Value;
                                var settigsElement =
                                    xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "settings");
                                if (settigsElement != null)
                                    currentObject.IsSettingsInt = GetIntFromBoolString(settigsElement.Value);
                                currentObject.IsSingleInstInt =
                                    GetIntFromBoolString(
                                        xnode.Attributes()
                                            .FirstOrDefault(a => a.Name.LocalName == "singleinstance")
                                            .Value);
                                break;
                            case "description":
                                currentObject.Description = node.Value;
                                break;
                            case "field":
                                currentField = new FieldData();
                                currentField.Name =
                                    xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "name").Value;
                                currentObject.FieldsIndexedByName.Add(currentField.Name, currentField);

                                if (IsClone(node))
                                {
                                    currentField.CloneFrom(
                                        currentObject.FieldsIndexedByName[
                                            xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "cloneof").Value]);
                                }
                                else
                                {
                                    XAttribute typeElement =
                                        xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "type");
                                    if (typeElement != null)
                                    {
                                        string typeString = typeElement.Value;
                                        currentField.TypeString = typeString;
                                        currentField.Type = GetFieldTypeFromString(currentField.TypeString);
                                        XAttribute elementsAttribute =
                                            xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "elements");
                                        if (elementsAttribute !=
                                            null)
                                            currentField.Elements = elementsAttribute.Value;
                                        XAttribute unitsElement =
                                            xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "units");
                                        if (unitsElement != null)
                                            currentField.Units = unitsElement.Value;
                                        XAttribute elementNamesElement =
                                            xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "elementnames");
                                        if (
                                            elementNamesElement !=
                                            null)
                                            currentField.ParseElementNamesFromAttribute(elementNamesElement.Value);
                                        XAttribute optionsElement =
                                            xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "options");
                                        if (optionsElement !=
                                            null)
                                            currentField.ParseOptionsFromAttribute(optionsElement.Value);
                                        XAttribute defaultValueElement =
                                            xnode.Attributes().FirstOrDefault(a => a.Name.LocalName == "defaultvalue");
                                        if (
                                            defaultValueElement !=
                                            null)
                                            currentField.ParseDefaultValuesFromAttribute(defaultValueElement.Value);
                                    }
                                }
                                currentObject.Fields.Add(currentField);
                                break;
                            case "option":
                                currentField.Options.Add(node.Value);
                                break;
                            case "elementname":
                                currentField.ElementNames.Add(node.Value);
                                break;
                        }
                    }
                }
                ExpandDefaultValues(currentObject);
                SortFields(currentObject);

                SummaryGenerator.RegisterObjectId(
                    Hasher.CalculateId(currentObject),
                    string.Format("{0}.{1}", CSharpGenerator.Namespace, currentObject.Name));
            }
            return currentObject;
        }

        private static ObjectData GetObjectFromXml(XmlTextReader reader)
        {
            ObjectData currentObject = null;
            FieldData currentField = null;

            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {
                        case "object":
                            currentObject = new ObjectData();
                            currentObject.Name = reader.GetAttribute("name");
                            currentObject.IsSettingsInt = GetIntFromBoolString(reader.GetAttribute("settings"));
                            currentObject.IsSingleInstInt = GetIntFromBoolString(reader.GetAttribute("singleinstance"));
                            break;
                        case "description":
                            currentObject.Description = reader.ReadString();
                            break;
                        case "field":
                            currentField = new FieldData();
                            currentField.Name = reader.GetAttribute("name");
                            currentObject.FieldsIndexedByName.Add(currentField.Name, currentField);

                            if (IsClone(reader))
                            {
                                currentField.CloneFrom(currentObject.FieldsIndexedByName[reader.GetAttribute("cloneof")]);
                            }
                            else
                            {
                                currentField.TypeString = reader.GetAttribute("type");
                                currentField.Type = GetFieldTypeFromString(currentField.TypeString);
                                currentField.Elements = reader.GetAttribute("elements");
                                currentField.Units = reader.GetAttribute("units");
                                currentField.ParseElementNamesFromAttribute(reader.GetAttribute("elementnames"));
                                currentField.ParseOptionsFromAttribute(reader.GetAttribute("options"));
                                currentField.ParseDefaultValuesFromAttribute(reader.GetAttribute("defaultvalue"));
                            }
                            currentObject.Fields.Add(currentField);
                            break;
                        case "option":
                            currentField.Options.Add(reader.ReadString());
                            break;
                        case "elementname":
                            currentField.ElementNames.Add(reader.ReadString());
                            break;
                    }
                }
            }

            ExpandDefaultValues(currentObject);
            SortFields(currentObject);

            SummaryGenerator.RegisterObjectId(
                Hasher.CalculateId(currentObject),
                string.Format("{0}.{1}", CSharpGenerator.Namespace, currentObject.Name));

            return currentObject;
        }

        private static void ExpandDefaultValues(ObjectData obj)
        {
            foreach (FieldData f in obj.Fields)
            {
                f.ExpandDefaultValue();
            }
        }

        private static bool GetBoolFromString(string boolString)
        {
            if (boolString == "true") return true;

            return false;
        }

        private static int GetIntFromBoolString(string boolString)
        {
            if (boolString == "true") return 1;
            if (boolString == "false") return 0;

            return -1;
        }

        private static FieldDataType GetFieldTypeFromString(string t)
        {
            // Needed for hash calculation;
            switch (t)
            {
                case "float":
                    return FieldDataType.FLOAT32;
                case "int8":
                    return FieldDataType.INT8;
                case "uint8":
                    return FieldDataType.UINT8;
                case "int16":
                    return FieldDataType.INT16;
                case "uint16":
                    return FieldDataType.UINT16;
                case "enum":
                    return FieldDataType.ENUM;
                case "int32":
                    return FieldDataType.INT32;
                case "uint32":
                    return FieldDataType.UINT32;
                default:
                    return FieldDataType.INT32;
            }
        }

        private static void SortFields(ObjectData obj)
        {
            // Sort by field size first, then by the order the fields already have. 

            /*
            "int8" << "int16" << "int32" << "uint8" << "uint16" << "uint32" << "float" << "enum";
            int(1) << int(2)  << int(4)  << int(1)  << int(2)   << int(4)   << int(4)  << int(1);
            */

            var L4 = new List<FieldData>();
            var L2 = new List<FieldData>();
            var L1 = new List<FieldData>();

            foreach (FieldData f in obj.Fields)
            {
                switch (f.Type)
                {
                    case FieldDataType.ENUM:
                    case FieldDataType.INT8:
                    case FieldDataType.UINT8:
                        L1.Add(f);
                        break;
                    case FieldDataType.INT16:
                    case FieldDataType.UINT16:
                        L2.Add(f);
                        break;
                    default:
                        L4.Add(f);
                        break;
                }
            }

            var result = new List<FieldData>();
            result.AddRange(L4);
            result.AddRange(L2);
            result.AddRange(L1);

            obj.Fields = result;
        }

        private static bool IsClone(XmlReader reader)
        {
            string cloneOf = reader.GetAttribute("cloneof");

            return (cloneOf != null && cloneOf != "");
        }

        private static bool IsClone(XElement node)
        {
            XAttribute attribute = node.Attributes().FirstOrDefault(a => a.Name == "cloneof");
            return attribute != null && !string.IsNullOrEmpty(attribute.Value);
        }
    }
}