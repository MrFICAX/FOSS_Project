using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.SignalR;

namespace Backend.Controllers{
    public class MatchHub: Hub{
        public Task updateMatch(TMatch match){
            return Clients.All.SendAsync("RecieveMessage",match.HomeGoals, match.AwayGoals, match.Live);
        }
    }
}