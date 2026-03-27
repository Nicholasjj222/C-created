using System;

namespace Model
{
    public class Session
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int DurationMinutes { get; set; }
        public DateTime Timestamp { get; set; }

        public Session(int userId, int durationMinutes)
        {
            Id = 0;
            UserId = userId;
            DurationMinutes = durationMinutes;
            Timestamp = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Session(Id={Id}, UserId={UserId}, Duration={DurationMinutes}, Timestamp={Timestamp})";
        }
    }
}