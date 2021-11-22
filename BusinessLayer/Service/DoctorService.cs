using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class DoctorService: IService<Doctor>
    {
        private DoctorRepository _doctorRepository;

        public DoctorService(SqlConnection connection)
        {
            _doctorRepository = new DoctorRepository(connection);
        }

        public bool Add(Doctor doctor)
        {
            return _doctorRepository.Add(doctor);
        }

        public bool Edit(Doctor doctor)
        {
            return _doctorRepository.Edit(doctor);
        }

        public bool SavePhoto(int id, string destination)
        {
            return _doctorRepository.SavePhoto(id, destination);
        }

        public bool Delete(int doctorId)
        {
            return _doctorRepository.Delete(doctorId);
        }

        public Doctor GetById(int doctorId)
        {
            return _doctorRepository.GetById(doctorId);
        }

        public int GetLastId()
        {
            return _doctorRepository.GetLastId();
        }

        public DataTable GetByIdentf(string doctorIdentification)
        {
            return _doctorRepository.GetByIdentf(doctorIdentification);
        }

        public DataTable GetAll()
        {
            return _doctorRepository.GetAll();
        }
    }
}
