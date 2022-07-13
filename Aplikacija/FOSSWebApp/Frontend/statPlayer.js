

export class StatPlayer{
    constructor(id, goals, cards, clubname, pname, sname, tname){
        this.Pname=pname;
        this.Tname=tname;
        this.Psurname=sname;
        this.IDstatPlayer=id;
        this.Goals=goals;
        this.Cards=cards;
        this.ClubName=clubname;
        this.container = document.createElement("div");
        this.container.classList.add("player-stats");
    }

    draw(parentContainer){
        

        let goalTxt = document.createElement("p");
        let clubTxt = document.createElement("p");
        let nameSurnameText = document.createElement("h3");

        nameSurnameText.innerHTML = `${this.Pname} ${this.Psurname}`;

        goalTxt.innerHTML ="Golovi: " + this.Goals;
        clubTxt.innerHTML ="Klub: " + this.ClubName;

        this.container.appendChild(nameSurnameText);
        this.container.appendChild(goalTxt);
        this.container.appendChild(clubTxt);

        parentContainer.appendChild(this.container);

       

        
    }
}