﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mmosoft.Facebook.Sdk;

namespace Mmosoft.Facebook.Sdk.Examples
{
    class Program
    {
        [STAThreadAttribute]
        static void Main(string[] args)
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
