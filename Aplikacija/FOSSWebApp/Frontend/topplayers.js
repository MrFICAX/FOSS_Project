import { StatPlayer } from "./statPlayer.js";

export class TopPlayers{
    constructor(div){
        this.PlayersStats=[];
        this.TNames=[];
        this.fetchTournirsNames();
        console.log("ovde sam");
    
        //this.fetchTopPlayers(element);

        //this.fetchTopPlayers();
        this.divic = div;

    //    this.draw();//napravi ovu funkciju!
    }

    fetchTournirsNames(){
        fetch("https://localhost:5001/foss/returnTournirsPom").then(p=>{
            p.json().then(data=>{
                data.forEach(element => {
                    this.TNames.push(element.tournirName);
                    console.log(element.tournirName);
                    this.fetchTopPlayers(element.tournirName);
                });
            });
        }).catch(e=>{
            console.log(e);
        });
    }

    fetchTopPlayers(tname){
        var counter=0;
        fetch("https://localhost:5001/foss/returnPlayerStat/"+tname).then(p=>{
            p.json().then(data=>{
                data.forEach(ps => {
                    console.log(ps);
                    console.log(counter);
                    if(ps.goals==0)
                        return;
                    const stat=new StatPlayer(ps.iDpstatistic, ps.goals, ps.cards, ps.playerStat.clubPlayingFor.clubName, ps.playerStat.personName, ps.playerStat.surname, tname);
                    this.PlayersStats.push(stat);
                    //this.check();
                    let ch=tname.split(' ');
                    let ch2="";
                    ch.forEach(element => {
                        ch2+=element;
                    });
                    let pom=document.getElementsByClassName(ch2)[0];
                    if(pom==null){
                        pom=document.createElement("div");
                        pom.classList.add(ch2);
                        this.initTournirDiv(pom, stat, tname);
                        this.divic.appendChild(pom);
                    }

                   stat.draw(pom);
                   
                });
            });
        });

        this.PlayersStats.sort(function(a, b){
            return a.Goals-b.Goals;
        });

        this.PlayersStats=this.PlayersStats.slice(0, 5);
    }

    check(){
            this.PlayersStats.sort(function (a,b){
                if(a.Goals>b.Goals)
                    return -1;
                else
                    return 1;
            });
            this.PlayersStats=this.PlayersStats.slice(0, 5);
    }

    draw(parentContainer){
        let tournircont=document.createElement("div");
        tournircont.innerHTML=this;

        let container = document.createElement("div");
        container.classList.add("stat-list");

        let tournirName = document.createElement("p");

        tournirName.innerHTML = this.TName;

        container.appendChild(tournirName);

        console.log("drawww");
        this.PlayersStats.forEach(stat=>{
            console.log("caoP");
            stat.draw(container);
        });

        parentContainer.appendChild(container);
    }

    get playerStats(){
        return this.PlayersStats;
    }

    initTournirDiv(tDiv, stat, ttname){
        let dicvtt = document.createElement("h4");;
        dicvtt.innerHTML = ttname;
        tDiv.appendChild(dicvtt);
         tDiv.classList.add("stat-div-org");
        //tDiv.appendChild(tt);
         tDiv.style.border = "2px solid black";
    }
}