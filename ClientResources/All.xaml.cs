using System.ComponentModel.Composition;
using System.Windows;

namespace ClientResources
{
    [Export(typeof(ResourceDictionary))]
    [ExportMetadata("Order", 1000)]
    public partial class All 
    {
        public All()
        {
            InitializeComponent();

        }
    }
}
