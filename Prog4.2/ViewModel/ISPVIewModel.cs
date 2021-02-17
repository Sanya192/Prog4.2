using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prog4._2.Models;

namespace Prog4._2.ViewModel
{
    public  class ISPVIewModel
    {
        public InternetService ActualService { get; set; }
        public List<InternetService> AllServices { get; set; }

        public BandwithType[] AllBandwiths { get; set; }
        public ISPVIewModel()
        {
            AllServices = StandardElements();
            ActualService = AllServices.First();
            AllBandwiths = Enum.GetValues(typeof(BandwithType)) as BandwithType[];
        }
        private List<InternetService> StandardElements()
        {
            List<InternetService> internets = new List<InternetService> {
                new InternetService("256-523",new DateTime(2005,07,30),18,BandwithType.UltraFast),

            };
            return internets;
        }

    }
}
