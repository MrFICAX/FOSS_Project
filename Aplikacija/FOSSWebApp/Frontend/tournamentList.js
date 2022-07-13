import {Tournament} from "./tournament.js"
import { Club } from "./club.js";
import { StatClub } from "./statClub.js";
import { StatPlayer } from "./statPlayer.js";
import { Player } from "./player.js";
import { Match } from "./match.js";



export class TournamentList{
    constructor(){
        this.tournamentList = [];
        this.container = document.createElement("div");
        this.container.classList.add("tournament-list");

        this.fetchTorunamet();

       // this.draw();
    }

    draw(parentContainer){
        console.log("stigo sam");
        this.tournamentList.forEach(el =>{
            el.draw(this.container);
        });

        parentContainer.appendChild(this.container);
    }

    getFetch(){
        return fetch("https://localhost:5001/foss/returnTournirs");
    }

    fetchTorunamet(){
        fetch("https://localhost:5001/foss/returnTournirs").then(p=>{
            p.json().then(data=>{
                data.forEach(t=>{
                    
                        const clubs=[];
                        const matches=[];
                        //const statclub=[];
                        //const statplayer=[];

                    if(t.clubs.length!=0){
                        t.clubs.forEach(c => {
                            const players=[];
                        if(c.players!=null){
                            c.players.forEach(plyr => {
                                const pl=new Player(plyr.IDperson, plyr.PersonName, plyr.Surname, plyr.Num, plyr.Captain, plyr.Position);
                                players.push(pl);
                            });
                        }
                            const club=new Club(c.IDclub, c.Name, players);
                            clubs.push(club);
                        });
                    }
                    if(t.tMatches.length!=0){
                        t.tMatches.forEach(m=>{
                            const match=new Match(m.iDmatch, m.matchDate, m.matchPhase, m.live, m.homeGoals, m.awayGoals, m.winner, m.club1.clubName, m.club2.clubName);
                            matches.push(match);
                        });
                        /*t.clubsStatistics.forEach(cs=>{
                            const stat=new StatClub(cs.iDcstatistic, cs.wins, cs.loses, cs.draws, cs.clubStat.clubName);
                            statclub.push(stat);
                        });
                        t.playerStatistics.forEach(ps=>{
                            const stat=new StatPlayer(ps.iDpstatistic, ps.goals, ps.cards, ps.playerStat.clubPlayingFor.clubName);
                            statplayer.push(stat);
                        });*/
                    }
                        const trn=new Tournament(t.iDtournir, t.tournirName, t.city, 
                            t.tournirDate, clubs, matches, null, null);
                        this.tournamentList.push(trn);
                        console.log(trn);
                        trn.draw(this.container);
                    });
                });
            });
    }

    trnList(){
        return this.tournamentList;
    }

    testAdd(t){
        this.tournamentList.push(t);
    }
}