﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class MailRequest
    {
        public List<string>? Email { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
