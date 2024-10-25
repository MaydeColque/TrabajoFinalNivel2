using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public static class Helper
    {
        public static void cargarImagen(PictureBox nombreTool, string Url)
        {
            try
            {
                nombreTool.Load(Url);
            }
            catch (Exception ex)
            {
                nombreTool.Load("http://www.coalitionrc.com/wp-content/uploads/2017/01/placeholder.jpg");
            }
        }
    }
}
