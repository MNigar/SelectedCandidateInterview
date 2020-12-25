using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectedCandidateInterview
{
   public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public void SelectVacation(int Id)
        {
            Console.WriteLine($" {Id}-li Vakansiya  seçildi");
        }
        public void SelectCandidate(int Id)
        {
            Console.WriteLine($"{Id}-idli Namized seçildi");
        }
        public void InviteCandidateInterview(int Id)
        {
            Console.WriteLine($"{Id}-idli Namized musahibeye cagirilir");
        }
        public void Offeroptions()
        {
            Console.WriteLine("Ofisde musahibe uchun 1 , zoom  meetingle musahibe uchun 2 duymesini klik edin");

        }


    }
}
