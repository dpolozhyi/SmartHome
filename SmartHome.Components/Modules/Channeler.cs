using System.Collections.Generic;
using System.Linq;
using SmartHome.Components.Interfaces;
using System;

namespace SmartHome.Components.Modules
{
    public class Channeler : IChannable, IEntity
    {
        public Guid Id { get; set; }

        private int CurrentChannel { get; set; }

        protected IEnumerable<string> Channels { get; set; }

        public Channeler()
        {
            
        }

        public Channeler(IEnumerable<string> channels, string currentChannel)
        {
            this.Channels = channels;
            if(this.Channels.Contains(currentChannel))
            {
                this.CurrentChannel = this.Channels.ToList().IndexOf(currentChannel);
            }
        }

        public void NextChannel()
        {
            if(this.CurrentChannel < this.Channels.Count()-1)
            {
                this.CurrentChannel++;
            }
        }

        public void PreviousChannel()
        {
            if (this.CurrentChannel > 0)
            {
                this.CurrentChannel--;
            }
        }

        public bool SetChannel(string channel)
        {
            if(this.Channels.Contains(channel))
            {
                this.CurrentChannel = this.Channels.ToList().IndexOf(channel);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetCurrentChannel()
        {
            return this.Channels.ToList()[CurrentChannel];
        }

        public IEnumerable<string> GetChannelsList()
        {
            return this.Channels;
        }

        public void SetChannelsList(IEnumerable<string> channelsList)
        {
            this.Channels = channelsList;
        }
    }
}
