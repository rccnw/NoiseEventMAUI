﻿namespace NoiseEventMaui.Models
{

    public class NoiseEvent
    {
        public NoiseEvent()
        {
            Data = string.Empty;
            Type = string.Empty;
            UtcTime = string.Empty;

        }

        public int      Id          { get; set; }
        public string   Data        { get; set; }
        public string   Type        { get; set; }
        public string   UtcTime     { get; set; }
        public double   Longitude   { get; set; }
        public double   Latitude    { get; set; }
    }
}
