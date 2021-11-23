using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class PatientService : IService<Patient>
    {
        private PatientRepository _patientRepository;

        public PatientService(SqlConnection connection)
        {
            _patientRepository = new PatientRepository(connection);
        }

        public bool Add(Patient patient)
        {
            return _patientRepository.Add(patient);
        }

        public bool Edit(Patient patient)
        {
            return _patientRepository.Edit(patient);
        }

        public bool SavePhoto(int id, string destination)
        {
            return _patientRepository.SavePhoto(id, destination);
        }

        public bool Delete(int patientId)
        {
            return _patientRepository.Delete(patientId);
        }

        public Patient GetById(int patientId)
        {
            return _patientRepository.GetById(patientId);
        }

        public int GetLastId()
        {
            return _patientRepository.GetLastId();
        }

        public DataTable GetByIdentf(string patientIdentification)
        {
            return _patientRepository.GetByIdentf(patientIdentification);
        }

        public DataTable GetAllPending()
        {
            return _patientRepository.GetAllPending();
        }
    }
}
