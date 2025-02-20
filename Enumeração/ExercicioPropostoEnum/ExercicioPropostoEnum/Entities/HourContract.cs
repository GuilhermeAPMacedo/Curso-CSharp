﻿using System;

namespace ExercicioPropostoEnum.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }
        public HourContract(DateTime date, Double valuePerHour,int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return ValuePerHour*Hours;
        } 
    }
}
