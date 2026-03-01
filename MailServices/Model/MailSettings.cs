using System;
using System.Collections.Generic;
using System.Text;

namespace MailServices.Model
{
    // This class is used to store the mail settings for the application.
    // It is used to configure the mail service and is injected into the mail service using dependency injection.
    public class MailSettings
    {
        public string Mail { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Host { get; set; } = string.Empty;
        public int Port { get; set; }
    }
}
