using SP.Cmd.Deploy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spf_imagefield
{
    class Program
    {
        static void Main(string[] args)
        {
            SharePoint.CmdExecute(args, "SPF Image Field",
                options =>
                {
                    Model.Deploy(options);
                },
                null,
                null
            );

            var t = "";
        }
    }
}
