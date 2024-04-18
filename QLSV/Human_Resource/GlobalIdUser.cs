using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    public static class GlobalIdUser
    {
        public static int GlobalUserId { get; private set; }

        public static void SetGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}