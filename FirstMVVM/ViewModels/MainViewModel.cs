using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstMVVM.ViewModels
{
    class MainViewModel
    {
        public List<String> Shapes { get; set; }
        public string SelectedShape { get; set; }
        public MainViewModel()
        {
            Shapes = new List<string>() { "Rechteck", "Kreis" };
            SelectedShape = "Kreis";
        }
    }
}
