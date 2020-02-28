using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace CoreAngularDemo.Localization
{
    public static class CoreAngularDemoLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    CoreAngularDemoConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(CoreAngularDemoLocalizationConfigurer).GetAssembly(),
                        "CoreAngularDemo.Localization.CoreAngularDemo"
                    )
                )
            );
        }
    }
}