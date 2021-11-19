using System;
using Tratamento_excessoes.Entities.Exceptions;

namespace Tratamento_excessoes.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            if (checkout <= checkin)
            {
                throw new DomainException("Check-Out date must be after Check-In");
            }
            RoomNumber = roomNumber;
            CheckIn = checkin;
            CheckOut = checkout;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
               throw new DomainException( "Dates for update must be future dates");
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Check-Out date must be after Check-In");
            }
            CheckIn = checkin;
            CheckOut = checkout;
        }
        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", Check-In: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", Check-Out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", Duration: "
                + Duration()
                + " nights";
        }
    }
}
