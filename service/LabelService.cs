using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banking_system.service
{
    public class LabelService
    {
        public static void CenterLabel(Form form, Label label)
        {
            Point point = label.Location;
            point.X = (form.Width - label.Width) / 2;
            label.Location = point;
        }
    }
}
