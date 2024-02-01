using Library;
using Library.Entities;
using Library.Repositories;
using Library.Repositories.Interfaces;
using Library.Repositories;
using Library.Utilities;
using Library.Utilities.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using static Org.BouncyCastle.Math.EC.ECCurve;
using Library;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationForm form = new ApplicationForm(new ApplicationLogic());
            Application.Run(form);
        }
    }
}
