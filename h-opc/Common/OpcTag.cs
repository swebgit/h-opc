using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hylasoft.Opc.Common
{
    public class OpcTag
    {
        /// <summary>
        /// The fully-qualified identifier of the tag. You can specify a subfolder by using a comma delimited name.
        /// E.g: the tag `foo.bar` writes on the tag `bar` on the folder `foo`
        /// </summary>
        public string Tag { get; set; }
        /// <summary>
        /// The value to write to the tag
        /// </summary>
        public object Value { get; set; }
    }
}
