using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectedCandidateInterview
{
   public class Candidate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool MicrosoftCertificate { get; set; }
        public int VacationId { get; set; }
        public static void Show(List<Candidate> candidates)
        
        {
            foreach (var i in candidates) 
            {

                Console.WriteLine($"Id :{i.Id}\n Ad:{i.Name}\n Vakansiya:{i.VacationId}\n");
             }
           
        }
        public void SelectOption(int option)
        {
            if (option == 1)
            {
                Console.WriteLine("Adres mene uzaq oldugu ucun zoom meetingi secirem");
            }
            else { 
            Console.WriteLine("Musahibenin ofisde kecirilmesini secirem ");
            }
        }
        

    }
}
