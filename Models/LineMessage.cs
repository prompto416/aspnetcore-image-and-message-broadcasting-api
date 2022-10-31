using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LineService.Models
{
    public class LineMessage
    {
        public class PushLineMsg
        {
            public List<string> to { get; set; }
            public List<TextMessage> messages { get; set; }
        }
        public class TextMessage
        {
            public string text { get; set; }
            public string type { get; set; }
            public string originalContentUrl { get; set; }
            public string previewImageUrl { get; set; }
        }
    }
}
