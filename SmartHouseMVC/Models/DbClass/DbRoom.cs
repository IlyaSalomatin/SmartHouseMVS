﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SmartHouseMVC.Models.DbClass
{
    public class DbRoom
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string FrostedGlassState { get; set; }
        [Range(5, 95, ErrorMessage = "int from 5 to 95!!!")]
        public int? DimmingGlass { get; set; }
        public string FloorHeating { get; set; }
        public string Boiler { get; set; }
        public string OzonationState { get; set; }
        [Range(15, 25, ErrorMessage = "int from 15 to 25!!!")]
        public int? TempConditioning { get; set; }
        public string ConditioningState { get; set; }
        public string HumidificationState { get; set; }
        public string PowerState { get; set; }
        public string LightinState { get; set; }
        public string BlindsState { get; set; }
    }
}