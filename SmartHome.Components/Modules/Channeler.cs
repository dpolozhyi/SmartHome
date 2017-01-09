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

        protected ICollection<string> Channels { get; set; }

        public Channeler()
        {
            
        }

        public Channeler(ICollection<string> channels)
        {
            this.Channels = channels;
        }

        public void NextChannel()
        {
            if(this.CurrentChannel < this.Channels.Count-1)
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
    }
}
