﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteCommand
{
    interface IsAdministrator
    {
        //    public bool IsUserAdministrator()
        //    {
        //        bool isAdmin;
        //        try
        //        {
        //            WindowsIdentity user = WindowsIdentity.GetCurrent();
        //            WindowsPrincipal principal = new WindowsPrincipal(user);
        //            isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
        //        }
        //        catch (UnauthorizedAccessException ex)
        //        {
        //            isAdmin = false;
        //        }
        //        catch (Exception ex)
        //        {
        //            isAdmin = false;
        //        }
        //        return isAdmin;
        //    }
        //}
    }
}
