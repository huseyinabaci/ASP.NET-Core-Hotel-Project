using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.EntityFramework;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _BookingDal;
        public BookingManager(IBookingDal BookingDal)
        {
            _BookingDal = BookingDal;
        }
        public void TDelete(Booking t)
        {
            _BookingDal.Delete(t);
        }

        public Booking TGetByID(int id)
        {
            return _BookingDal.GetByID(id);
        }

        public List<Booking> TGetList()
        {
            return _BookingDal.GetList();
        }

        public void TInsert(Booking t)
        {
            _BookingDal.Insert(t);
        }
        public void TUpdate(Booking t)
        {
            _BookingDal.Update(t);
        }
        public void TBookingStatusChangeApproved(Booking booking)
        {
            _BookingDal.BookingStatusChangeApproved(booking);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            _BookingDal.BookingStatusChangeApproved2(id);
        }

        public void TBookingStatusChangeApproved3(int id)
        {
            _BookingDal.BookingStatusChangeApproved3(id);
        }
    }
}
