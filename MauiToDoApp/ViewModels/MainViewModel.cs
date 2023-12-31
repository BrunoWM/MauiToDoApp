﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiToDoApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string task;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(Task)) 
                return;

            Items.Add(Task);

            Task = string.Empty;
        }

        [RelayCommand]
        void Remove(string t)
        {
            if (Items.Contains(t)) Items.Remove(t);
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Task={s}");
        }
    }
}
