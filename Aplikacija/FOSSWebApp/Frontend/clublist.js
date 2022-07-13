import { Club } from "./club.js";
import { Player } from "./player.js";

export class ClubList{
    constructor(a){
        this.Clubs=[];
        this.fetchclubs();
        this.div=a;
    }

    async fetchclubs(){
        console.log("cao1");
        const el = await fetch("https://localhost:5001/foss/returnClubs").then(p=>{
            p.json().then(data=>{
                console.log(data);
                data.forEach(c => {
                    const players=[];
                    
                    c.players.forEach(plyr => {
                        const pl=new Player(plyr.iDperson, plyr.personName, plyr.surname, plyr.num, plyr.captain, plyr.position);
                        players.push(pl);
                    });

                    const club=new Club(c.iDclub, c.clubName, players);
                    this.Clubs.push(club);
                });
                this.Clubs.forEach(element => {
                    element.draw(this.div);
                });

                
            }).catch(e=>{
                console.log(e);

            });
            
        });
        console.log(el);
    }

    getClubs(){
        return this.Clubs;
    }
    getdivaa(){
        return this.a;

    }
}