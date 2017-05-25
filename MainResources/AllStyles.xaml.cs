using System.ComponentModel.Composition;
using System.Windows;

namespace MainResources
{
    [Export(typeof(ResourceDictionary))]
    [ExportMetadata("Order", 100)]
    public partial class AllStyles : ResourceDictionary
    {
        public AllStyles()
        {
            InitializeComponent();

        }
    }
}
