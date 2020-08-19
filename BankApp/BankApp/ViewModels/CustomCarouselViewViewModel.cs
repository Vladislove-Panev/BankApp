using BankApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace BankApp.ViewModels
{
    public class CustomCarouselViewViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Card> _cards;

        public ObservableCollection<Card> Cards 
        {
            get { return _cards; }
            set
            {
                _cards = value;
                OnPropertyChanged("Cards");
            }
        }

        public CustomCarouselViewViewModel()
        {
            Cards = new ObservableCollection<Card>
            {
                new Card("0909 1111 2222 0987", "Kolya Mar", "2000", "09/11", "344"),
                new Card("0000 1111 2222 3333", "Kolya Mar", "4322", "08/23", "567")
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
