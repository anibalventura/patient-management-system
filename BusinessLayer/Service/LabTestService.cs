using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class LabTestService : IService<LabTest>
    {
        private LabTestRepository _labTestRepository;

        public LabTestService(SqlConnection connection)
        {
            _labTestRepository = new LabTestRepository(connection);
        }

        public bool Add(LabTest labTest)
        {
            return _labTestRepository.Add(labTest);
        }

        public bool Edit(LabTest labTest)
        {
            return _labTestRepository.Edit(labTest);
        }

        public bool Delete(int labTestId)
        {
            return _labTestRepository.Delete(labTestId);
        }

        public LabTest GetById(int labTestId)
        {
            return _labTestRepository.GetById(labTestId);
        }

        public DataTable GetAllPending()
        {
            return _labTestRepository.GetAllPending();
        }
    }
}
