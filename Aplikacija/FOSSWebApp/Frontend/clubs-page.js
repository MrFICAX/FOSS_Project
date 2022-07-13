import { Club } from "./club.js";
import { Player } from "./player.js";
import {ClubList} from "./clublist.js";

console.log("radim clubs");

let clubsDiv = document.getElementsByClassName("clubs-div")[0];
console.log(clubsDiv);

//let testCLub = new Club(13, "Nesto", [new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"),new Player(1,"dfdf","fdfdf",4,false,"golman"), new Player(2,"fdfdf","dfdfdfdgdf",5,true, "nestoRadi")]);

//testCLub.draw(clubsDiv);

let clubList = new ClubList(clubsDiv);