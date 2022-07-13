

export class Match{
    constructor(id, date, phase, live, homeg, awayg, winner, c1, c2){
        this.IDmatch=id;
        this.MatchDate=date;
        this.MatchPhase=phase;
        this.Live=live;
        this.HomeGoals=homeg;
        this.AwayGoals=awayg;
        this.Winner=winner;
        this.Club1=c1;
        this.Club2=c2;
        this.container=document.createElement("div");
    }

    draw(parentContainer){
        let container = document.createElement("div");
        container.classList.add("match-container");
        console.log("radim kao");
        let goalsdiv = document.createElement("div");
        let homename=document.createElement("p");
        homename.className = "TeamName";
        let awayname=document.createElement("p");
        awayname.className = "TeamName";

        homename.innerHTML=this.Club1;
        awayname.innerHTML=this.Club2;
        goalsdiv.classList.add("goals");
        let homegaols = document.createElement("p");
        homegaols.className = "GoalLabel";
        homegaols.innerHTML = this.HomeGoals;

        let line = document.createElement("p");
        line.innerHTML = "-";
        line.className = "GoalLabel";


        let awaygaols = document.createElement("p");
        awaygaols.className = "GoalLabel";
        awaygaols.innerHTML = this.AwayGoals;

        goalsdiv.appendChild(homename);
        goalsdiv.appendChild(homegaols);
        goalsdiv.appendChild(line);
        goalsdiv.appendChild(awaygaols);
        goalsdiv.appendChild(awayname);



        let isLive = document.createElement("p");
        isLive.className ="liveLabel";
        if(this.Live)
            isLive.innerHTML = "UZIVO MEČ";
        else
            isLive.innerHTML = "MEČ NIJE UŽIVO";    


        container.appendChild(goalsdiv);
        container.appendChild(isLive);

        parentContainer.appendChild(container);
    }
}