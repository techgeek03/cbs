using System.Collections.Generic;

namespace Domain.AutomaticReplyMessages
{
    public delegate bool IsTagsValid(IEnumerable<string> tags);
}
