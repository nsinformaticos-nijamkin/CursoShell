﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ThePhoto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class appShell : Shell
    {

        public ICommand HelpCommand => new Command(() =>
        {
            Device.OpenUri(new Uri("https://academiadotnet.teachable.com"));


        });
            public appShell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}