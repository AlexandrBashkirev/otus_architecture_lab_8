using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otus_architecture_lab_8
{
    public class FileParserXml : HandlerBase
    {
        #region Methods

        public override void Handle(object request)
        {
            if(request is string path &&
                path.EndsWith(".xml"))
            {

            }
            else
            {
                parent.Handle(request);
            }
        }

        #endregion
    }
}
