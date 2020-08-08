using System.IO;
using System.Linq;

namespace MiniFacebook.Shared.Helper
{
    public class PhotoSettings
    {
        public int MaxBytes { get; set; }

        public string[] AcceptedFilestypes { get; set; }

        public bool IsSupported(string FileName)
        {
            return AcceptedFilestypes.Any(s => s == Path.GetExtension(FileName).ToLower());
        }
    }
}
