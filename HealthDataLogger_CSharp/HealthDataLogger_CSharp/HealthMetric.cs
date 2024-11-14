using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Represents an individual health metric for a patient.
//Each HealthMetric object has two properties: MetricName
//(the name of the metric, such as "Blood Pressure") and
//Value (the recorded value for that metric).
//This class is intended to be used within PatientRecordList
//as part of a patient’s health data.
namespace HealthDataLogger_CSharp
{
    // Represents an individual health metric (e.g., Blood Pressure) with a name and value.
    public class HealthMetric
    {
        public string MetricName { get; set; }
        public string Value { get; set; }

        // Constructor initializes the metric with a name and value.
        public HealthMetric(string metricName, string value)
        {
            MetricName = metricName;
            Value = value;
        }
    }
}
