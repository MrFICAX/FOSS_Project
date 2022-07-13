import { signalR } from "../wwwroot/lib/signalr/dist/browser/signalr";
import { Match } from "./match";

export class LiveMatches{
    constructor(){
        this.Matches=[];
        this.fetchMatches();
        var connection=new signalR.HubConnectionBuilder().withUrl("/matchhub").build();
    }

    fetchMatches(){
        fetch("http://localhost:5001/foss/returnLiveMatches").then(p=>{
            p.json().then(data=>{
                data.forEach(m => {
                    const match=new Match(m.IDmatch, m.MatchDate, m.MatchPhase, m.Live, m.HomeGoals, m.AwayGoals, m.Winner);
                    this.Matches.push(match);
                });
            });
        });

        connection.on("RecieveMessage",function(a, b, c, d){
            this.Matches.forEach((m, index) => {
                if(m.IDmatch==a){
                    m.HomeGoals=b;
                    m.AwayGoals=c;
                    m.Live=d;

                    if(d==false){
                        //obrisi iz liste meceva uzivo
                        this.Matches.splice(index, 1);
                    }
                }
            });

            this.draw();//napravi ovu funkciju

        });
    }
}