/*
 * Author: Leong Hean Luen
 * Email: SUKD2301060@segi4u.my
 * Student ID: SUKD2301060
 * Subject: TCS3294 Windows Programming
 */
using System;

namespace cms.Models
{
    public class Timeslot
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string StartTime { get => Start.ToString("HH:mm"); }
        public string EndTime { get => End.ToString("HH:mm"); }
        public int StartTimeSecond { get => (int)Start.TimeOfDay.TotalSeconds; }
        public int EndTimeSecond { get => (int)End.TimeOfDay.TotalSeconds; }
        public Timeslot(double startHour, double startMinute, double duration) {
            if (startHour < 0 || startHour > 23 || startMinute < 0 || startMinute > 59) {
                throw new ArgumentOutOfRangeException("Invalid time.");
            }
            DateTime today = DateTime.Today;
            Start = today.AddHours(startHour).AddMinutes(startMinute);
            End = Start.AddSeconds(duration);
        }
        public override string ToString()
        {
            return $"{StartTime} - {EndTime}";
        }
    }

}
