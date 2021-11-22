using BusinessLayer.Interface;
using Database.Model;
using Database.Repository;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Service
{
    public class AppointmentService : IService<Appointment>
    {
        private AppointmentRepository _appointmentRepository;

        public AppointmentService(SqlConnection connection)
        {
            _appointmentRepository = new AppointmentRepository(connection);
        }

        public bool Add(Appointment appointment)
        {
            return _appointmentRepository.Add(appointment);
        }

        public bool Edit(Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int appointmentId)
        {
            return _appointmentRepository.Delete(appointmentId);
        }

        public Appointment GetById(int appointmentId)
        {
            return _appointmentRepository.GetById(appointmentId);
        }

        public DataTable GetAll()
        {
            return _appointmentRepository.GetAll();
        }
    }
}
