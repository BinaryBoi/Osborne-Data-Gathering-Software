using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

public class DataHandler
{
    public List<DataSet> dh_DataSet = new List<DataSet>();

	public class DataSet
	{
		public string id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public float temperature { get; set; }
    }

    public void GatherData(string dh_EndPoint)
    {
        if (dh_EndPoint != null)
        {
            using WebClient client = new WebClient();
            using Stream stream = client.OpenRead(dh_EndPoint);
            using StreamReader reader = new StreamReader(stream);
            string rawData = reader.ReadToEnd();
            dh_DataSet = JsonConvert.DeserializeObject<List<DataSet>>(rawData);
            System.Diagnostics.Debug.WriteLine(dh_DataSet[1].temperature);
        } 
    }

    public string RoundTemperature(float dh_Temprature, int dh_DecimalPlace)
    {
        string place = "0.";
        for (int p = 0; p < dh_DecimalPlace; p++)
        {
            place += "0";
        }
        return dh_Temprature.ToString(place) + "°C";
    }

    public void SaveData(string dh_FileName, List<DataSet> dh_Data, float dh_Seperator, string dh_Url)
    {
        StringBuilder csv = new StringBuilder();
        csv.AppendLine(dh_Url);
        csv.AppendLine("Under " + dh_Seperator + "°C");
        csv.AppendLine(string.Join(",", new string[] { "ID", "Name", "Age", "Temperature" }));
        string filename =dh_FileName + ".csv";

        foreach (DataSet dh in dh_Data)
        {
            if (dh.temperature < dh_Seperator)
            {
                csv.AppendLine(string.Join(",", new string[] { dh.id, dh.name, dh.age.ToString(), RoundTemperature(dh.temperature, 1) }));
            }
        }

        csv.AppendLine("Over " + dh_Seperator + "°C");
        csv.AppendLine(string.Join(",", new string[] { "ID", "Name", "Age", "Temperature" }));

        foreach (DataSet dh in dh_Data)
        {
            if (dh.temperature >= dh_Seperator)
            {
                csv.AppendLine(string.Join(",", new string[] { dh.id, dh.name, dh.age.ToString(), RoundTemperature(dh.temperature, 1) }));
            }
        }

        string debugFolder = Environment.CurrentDirectory;
        string projectDirectory = Directory.GetParent(debugFolder).Parent.Parent.Parent.FullName;
        string fileDirectory = projectDirectory + "\\" + filename;
        File.AppendAllText(fileDirectory, csv.ToString());
        //return System.IO.Path.GetDirectoryName(filename);
    }
}
