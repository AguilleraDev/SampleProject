using MVVM_API_SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_API_SampleProject.ViewModels
{
    public class ListaViewModel
    {
        public Lista Lista { get; set; }

        public ListaViewModel() 
        {
          Lista = new Lista()
            {
                UserId = 5,
                Id = 5,
                Title = "titlo",
                Completed = "False"
            };
        }
    }
}
