﻿namespace WebApi.Dtos
{
    public class CarDto
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
        public int CreatedAt { get; set; }
    }
}
