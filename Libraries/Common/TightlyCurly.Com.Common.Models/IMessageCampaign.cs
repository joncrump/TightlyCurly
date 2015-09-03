using System;
using System.Collections.Generic;

namespace TightlyCurly.Com.Common.Models
{
    public interface IMessageCampaign : IModel
    {
        string CampaignName { get; set; }
        string Description { get; set; }
        IEnumerable<IMessageTemplate> MessageTemplates { get; set; }
        IEnumerable<ISubscription> Subscriptions { get; set; }
    }
}
