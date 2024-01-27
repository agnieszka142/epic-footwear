﻿using Grzymska.EpicFootwear.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grzymska.EpicFootwear.UI
{
    internal class NavigationStore : ViewModelBase
    {
        private ViewModelBase _currentViewModel;

        public ViewModelBase CurrentViewModel
        {
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }
        
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public event Action CurrentViewModelChanged;
    }
}
