import {Player} from "./player.js"


export class Club{
    constructor(id, name, players){
        this.IDclub=id;
        this.Name=name;
        this.Players=[];
        this.container=document.createElement("div");
        this.container.classList.add("club");
        this.showPlayerList = false;
        //this.playersDiv;
        players.forEach(p => {
            this.Players.push(p);
        });
    }

    draw(parentContainer){
        let clubNameText = document.createElement("p");
        clubNameText.className ="ClubName";
        clubNameText.innerHTML = this.Name;

        let playersDiv = document.createElement("div");
        playersDiv.classList.add("players-div");

        this.container.onclick = (ev)=>{
            if(!this.showPlayerList)
                this.togglePlayersView(playersDiv);
            else
                while(playersDiv.childElementCount!=0)
                playersDiv.removeChild(playersDiv.firstChild);
        
        this.showPlayerList = !this.showPlayerList;
        }

        this.container.appendChild(clubNameText);
        this.container.appendChild(playersDiv);

        parentContainer.appendChild(this.container);
    }

    togglePlayersView(playersDiv){
        console.log("tu sam");
                this.Players.forEach((el) => {
                el.draw(playersDiv);
            });
        }
}