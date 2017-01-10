using System.Collections.Generic;

namespace SmartHome.Components.Interfaces
{
    public interface IChannable
    {
        void NextChannel();

        void PreviousChannel();

        bool SetChannel(string channel);

        string GetCurrentChannel();

        IEnumerable<string> GetChannelsList();

        void SetChannelsList(IEnumerable<string> channelsList);
    }
}
