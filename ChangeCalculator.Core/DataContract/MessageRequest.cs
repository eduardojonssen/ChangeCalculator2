using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalculator.Core.DataContract
{
    public class MessageRequest
    {
        public string Field { get; set; }
        public ICollection<string> MessageCollection { get; set; }

        public MessageRequest(string field, ICollection<string> messageCollection)
        {
            Field = field;
            MessageCollection = messageCollection;
        }
    }
}
