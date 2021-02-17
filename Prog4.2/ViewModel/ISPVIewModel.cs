using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Prog4._2.Models;

namespace Prog4._2.ViewModel {
    public class ISPVIewModel  {
        public InternetService ActualService { get; set; }
        public ObservableCollection<InternetService> AllServices { get; set; }

        public BandwithType[] AllBandwiths { get; set; }
        public ISPVIewModel() {
            AllServices = StandardElements();
            ActualService = AllServices.First().Clone() as InternetService;
            AllBandwiths = Enum.GetValues(typeof(BandwithType)) as BandwithType[];
        }


        private ObservableCollection<InternetService> StandardElements() {
            ObservableCollection<InternetService> internets = new ObservableCollection<InternetService> {
                new InternetService("256-523",new DateTime(2005,07,30),18,BandwithType.UltraFast),

            };
            return internets;
        }
        public void CloneTheActualIntoAll() {
            AllServices.Add(ActualService.Clone() as InternetService);
        }
        /*protected void OnPropertyChanged([CallerMemberName] string name=null) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }*/
    }
}
