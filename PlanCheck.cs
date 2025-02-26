using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

[assembly: AssemblyVersion("1.0.0.1")]

namespace VMS.TPS
{
  public class Script
  {
    public Script()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(ScriptContext context /*, System.Windows.Window window, ScriptEnvironment environment*/)
    {
            // TODO : Add here the code that is called when the script is launched from Eclipse.
            Patient patient = context.Patient;

            if (null == patient)
            {
                MessageBox.Show("No patient selected! Script stops.");
                return;
            }

            var ps = context.PlanSetup;
            if (null == ps)
            {
                MessageBox.Show("No plan selected! Script stops.");
                return;
            }

            int res = CheckIfImageEquidistant(ps);
                      
        }
    } // Execute

    private int CheckIfImageEquidistant(PlanSetup ps)
    {
        int z_size = ps.StructureSet.Image.ZSize;

        for (int i = 0; i < z_size; i++)
        {
            
        }

    } // CheckIfImageEquidistant

}
