using System;
using System.Collections.Generic;
using System.Text;
using WinFormsMiniProjectLibrary.Models;

namespace WinFormsMiniProjectLibrary
{
    public interface ISaveAddress
    {
        void SaveAddress(AddressModel address);
    }
}
