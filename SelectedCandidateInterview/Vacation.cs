using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectedCandidateInterview
{
   public class Vacation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Status { get; set; }
        public string Requriment { get; set; }
        public int CompanyId { get; set; }

        public static void Show(List<Vacation> vacations)

        {

            foreach (var i in vacations)
            {

                Console.WriteLine($"Id :{i.Id}\n Ad:{i.Name}\n Tələblər:{i.Requriment}\n");
            }

        }
    }
}
