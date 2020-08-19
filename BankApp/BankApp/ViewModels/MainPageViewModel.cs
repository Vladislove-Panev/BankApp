using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp.ViewModels
{
    public class MainPageViewModel
    {
        public int PhysicalCardCount { get; set; }
        public int VirtualCardCount { get; set; }
        public MainPageViewModel()
        {
            PhysicalCardCount = 2;
            VirtualCardCount = 0;
        }
    }
}
