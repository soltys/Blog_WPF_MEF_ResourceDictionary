using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Current.Resources.MergedDictionaries.Clear();
            var catalog = new AggregateCatalog();
            catalog.Catalogs.Add(new DirectoryCatalog("Resources"));
            var container = new CompositionContainer(catalog);

            var resourceDictionaries =
                container.GetExports<ResourceDictionary, IResourceDictionaryMetadata>()
                    .OrderBy(x => x.Metadata.Order)
                    .Select(x => x.Value);

            foreach (var resourceDictionary in resourceDictionaries)
            {
                Current.Resources.MergedDictionaries.Add(resourceDictionary);
            }

            base.OnStartup(e);
        }
    }

    public interface IResourceDictionaryMetadata
    {
        int Order { get; }
    }
}
