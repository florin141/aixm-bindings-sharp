using System.Collections.Generic;
using System.IO;
using System.Linq;
using _int.eurocontrol.cfmu.b2b.adrmessage;
using aero.aixm.v5_1_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using org.w3._1999.xlink;

namespace aixm_bindings_tests
{
    [TestClass]
    public class AixmTests
    {
        [TestMethod]
        public void CanDeserializeAirportHeliportType1()
        {
            var fileContent = ReadFileContents("airport1.xml");

            var serializer = new AixmSerializer<AirportHeliportType>();

            var objDeserialized = serializer.Deserialize(fileContent);

            //Assert.IsNotNull(objDeserialized.Id);
            Assert.IsNotNull(objDeserialized.Identifier);
            Assert.IsNotNull(objDeserialized.TimeSlice);
            Assert.AreEqual(1, objDeserialized.TimeSlice.Count);
            Assert.IsNotNull(objDeserialized.TimeSlice[0].AirportHeliportTimeSlice);
        }

        [TestMethod]
        public void CanDeserializeAirportHeliportTimeSliceType()
        {
            var fileContent = ReadFileContents("airportHeliportTimeSlice.xml");

            var serializer = new AixmSerializer<AirportHeliportTimeSliceType>();

            var objDeserialized = serializer.Deserialize(fileContent);

            //Assert.IsNotNull(objDeserialized.Id);
            Assert.IsNotNull(objDeserialized.ValidTime);
            Assert.AreEqual(TypeType.Simple, objDeserialized.ValidTime.Type);
            Assert.IsNotNull(objDeserialized.ValidTime.TimePeriod);
            //Assert.IsNotNull(objDeserialized.ValidTime.TimePeriod.Id);
            Assert.IsNotNull(objDeserialized.ValidTime.TimePeriod.BeginPosition);
            Assert.AreEqual("2011-01-13T12:00:00.000Z", objDeserialized.ValidTime.TimePeriod.BeginPosition.Value);
            Assert.IsNotNull(objDeserialized.ValidTime.TimePeriod.EndPosition);
            Assert.AreEqual("2011-01-14T12:00:00.000Z", objDeserialized.ValidTime.TimePeriod.EndPosition.Value);
            Assert.IsNotNull(objDeserialized.Interpretation);
            Assert.AreEqual(Interpretation.PERMDELTA, objDeserialized.Interpretation);
        }

        private static string XmlPath
        {
            get { return Path.Combine(Directory.GetCurrentDirectory(), "xml"); }
        }

        public static string ReadFileContents(string fileName)
        {
            return File.ReadAllText(Path.Combine(XmlPath, fileName));
        }

        public static void WriteFileContents(string fileName, string content)
        {
            File.WriteAllText(Path.Combine(XmlPath, fileName), content);
        }

    }
}
