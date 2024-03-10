using System;
using System.Collections.Generic;

namespace MerlinAPI.Models;

public partial class ContactForm
{
    public ulong ContactId { get; set; }
    public long PortalId { get; set; }
    public string? Name { get; set; }
    public string? TargetMail { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Mobile { get; set; }
    public string? SmtpPassword { get; set; }
    public string? Fax { get; set; }
    public string? SmtpServer { get; set; }
    public long? Port { get; set; }
    public string? UserName { get; set; }
    public DateTime Created { get; set; }
    public long CreatedBy { get; set; }
    public DateTime? Modified { get; set; }
    public long? ModifiedBy { get; set; }
    public sbyte Active { get; set; }
}
