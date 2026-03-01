using MailServices.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailServices.InterfaceRepository
{
    public interface IMailService
    {
        Task<int> SendEmailAsync(MailRequest mailRequest);
    }
}
