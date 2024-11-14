using System;
using System.Collections.Generic;
//HealthDataManager class manages a collection
//of PatientRecordList instances. It provides methods for adding new
//patient records (AddPatientRecord), retrieving patient records
//by ID (GetPatientRecord), and updating existing patient records (UpdatePatientRecord).
namespace HealthDataLogger_CSharp.Models
{
    // Manages a list of patient records and provides methods
    // to access and update them.
    public class HealthDataManager
    {
        
        // List of all patient records.
        private List<PatientRecordList> patientRecords;  // 将 PatientRecord 改为 PatientRecordList

        // Constructor initializes the list and loads sample data.
        public HealthDataManager()
        {
            patientRecords = new List<PatientRecordList>();
            LoadSampleData();
        }

        // Adds a new patient record to the list.
        public void AddPatientRecord(PatientRecordList record)  // 改为 PatientRecordList
        {
            patientRecords.Add(record);
        }

        // Updates an existing patient record or adds a new one if it doesn't exist.
        public void UpdatePatientRecord(PatientRecordList updatedRecord)
        {
            var existingRecord = GetPatientRecord(updatedRecord.PatientId);
            if (existingRecord != null)
            {
                // Update properties of the existing record.
                existingRecord.Name = updatedRecord.Name;
                existingRecord.Age = updatedRecord.Age;
                existingRecord.pGender = updatedRecord.pGender;
                existingRecord.BloodType = updatedRecord.BloodType;
                existingRecord.Height = updatedRecord.Height;
                existingRecord.Weight = updatedRecord.Weight;
                existingRecord.HealthMetrics = updatedRecord.HealthMetrics;
            }
            else
            {
                // Add a new record if it doesn't exist.
                patientRecords.Add(updatedRecord); 
            }
        }


        // Retrieves a patient record by patient ID.
        public PatientRecordList GetPatientRecord(string patientId)  // 改为 PatientRecordList
        {
            return patientRecords.Find(p => p.PatientId == patientId);
        }

        //The LoadSampleData method is used to pre-load sample data for
        //testing purposes, which can help in simulating patient records.
        private void LoadSampleData()
        {
            var patient = new PatientRecordList("12345", "Yipeng", "80", "Male", "O+", "190 cm", "80 kg");
            patient.UpdateMetric("Blood Glucose", "130 mg/dL");
            patient.UpdateMetric("Leucocyte Count", "4.5 K/uL");
            patient.UpdateMetric("Erythrocyte Count", "6.0 M/uL");
            patient.UpdateMetric("Blood Oxygen", "95%");
            patient.UpdateMetric("Blood Pressure", "130/70 mmHg");
            patient.UpdateMetric("Body Temperature", "88.6°F");

            patientRecords.Add(patient);
        }
    }
}



