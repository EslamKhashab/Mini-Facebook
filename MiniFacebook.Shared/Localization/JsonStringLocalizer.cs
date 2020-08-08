using Microsoft.Extensions.Localization;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;

namespace MiniFacebook.Shared.Localization
{
    public class JsonStringLocalizer : IStringLocalizer
    {
        List<JsonLocalization> localization = new List<JsonLocalization>();
        public JsonStringLocalizer()
        {
            localization = JsonConvert.DeserializeObject<List<JsonLocalization>>(File.ReadAllText(@"Resources/localization.json"));
        }
        public LocalizedString this[string name]
        {
            get
            {
                var value = GetString(name);
                return new LocalizedString(name, value ?? name, resourceNotFound: value == null);
            }
        }
        public LocalizedString this[string name, params object[] arguments]
        {
            get
            {
                var format = GetString(name);
                var value = string.Format(format ?? name, arguments);
                return new LocalizedString(name, value, resourceNotFound: format == null);
            }
        }
        public IEnumerable<LocalizedString> GetAllStrings(bool includeParentCultures)
        {
            return localization.Where(l => l.LocalizedValue.Keys.Any(lv => lv == Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)).Select(l => new LocalizedString(l.Key, l.LocalizedValue[Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName], true));
        }
        public IStringLocalizer WithCulture(CultureInfo culture)
        {
            return new JsonStringLocalizer();
        }
        private string GetString(string name)
        {
            var lang = Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName;
            var query = localization.Where(l => l.LocalizedValue.Keys.Any(lv => lv == Thread.CurrentThread.CurrentCulture.TwoLetterISOLanguageName)).ToList();
            var value = query.Where(l => l.Key == name).SingleOrDefault();
            return value.LocalizedValue[CultureInfo.CurrentCulture.Name];
        }
    }
}
