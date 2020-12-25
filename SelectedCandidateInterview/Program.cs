using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectedCandidateInterview
{
    class Program
    {
        static void Main(string[] args)
        {    
            Company company = new Company() 
            {
                Id = 1,
                Name= "Azerfon",
                Address= "106A Heydar Aliyev Ave, Baku 1029"
            };
            Position position = new Position()
            {
                Id = 1,
                Name = "HR",
                CompanyId=1
            };
            Employee employee = new Employee()
            {
                Id = 1,
                Name = "Azerfon",
                PositionId=1,
                Status=1
            };
            
            Console.WriteLine("Vankansiyalar");
            List<Vacation> vacation = new List<Vacation>
            {
             new Vacation { Id=1,Name = "Software Developer" ,Status=1, Requriment="MS Certificate",CompanyId=1 },
             new Vacation { Id=2,Name = "Project Manager"  ,Status=1, Requriment="MS Certificate" ,CompanyId=1},
             new Vacation {Id=3,Name = "Product Manager" ,Status=1, Requriment="MS Certificate",CompanyId=1}
            };
            Vacation.Show(vacation);
            List<Candidate> candidates = new List<Candidate>
            {
             new Candidate { Id=1,Name = "Nigar" ,VacationId=1,MicrosoftCertificate=false },
             new Candidate { Id=2,Name = "Nergiz"  ,VacationId=2,MicrosoftCertificate=true },
             new Candidate {Id=3,Name = "Nermin" ,VacationId=3,MicrosoftCertificate=true }
            };
            for (; ; )
            {
                Console.WriteLine("Vakasiyanin Idsini  seçib namizedlerin siyahısına bax\n Id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Namizedler");
                var candidateForVacation = candidates.Where(c => c.VacationId == Id).ToList();
                Candidate.Show(candidateForVacation);

                Console.WriteLine("namizedin Idsini  seçin bax\n Id:");
                int candidateId = Convert.ToInt32(Console.ReadLine());
                var selectedcandidate=candidateForVacation.Where(f => f.Id == candidateId).FirstOrDefault();
                company.SelectCandidate(selectedcandidate.Id);
                if (selectedcandidate.MicrosoftCertificate == false)
                {
                    Console.WriteLine("Namizedin MS sertifikati olmadigina gore musahibeye cagirilmayacaq");

                }
                else
                {
                    company.InviteCandidateInterview(selectedcandidate.Id);
                    company.Offeroptions();
                    Console.WriteLine("Namizedin secimi");
                    int option = Convert.ToInt32(Console.ReadLine());
                    selectedcandidate.SelectOption(option);
                }
            }

        }


       


        }
}
