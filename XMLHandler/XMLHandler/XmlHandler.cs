using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace XMLHandler
{
    public class XmlHandler
    {
        private string _validationMessage;
        public string ValidationMessage { get { return _validationMessage; } }

        private Boolean _isValid;
        private string _xmlFilePath;
        private string _xsdFilePath;


        public XmlHandler(string xmlFilePath, string xsdFilePath)
        {
            this._xmlFilePath = xmlFilePath;
            this._xsdFilePath = xsdFilePath;
        }

        public bool ValidateXml()
        {
            this._isValid = true;
            this._validationMessage = "";

            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(_xmlFilePath);
                ValidationEventHandler eventHandler = new ValidationEventHandler(ValidationHandler);
                doc.Schemas.Add(null, _xsdFilePath);
                doc.Validate(eventHandler);
            }
            catch (Exception ex)
            {
                _isValid = false;
                _validationMessage = string.Format("EXCEPTION: {0}", ex.Message);
            }


            return _isValid;
        }

        private void ValidationHandler(object sender, ValidationEventArgs args)
        {
            _isValid = false;
            switch (args.Severity)
            {
                case XmlSeverityType.Error:
                    _validationMessage = string.Format("ERROR: {0}", args.Message);
                    break;
                case XmlSeverityType.Warning:
                    _validationMessage = string.Format("WARNING: {0}", args.Message);
                    break;
            }
        }

        public List<String> GetTitles()
        {
            var titles = new List<String>();
            var doc = new XmlDocument();

            doc.Load(_xmlFilePath);
            var elements = doc.SelectNodes("/bookstore/book/title");
            foreach (XmlNode item in elements)
            {
                titles.Add(item.InnerText);
            }

            return titles;
        }

        public void SetTitle(String title)
        {
            var titles = new List<String>();
            var doc = new XmlDocument();

            doc.Load(_xmlFilePath);
            var elements = doc.SelectNodes("/bookstore/book/title[" + title + "]");
            foreach (XmlNode item in elements)
            {
                item.InnerText = title;
            }
            doc.Save(_xmlFilePath);
        }

    }
}
