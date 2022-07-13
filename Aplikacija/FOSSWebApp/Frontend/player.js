

export class Player{
    constructor(id, name, surname, num, captain, pos){
        this.IDplayer=id;
        this.Name=name;
        this.Surname=surname;
        this.Num=num;
        this.Captain=captain;
        this.Position=pos;
    }

    draw(parentContainer){
        let container = document.createElement("div");
        container.className = "PlayerContainer";
        container.classList.add("player");

        let nameTxt= document.createElement("p");
        nameTxt.innerHTML="Ime igrača: "+this.Name;
        let surnameTxt= document.createElement("p");
        surnameTxt.innerHTML="Prezime igrača: "+this.Surname;
        let numTxt= document.createElement("p");
        numTxt.innerHTML="Broj igrača: "+this.Num;
        let positionTxt= document.createElement("p");
        positionTxt.innerHTML="Pozicija igrača: "+this.Position;

        container.appendChild(nameTxt);
        container.appendChild(surnameTxt);
        container.appendChild(numTxt);
        container.appendChild(positionTxt);

        parentContainer.appendChild(container);
    }
}