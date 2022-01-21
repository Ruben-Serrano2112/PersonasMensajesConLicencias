﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace PersonasMensajes
{
    /// <summary>
    /// Lógica de interacción para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            String key = PersonasMensajes.Properties.Settings.Default.key;
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(key);
        }

    }
}
