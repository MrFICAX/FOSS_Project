import { StatPlayer } from "./statPlayer.js";
import { TopPlayers } from "./topplayers.js";
import { TournamentList } from "./tournamentList.js";


let div = document.getElementsByClassName("stats-div")[0];

//let tur = new TournamentList();

let stats=new TopPlayers(div);


/*tur.getFetch().then((data)=> data.json).then(values=>{
    values.forEach((el)=> new TopPlayers(el.Name, div));
}).catch(err => "greska u vekijevoj logici!");*/

// tur.trnList().forEach(el=>{
//     let stats = new TopPlayers(el.Name);
//     console.log(el.Name);
//     stats.draw(div);
// });

