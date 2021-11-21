using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class LabResultService : IService<LabResult>
    {
        private LabResultRepository _labResultRepository;

        public LabResultService(SqlConnection connection)
        {
            _labResultRepository = new LabResultRepository(connection);
        }

        public bool Add(LabResult labResult)
        {
            return _labResultRepository.Add(labResult);
        }

        public bool Edit(LabResult labResult)
        {
            throw new System.NotImplementedException();
        }

        public bool ReportResult(LabResult labResult)
        {
            return _labResultRepository.ReportResult(labResult);
        }

        public bool Delete(int labResultId)
        {
            throw new System.NotImplementedException();
        }

        public LabResult GetById(int labResultId)
        {
            throw new System.NotImplementedException();
        }

        public DataTable GetByPatient(string patientIdentification)
        {
            return _labResultRepository.GetByPatient(patientIdentification);
        }

        public DataTable GetAll()
        {
            return _labResultRepository.GetAll();
        }
    }
}
