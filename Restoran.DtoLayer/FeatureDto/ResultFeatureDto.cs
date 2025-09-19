﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran.DtoLayer.FeatureDto
{
    public class ResultFeatureDto
    {
        public int FeatureID { get; set; }
        public string Title1 { get; set; } = null!;
        public string Description1 { get; set; } = null!;
        public string Title2 { get; set; } = null!;
        public string Description2 { get; set; } = null!;
        public string Title3 { get; set; } = null!;
        public string Description3 { get; set; } = null!;
    }
}
