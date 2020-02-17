using System;
using System.Collections.Generic;

namespace MasterMind.Data.DomainClasses
{
    public interface IPlayer
    {
        Guid Id { get; set; }
        string NickName { get; set; }
        bool IsHuman { get; }
        Dictionary<Guid, GuessResult> PlayerHistory
        {
            get; set;
        }
    }
}