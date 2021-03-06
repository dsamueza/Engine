﻿using System.Threading.Tasks;

namespace Mardis.Engine.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
