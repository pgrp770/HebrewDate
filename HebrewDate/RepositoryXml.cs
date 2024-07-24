using System.Xml.Linq;

namespace HebrewDate
{
    public class RepositoryXml
    {
        private const string Path = ".\\queries.xml";
        private XDocument _doc;

        public RepositoryXml()
        {
            EnsureFile();
            _doc = XDocument.Load(Path);
        }

        private void EnsureFile()
        {
            if (!File.Exists(Path))
            {
                var root = new XDocument(new XElement("Todos"));
                root.Save(Path);
            }


        }

        public void AddNewQuery(Query query)
        {
            XElement root = _doc.Root;


            XElement day = new XElement("Day",query.Day);
            XElement dayMonth = new XElement("DayMonth",query.DayMonth);
            XElement month = new XElement("Month",query.Month);
            XElement year = new XElement("Year",query.Year);
            XElement result = new XElement("Result",query.Result);


            XElement queryNode = new XElement("Query", day, dayMonth, month, year, result);
            root.Add(queryNode);

            root.Save(Path);

        }
    }
}
