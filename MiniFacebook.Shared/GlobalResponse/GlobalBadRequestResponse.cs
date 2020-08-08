using System.Collections.Generic;

namespace MiniFacebook.Shared.GlobalResponse
{
    public class GlobalBadRequestResponse : GlobalResponse
    {
        public IDictionary<string, string[]> Validation { get; set; }

    }
}
