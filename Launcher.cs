﻿using GUI.LauncherScenes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
            LauncherMenu launcherMenu = new LauncherMenu();
            this.Controls.Add(launcherMenu);
        }


    }
}
