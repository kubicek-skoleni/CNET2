using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Model
{
    public interface IAdresa
    {
        public string FullAddress();

        bool IsValid();
    }
}
