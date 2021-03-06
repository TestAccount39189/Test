﻿using Eleks_2018_MicroSocialMedia.WriteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eleks_2018_MicroSocialMedia.Repositories.Interfaces
{
    public interface IMessageGroupProfileRepository
        : IRepository<MessageGroupProfile, Guid>
    {
        MessageGroupProfile Find(Guid conversationId, int id);
        MessageGroupProfile GetMessageGroupProfileByMessageGroupId(Guid conversationId, int id);
        void LoadMessagesFromMessageGroup(MessageGroupProfile messageGroupProfile);
    }
}
