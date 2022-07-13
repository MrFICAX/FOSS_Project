import {Club} from "./club.js"
import { Match } from "./match.js";
import { Player } from "./player.js";
import { StatClub } from "./statClub.js";
import { StatPlayer } from "./statPlayer.js";


export class Tournament{
    constructor(id, name, city, date, clubs, matches, statistics1, statistics2){
        this.IDtournir=id;
        this.Name = name;
        this.City=city;
        this.Date=date;
        this.Clubs=[];
        this.Matches= [];
        this.StatisticsClub=[];
        this.StatisticsPlayer=[];
        this.details = false;
        this.deailsContainer = document.createElement("div");
        this.deailsContainer.classList.add("details");
        clubs.forEach(element => {
            this.Clubs.push(element);
        });
        matches.forEach(element => {
            this.Matches.push(element);
        });
        /*statistics1.forEach(element => {
            this.StatisticsClub.push(element);
        });
        statistics2.forEach(element => {
            this.StatisticsPlayer.push(element);
        });*/
        this.container = document.createElement('div');
        this.container.classList.add("tournir");
    }

    draw(parentContainer){
        let nameDiv = document.createElement("div");
        nameDiv.classList.add("tournament-info-div");
        let team1Div = document.createElement("div");
        team1Div.classList.add("tournament-info-div");
        let team2Div = document.createElement("div");
        team2Div.classList.add("tournament-info-div");

        nameDiv.innerHTML = "Ime turnira: "+this.Name;
        nameDiv.className = "PodaciOTakmicenju";
        team1Div.innerHTML = "Lokacija održavanja: "+this.City;
        team1Div.className = "PodaciOTakmicenju";
        team2Div.innerHTML = "Datum održavanja turnira: "+this.Date;
        team2Div.className = "PodaciOTakmicenju";

        this.container.appendChild(team1Div);
        this.container.appendChild(team2Div);
        this.container.appendChild(nameDiv);
        this.container.appendChild(this.deailsContainer);

        this.container.onclick = (ev)=>{
            if(!this.details)
                this.toggleDetails();
            else
                while(this.deailsContainer.childElementCount>0)
                    this.deailsContainer.removeChild(this.deailsContainer.firstChild);

        this.details = !this.details;
        }

        parentContainer.appendChild(this.container);
    }

    toggleDetails(){
        this.Matches.forEach((el)=>{
            el.draw(this.deailsContainer);
        });
    }

}