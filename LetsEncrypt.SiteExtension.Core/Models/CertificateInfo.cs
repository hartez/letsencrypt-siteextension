﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LetsEncrypt.Azure.Core.Models
{
    public class CertificateInfo
    {
        [JsonIgnore]
        public X509Certificate2 Certificate { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public byte[] PfxCertificate { get; set; }
    }
}
