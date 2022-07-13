import { TournamentList } from "./tournamentList.js";
import { Tournament } from "./tournament.js";
import { Club } from "./club.js";
import {Match} from "./match.js"
 
let div = document.getElementsByClassName("tournaments-div")[0];
console.log(div);
console.log("stigo sam 1");
let tournaments = new TournamentList();



// let t = new Tournament(14,"t","f","g",[new Club("fd","fd",[])],[new Match(4,"ff","zreb","live",15,15,undefined)],[],[]);

// tournaments.testAdd(t);
tournaments.draw(div);