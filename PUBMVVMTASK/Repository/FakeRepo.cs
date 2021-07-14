using PUBMVVMTASK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBMVVMTASK.Repository
{
    public class FakeRepo
    {
        MainWindow view;
        public List<Pub> GetAll()
        {
            return view.Pubs;
        }
    }
}
