using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome.Components.Interfaces
{
    public interface IChannable
    {
        void NextChannel();

        void PreviousChannel();

        string GetCurrentChannel();
    }
}
