using System.Collections.Generic;
//PatientRecordList class represents a patient’s information and contains
//their basic personal details like Name, Age, Gender, Height, etc.
//It also contains a list of HealthMetric objects (HealthMetrics),
//which stores individual health metrics like blood glucose levels, heart rate, etc.
namespace HealthDataLogger_CSharp
{
    // Represents a patient's record, including basic info and 
    //a list of health metrics.
    public class PatientRecordList
    {
        // Unique identifier for the patient.
        public string PatientId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string pGender { get; set; }
        public string BloodType { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        // List of health metrics associated with this patient.
        public List<HealthMetric> HealthMetrics { get; set; }

        // Constructor to initialize the patient record with personal details.
        public PatientRecordList(string patientId, string name, string age, string gender, string bloodType, string height, string weight)
        {
            PatientId = patientId;
            Name = name;
            Age = age;
            pGender = gender;
            BloodType = bloodType;
            Height = height;
            Weight = weight;
            HealthMetrics = new List<HealthMetric>();
        }

        // Retrieves a specific health metric by name.
        public HealthMetric GetMetric(string metricName)
        {
            return HealthMetrics.Find(m => m.MetricName == metricName);
        }

        // Updates the value of an existing metric 
        //or adds a new metric if it doesn't exist.
        public void UpdateMetric(string metricName, string newValue)
        {
            //The GetMetric method retrieves a specific health metric by name,
            //while UpdateMetric updates or adds a new health metric.
            HealthMetric metric = GetMetric(metricName);
            if (metric != null)
            {
                metric.Value = newValue;
            }
            else
            {
                HealthMetrics.Add(new HealthMetric(metricName, newValue));
            }
        }
    }
}

