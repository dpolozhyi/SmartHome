using System.Collections.Generic;
using System.Linq;
using SmartHome.Components.Interfaces;

namespace SmartHome.Components.Components
{
    public class Channeler : IChannable, IEntity
    {
        public int Id { get; set; }

        private int currentChannel;

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
            if(this.currentChannel < this.Channels.Count-1)
            {
                this.currentChannel++;
            }
        }

        public void PreviousChannel()
        {
            if (this.currentChannel > 0)
            {
                this.currentChannel--;
            }
        }

        public bool SetChannel(string channel)
        {
            if(this.Channels.Contains(channel))
            {
                this.currentChannel = this.Channels.ToList().IndexOf(channel);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetCurrentChannel()
        {
            return this.Channels.ToList()[currentChannel];
        }

        public IEnumerable<string> GetChannelsList()
        {
            return this.Channels;
        }
    }
}
