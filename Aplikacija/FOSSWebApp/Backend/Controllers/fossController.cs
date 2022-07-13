using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Backend.Models;
using System;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Cors;
using System.IO;

namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class fossController : ControllerBase
    {
        public fossContext Context { get; set; }
        private MatchHub hub=new MatchHub();

        public fossController(fossContext context)
        {
            Context=context;
        }

       

        #region Admin
        [Route("loginAdmin/{enterkey}")]
        [HttpGet]
        public async Task<Admin> loginAdmin([FromRoute]string  enterkey){
            try{
                // Admin adm= await Context.Admins.Where(pom=>pom.EnterKey==enterkey)
                //                         .Include(x=>x.Tournirs)
                //                             .ThenInclude(x=>x.TMatches)
                //                                 .ThenInclude(z => z.Refereee).FirstAsync();
                Admin adm= await Context.Admins.Where(pom=>pom.EnterKey==enterkey)
                                     .Include(x=>x.Tournirs)
                                    //     .ThenInclude(x=>x.TMatches)
                                    //         .ThenInclude(z => z.Refereee)
                                    // .Include(x=>x.Tournirs)
                                    //     .ThenInclude(x=>x.Clubs)
                                    //         .ThenInclude(x=>x.Players)
                                    // .Include(x=>x.Tournirs)
                                    //     .ThenInclude(y => y.TMatches)
                                    //         .ThenInclude(z => z.Club1)
                                    // .Include(x=>x.Tournirs)
                                    //     .ThenInclude(y => y.TMatches)
                                    //         .ThenInclude(z => z.Club2)                                                    
                                    // .Include(x=>x.Tournirs)
                                    //     .ThenInclude(x=>x.Clubs)
                                    //         .ThenInclude(x=>x.Trainer)
                                    .FirstAsync();
                
                //Console.WriteLine(adm.Tournirs.First().TournirName);


                if(adm==null){
                    return null;
                }
                else{
                    return adm;
                }
            }catch(Exception){
                //Console.WriteLine("caoo1");
                return new Admin();
            }
        }

        [Route("insertAdmin/{org}")]
        [HttpPost]
        public async Task<bool> insertAdmin([FromRoute] string org, [FromBody]Admin a){
            List<Admin> adm=Context.Admins.ToList();
            Organisator organisator=Context.Organisators.Where(x=>x.Username==org).First();
            Console.WriteLine(organisator.Pass);

            //Console.WriteLine("USAO SAM OVDEEE");

            Console.WriteLine(organisator.Username);

            a.GiveAccessBy=organisator;
            //Console.WriteLine(a.GiveAccessBy.Pass);
            foreach(Admin pom in adm){
                if(pom.EnterKey==a.EnterKey){
                    return false;
                }
            }

            Context.Admins.Add(a);
            await Context.SaveChangesAsync();
            return true;
        }

        [Route("assignAdminToTournir/{tName}")]
        [HttpPut]
        public async Task assignAdminToTournir([FromRoute]string tName, [FromBody]Admin a){
            Console.WriteLine("ovde sam");
            Admin adm = Context.Admins.Where(pom=>pom.EnterKey == a.EnterKey).Include(p => p.Tournirs).First();
            Console.WriteLine("ovde sam2");
            Tournir t = Context.Tournirs.Where(q => q.TournirName == tName).First();

            adm.Tournirs.Add(t);
            await Context.SaveChangesAsync();
        }

        [Route("unAssignAdminToTournir/{tName}")]
        [HttpPut]
        public async Task unAssignAdminToTournir([FromRoute]string tName, [FromBody]Admin a){
            var adm=Context.Admins.Where(pom=>pom.EnterKey==a.EnterKey).Include(p => p.Tournirs).First();
            Console.WriteLine(tName);
            Tournir t = adm.Tournirs.Where(p => p.TournirName == tName).First(); 
            Console.WriteLine(tName);

            adm.Tournirs.Remove(t);
            await Context.SaveChangesAsync();
        }

        [Route("returnAdmins")]
        [HttpGet]
        public async Task<List<Admin>> returnAdmins(){
            return await Context.Admins.ToListAsync();
        }

        [Route("updateAdmin")]
        [HttpPut]
        public async Task updateAdmin([FromBody]Admin a){
            Admin admin=Context.Admins.Where(x=>x.EnterKey==a.EnterKey).First();

            admin=a;

            admin.AdminName=a.AdminName;
            admin.AdminSurname=a.AdminSurname;
            

            await Context.SaveChangesAsync();
        }

        [Route("deleteAdmin")]
        [HttpPost]
        public async Task deleteAdmin([FromBody]Admin a){

            Admin admin=Context.Admins.Where(x=>x.EnterKey==a.EnterKey).First();

            Context.Admins.Remove(admin);

            await Context.SaveChangesAsync();
        }
        #endregion

        #region Referee
        [Route("insertReferee")]
        [HttpPost]
        public async Task<IActionResult> insertReferee([FromBody]Referee r){

                List<Referee> org=Context.Referees.Where(x=>x.Quality==r.Quality).ToList();

                if(org.Any()){
                    Console.WriteLine("Ovaj organizator vec postoji!");
                    return StatusCode(404);
                }

            Context.Referees.Add(r);
            await Context.SaveChangesAsync();
            return Ok(200);

        }

        [Route("returnReferees")]
        [HttpGet]
        public async Task<List<Referee>> returnReferees(){
            return await Context.Referees.ToListAsync();
        }

        [Route("updateReferee")]
        [HttpPut]
        public async Task updateReferee([FromBody]Referee r){
            Referee referee=Context.Referees.Where(x=>x.IDperson==r.IDperson).First();

            referee.Quality=r.Quality;

            await Context.SaveChangesAsync();
        }

        [Route("deleteReferee")]
        [HttpPost]
        public async Task deleteReferee([FromBody]Referee r){
            Referee referee=Context.Referees.Where(x=>x.IDperson==r.IDperson).First();

            Context.Referees.Remove(referee);

            await Context.SaveChangesAsync();

            
        }
        #endregion

        #region Organisator
        [Route("insertOrganisator")]
        [HttpPost]
        public async Task<bool> insertOrganisator([FromBody]Organisator o){
            List<Organisator> org=Context.Organisators.Where(x=>x.Username==o.Username).ToList();

                if(org.Any()){
                    Console.WriteLine("Ovaj organizator vec postoji!");
                    return false;
                }
            
            
            Context.Organisators.Add(o);
            await Context.SaveChangesAsync();
            return true;
        }

        [Route("loginOrganisator/{user}")]
        [HttpGet]
        public async Task<Organisator> loginOrganisator([FromRoute]string user){
            try{
            var org=await Context.Organisators.Where(pom=>pom.Username==user)
                                                     .Include(p=>p.AdminsCreated)
                                                        .ThenInclude(p=>p.Tournirs)
                                                     .Include(p=>p.TournirOrganised)
                                                        // .ThenInclude(p=>p.Clubs)                                                    
                                                        //     .ThenInclude(p=>p.Players)
                                                    // .Include(x=>x.TournirOrganised)
                                                    //     .ThenInclude(y => y.TMatches)
                                                    //         .ThenInclude(z => z.Refereee)
                                                    // .Include(x=>x.TournirOrganised)
                                                    //     .ThenInclude(y => y.TMatches)
                                                    //         .ThenInclude(z => z.Club1)
                                                    // .Include(x=>x.TournirOrganised)
                                                    //     .ThenInclude(y => y.TMatches)
                                                    //         .ThenInclude(z => z.Club2)            
                                                    // .Include(p=>p.TournirOrganised)
                                                    //     .ThenInclude(p=>p.Clubs)
                                                    //         .ThenInclude(p=>p.Trainer)
                                                    .FirstAsync();
            
            //Console.WriteLine(org.AdminsCreated.Count);
            /*
            var org=(Organisator)Context.Organisators.Where(pom=>pom.Username==user)
                                .Include(p=>p.AdminsCreated)
                                .Include(p=>p.TournirOrganised).ToList().Last();
            */
            
            //Console.WriteLine(org.AdminsCreated.Count);
            return org;
            }catch(Exception){
                //Console.WriteLine("caoo1");
                return new Organisator();
            }


            //return org;
        }
        #endregion

        #region Club

        [Route("insertClub")]
        [HttpPost]
        public async Task<bool> insertClub([FromBody]Club c){

            Console.WriteLine(c.ClubName);

            var clubs=Context.Clubs.ToList();
            Console.WriteLine(c.ClubName);

            if(clubs.Contains(c))
                return false;

            Club tmp = clubs.Where(p => p.ClubName == c.ClubName).FirstOrDefault();
            if(tmp != null)
                return false;

            Console.WriteLine(c.ClubName);
            Context.Clubs.Add(c);
            Console.WriteLine(c.ClubName);
            await Context.SaveChangesAsync();

            return true;
        }

        [Route("updateClub/{cName}")]
        [HttpPut]
        public async Task<IActionResult> updateClub([FromRoute] string cName, [FromBody]Club c){
            Club clubs = Context.Clubs.Where(p => p.ClubName == cName).Include(p => p.Players).ThenInclude(q => q.PlayerStatistics).Include(q => q.Trainer).Include(t => t.TournirsPlayingIn).First();
            
            if(c.ClubName != cName){
                List<Club> newClub = Context.Clubs.Where(p => p.ClubName == c.ClubName).ToList();
                if(newClub.Any())
                    return StatusCode(404);
            }
            
            
            Console.WriteLine(cName);
            Console.WriteLine(c.ClubName);
            if(clubs == null)
                return StatusCode(404);
            Console.WriteLine(clubs.ClubName);
            clubs.ClubName = c.ClubName;
            bool flag = false;
            int counter = 0;
            List<Player> tmpList = new List<Player>();
            foreach (Player player in clubs.Players)
            {
                List<Player> pl = c.Players.Where(p => p.PersonName == player.PersonName &&
                                            p.Surname == player.Surname &&
                                            p.Num == player.Num && p.Captain == player.Captain).ToList();                               
                if(!pl.Any()){
                    flag = true;
                    Console.WriteLine("Brisem igraca");
                    Console.WriteLine(player.PersonName);


                    player.PlayerStatistics.Clear();
                    tmpList.Add(player);
                    //Context.Players.Remove(player);
                }
            }
            //counter = tmpList.Count;
            if(flag)
                foreach (Player player in c.Players){
                        List<Player> pl = clubs.Players.Where(p => p.PersonName == player.PersonName &&
                                                                    p.Surname == player.Surname &&
                                                                    p.Num == player.Num && p.Captain == player.Captain).ToList();                              
                        if(!pl.Any()){
                                //clubs.Players.Add(player);
                                Console.WriteLine(counter);

                                if(tmpList[counter].PlayerStatistics.Any()){
                                    foreach (var item in tmpList[counter].PlayerStatistics)
                                    {
                                        item.PlayerStat = tmpList[counter];
                                        item.Cards = 0;
                                        item.Goals = 0;
                                    }
                                }
                                else
                                        tmpList[counter].PlayerStatistics = new List<PlayerStatistic>();
                                
                                tmpList[counter].PersonName = player.PersonName;         
                                tmpList[counter].Surname = player.Surname;         
                                tmpList[counter].Position = player.Position;         
                                tmpList[counter].Num = player.Num;         
                                tmpList[counter].Captain = player.Captain;
                        counter++;

                        }
                }                                 
            Console.WriteLine(c.Trainer.PersonName);
            Console.WriteLine(c.Trainer.Surname);

            Console.WriteLine(clubs.Trainer.PersonName);
            Console.WriteLine(clubs.Trainer.Surname);

            clubs.Trainer.PersonName = c.Trainer.PersonName;
            clubs.Trainer.Surname = c.Trainer.Surname;
            Context.Update(clubs);
            await Context.SaveChangesAsync();

            return Ok(200);
        }

        [Route("deleteClub")]
        [HttpPost]
        public async Task<IActionResult> deleteClub([FromBody]Club c){
            List<Tournir> tournirs=Context.Tournirs.Where(x=>x.Clubs.Contains(c)).Include(x => x.TMatches).ToList();
            //List<Player> players=Context.Players.Where(p=>p.ClubPlayingFor.ClubName==c.ClubName).ToList();

            
            var club = Context.Clubs.Where(x => x.ClubName == c.ClubName).Include(q=>q.Trainer).Include(q => q.EveryClubStatistics).ToList().First();
            List<Player> players=Context.Players.Where(p=>p.ClubPlayingFor == club).Include(q => q.PlayerStatistics).ToList();

            var trainer = club.Trainer;
            foreach (var item in tournirs)
            {
                if(item.TMatches.Any())
                    return StatusCode(404);
            }

            foreach(Player p in players){
                if(p.PlayerStatistics.Any()){

                    Console.WriteLine("statistike player");
                    foreach (PlayerStatistic tmpP in p.PlayerStatistics)
                    {
                        Context.PlayerStatistics.Remove(tmpP);
                    }
                    //Context.PlayerStatistics.Remove(Context.PlayerStatistics.Where(q => q.PlayerStat.IDperson == p.IDperson).First());
                }
                
                
                Context.Players.Remove(p);
            }
             if(club.EveryClubStatistics.Any()){
                 Console.WriteLine("statistike club");
                foreach (ClubStatistic tmpC in club.EveryClubStatistics)
                {
                    Context.ClubStatistics.Remove(tmpC);
                }
            }
            Context.Trainers.Remove(trainer);
            Context.Clubs.Remove(club);
            await Context.SaveChangesAsync();
            return Ok();
        }

        [Route("assignClub")]
        [HttpPost]
        public async Task assignClub([FromBody]JObject data){
            var club=data["Club"].ToObject<Club>();
            var tournir=data["Event"].ToObject<Tournir>();

            var t=Context.Tournirs.Where(x=>x.TournirName==tournir.TournirName).First();
            t.Clubs.Add(club);

            await Context.SaveChangesAsync();
        }

        [Route("returnClubs")]
        [HttpGet]
        public async Task<List<Club>> returnClubs(){
            return await Context.Clubs.Include(p=>p.Players).Include(q => q.Trainer).ToListAsync();
        }
        #endregion

        #region Tournir

        [Route("insertTournirMatches")]
        [HttpPut]
        public async Task insertTournirMatches([FromBody]Tournir t){
            Tournir tr=Context.Tournirs.Where(x=>x.TournirName==t.TournirName).First();

            tr.NumOfTeamsPerGroup = t.NumOfTeamsPerGroup;
           tr.WinnersPerGroup = t.WinnersPerGroup;
            Club club1 = null;
            Club club2 = null;
            tr.Form = t.Form;
            tr.TMatches = new List<TMatch>(); 
            foreach(TMatch m in t.TMatches){
                    if(m.Winner != null)
                        continue;

                Console.WriteLine("USAO SAM U FOREACH");
               if(m.Club1 != null && m.Club2 != null){
                    club1 = Context.Clubs.Where(x => x.ClubName == m.Club1.ClubName).First();
                    club2 =  Context.Clubs.Where(x => x.ClubName == m.Club2.ClubName).First();
               }
                m.Club1 = club1;
                m.Club2 = club2;
                tr.TMatches.Add(m);
            
            }
            await Context.SaveChangesAsync();
        }

        [Route("updateTournir")]
        [HttpPut]
        public async Task updateTournir([FromBody]Tournir t){
            Tournir tr=Context.Tournirs.Where(x=>x.TournirName==t.TournirName).First();

            tr.TournirWinner = t.TournirWinner;            
            await Context.SaveChangesAsync();
        }

        [Route("insertTournir/{organizerName}")]
        [HttpPost]
        public async Task<bool> insertTournir([FromRoute] string organizerName, [FromBody] Tournir t){            
            
            Console.WriteLine("UPISUJEM TURNIR U BAZU");

            //using (StreamReader reader = new StreamReader(request.Body, encoding))
            //Console.WriteLine(reader.ReadToEndAsync().ToString());

            List<Tournir> tournirs=Context.Tournirs.Where(x=>x.TournirName==t.TournirName).ToList();

            //Organisator org = Context.Organisators.Where(x => x.Username == organizerName).First();
            if(tournirs.Any())
                return false;
            Console.WriteLine("Prosao sam proveru");
            Organisator organisator=Context.Organisators.Where(x=>x.Username==organizerName).First();
            t.TournirOrganisator=organisator;
            Console.WriteLine("Setovao sam organizatora:");
            Console.WriteLine(t.TournirOrganisator.PersonName);

            List<Club> tmpClubs=new List<Club>();
            foreach (Club c in t.Clubs)
            {
                Console.WriteLine("Prolazim listu:");
                Console.WriteLine(c.ClubName);
                tmpClubs.Add(Context.Clubs.Where(p=>p.ClubName==c.ClubName).Include(p=>p.Players).First());//tmpClubs.Add(Context.Clubs.Where(x=>x.ClubName==c.ClubName).Include(p => p.Players).First());
            }
                Console.WriteLine("tmpClubs duzina:");
                Console.WriteLine(tmpClubs.Count);

            // Console.WriteLine(t.Clubs.Count);
            t.Clubs.Clear();
            // Console.WriteLine(t.Clubs.Count);
            // t.Clubs = new List<Club>();
                Console.WriteLine("tmpClubs duzina:");
                Console.WriteLine(t.Clubs.Count);
            foreach (Club c in tmpClubs)
            {
                ClubStatistic cs=new ClubStatistic();
                cs.TournirStatC=t;
                c.EveryClubStatistics = new List<ClubStatistic>();
                c.EveryClubStatistics.Add(cs);
                
                t.Clubs.Add(c);


                foreach (Player p in c.Players)
                {
                    PlayerStatistic ps=new PlayerStatistic();
                    ps.TournirStatP=t;
                    p.PlayerStatistics = new List<PlayerStatistic>();
                    p.PlayerStatistics.Add(ps);
                }
            }

            Context.Tournirs.Add(t);
            await Context.SaveChangesAsync();
            
            return true;
        }

        [Route("returnTournir/{tName}")]
        [EnableCors("CORS")]
        [HttpGet]
        public async Task<Tournir> returnTournir([FromRoute] string tName){
            return await Context.Tournirs.Where(p=>p.TournirName==tName)
                          .Include(p=>p.TMatches)
                            .ThenInclude(p=>p.Club1)
                          .Include(p=>p.TMatches)
                            .ThenInclude(p=>p.Club2)
                          .Include(p=>p.TMatches)
                            .ThenInclude(p=>p.Refereee)
                          .Include(p=>p.Clubs)
                            .ThenInclude(p=>p.Players)
                          .Include(p=>p.Clubs)
                            .ThenInclude(p=>p.Trainer)
                          .Include(p=>p.ClubsStatistics)
                            .ThenInclude(p=>p.ClubStat)
                          .Include(p=>p.PlayerStatistics)
                            .ThenInclude(p => p.PlayerStat)
                        .FirstAsync();
        }

        [Route("returnTournirs")]
        [EnableCors("CORS")]
        [HttpGet]
        public async Task<List<Tournir>> returnTournirs(){
            return await Context.Tournirs.AsNoTracking()
                          .Include(p=>p.TMatches)
                            .ThenInclude(p=>p.Club1)
                          .Include(p=>p.TMatches)
                            .ThenInclude(p=>p.Club2)
                          .Include(p=>p.Clubs)
                            .ThenInclude(p=>p.Players)
                          /*.Include(p=>p.ClubsStatistics)
                            .ThenInclude(p=>p.ClubStat)
                          .Include(p=>p.PlayerStatistics)
                            .ThenInclude(p => p.PlayerStat)*/
                        .ToListAsync();
        }

        [Route("returnTournirsPom")]
        [EnableCors("CORS")]
        [HttpGet]
        public async Task<List<Tournir>> returnTournirsPom(){
            return await Context.Tournirs.AsNoTracking().ToListAsync();
        }

        [Route("deleteTournir")]
        [HttpPost]
        public async Task<bool> deleteTournir([FromBody]Tournir t){
            if(t.TournirDate>DateTime.Now)
                return false;

            Context.Tournirs.Remove(t);
            await Context.SaveChangesAsync();

            return true;
        }
        #endregion

        #region Match
        [Route("insertMatch")]
        [HttpPost]
        public async Task insertMatch([FromBody]Tournir t){
            var trn=Context.Tournirs.Where(p=>p.TournirName==t.TournirName).OrderBy(p=>p.TournirName).Last();
            TMatch tm = t.TMatches.Where((p) => trn.TMatches.IndexOf(p)==-1).LastOrDefault();

            trn.TMatches.Add(tm);
            Context.Tmatches.Add(tm);
            await Context.SaveChangesAsync();
        }

        [Route("assignClubMatch")]
        [HttpPut]
        public async Task assignClubMatch([FromBody]TMatch m){
            var match=Context.Tmatches.Where(x=>x.IDmatch==m.IDmatch).First();

            if(m.Club1 != null && match.Club1 == null)
                match.Club1 = Context.Clubs.Where(p=>p.ClubName==m.Club1.ClubName).First();
            
            if( m.Club2 != null &&  match.Club2 == null)
                match.Club2=Context.Clubs.Where(p=>p.ClubName==m.Club2.ClubName).First();

            await Context.SaveChangesAsync();
        }

        [Route("onoffMatch/{x}")]
        [HttpPut]
        public async Task onoffMatch([FromRoute]string x){
            var match=Context.Tmatches.Where(x=>x.IDmatch==Convert.ToInt32(x)).First();

            match.Live=!match.Live;

            await Context.SaveChangesAsync();
        }

        [Route("insertMatchesFirst")]
        [HttpPost]
        public async Task<List<TMatch>> insertMatchesFirst([FromBody]Tournir t){
            var tournir=Context.Tournirs.Where(x=>x.TournirName==t.TournirName).First();

            foreach(TMatch m in t.TMatches){
                m.Club1=Context.Clubs.Where(x=>x.ClubName==m.Club1.ClubName).First();
                m.Club2=Context.Clubs.Where(x=>x.ClubName==m.Club2.ClubName).First();
                tournir.TMatches.Add(m);
            }

            await Context.SaveChangesAsync();

            return Context.Tmatches.Where(x=>x.TournirM==tournir && x.MatchPhase=="group").ToList();
        }

        [Route("insertMatchesSecond")]
        [HttpPost]
        public async Task<List<TMatch>> insertMatchesSecond([FromBody]Tournir t){
            var tournir=Context.Tournirs.Where(x=>x.TournirName==t.TournirName).First();
            List<TMatch> matchess=t.TMatches.Where(x=>x.MatchPhase!="group").ToList();

            foreach(TMatch m in matchess){
                m.Club1=Context.Clubs.Where(x=>x.ClubName==m.Club1.ClubName).First();
                m.Club2=Context.Clubs.Where(x=>x.ClubName==m.Club2.ClubName).First();
                tournir.TMatches.Add(m);
            }

            await Context.SaveChangesAsync();

            return Context.Tmatches.Where(x=>x.TournirM==tournir && x.MatchPhase!="group").ToList();
        }

        [Route("returnMatches/{tn}")]
        [HttpPost]
        public async Task<List<TMatch>> returnMatches([FromRoute] string tn){
            List<TMatch> matches= await Context.Tmatches.Where(x=>x.TournirM.TournirName==tn)
                                                 .Include(x=>x.Club1)
                                                 .Include(x=>x.Club2).ToListAsync();

            return matches;
        }

        [Route("returnLiveMatches")]
        [HttpGet]
        public async Task<List<TMatch>> returnLiveMatches(){
            return await Context.Tmatches.Where(p=>p.Live==true)
                                   .Include(x=>x.Club1)
                                   .Include(x=>x.Club2).ToListAsync();
        }

        [Route("returnMatchesDraw/{tn}")]
        [HttpGet]
        public async Task<List<TMatch>> returnMatchesDraw([FromRoute] string tn){
            List<TMatch> matches= await Context.Tmatches.Where(x=>x.TournirM.TournirName==tn
                                                                && x.MatchPhase=="draw").ToListAsync();

            return matches;
        }

        [Route("updateMatch")]
        [HttpPut]
        public async Task updateMatch([FromBody] TMatch m){
            var match=Context.Tmatches.Where(x=>x.IDmatch==m.IDmatch).First();
            
            if(m.Winner!=null){
                var club=Context.Clubs.Where(x=>x.ClubName==m.Winner.ClubName).First();
                match.Winner=club;
            }
            if(m.Refereee != null){
                Console.WriteLine(m.Refereee.PersonName);
                var referee = Context.Referees.Where(x=>x.PersonName == m.Refereee.PersonName && x.Surname == m.Refereee.Surname && x.Quality == m.Refereee.Quality).First();
                Console.WriteLine(referee.PersonName);
                match.Refereee=referee;
            }

            match.HomeGoals=m.HomeGoals;
            match.MatchDate=m.MatchDate;
            match.AwayGoals=m.AwayGoals;
            match.Live=m.Live;
            match.MatchDate=m.MatchDate;

            await Context.SaveChangesAsync();

           // await hub.updateMatch(match);
        }
        #endregion

        #region Statistic
        [Route("updateClubStat")]
        [HttpPut]
        public async Task updateClubStat([FromBody]ClubStatistic cs){
            var stat=Context.ClubStatistics.Where(p=>p.IDcstatistic == cs.IDcstatistic).First();

            stat.GoalsDifference = cs.GoalsDifference;
            stat.Draws=cs.Draws;
            stat.Loses=cs.Loses;
            stat.Wins=cs.Wins;

            await Context.SaveChangesAsync();
        }

        [Route("updatePlayerStat")]
        [HttpPut]
        public async Task updateClubStat([FromBody]PlayerStatistic ps){
            var stat=Context.PlayerStatistics.Where(p=>p.IDpstatistic == ps.IDpstatistic).First();

            stat.Cards=ps.Cards;
            stat.Goals=ps.Goals;

            await Context.SaveChangesAsync();
        }

        [Route("returnClubStat/{tname}")]
        [HttpGet]
        public async Task<List<ClubStatistic>> returnClubStat([FromRoute]string tname){
            return await Context.ClubStatistics.Where(x=>x.TournirStatC.TournirName==tname)
                                         .Include(x=>x.ClubStat).ToListAsync();
        }

        [Route("returnPlayerStat/{tname}")]
        [EnableCors("CORS")]
        [HttpGet]
        public async Task<List<PlayerStatistic>> returnPlayerStat([FromRoute]string tname){
            Console.WriteLine(tname);
            var ps=await Context.PlayerStatistics.Where(x=>x.TournirStatP.TournirName==tname).AsNoTracking()
                                            .Include(x=>x.PlayerStat)
                                                .ThenInclude(x=>x.ClubPlayingFor)
                                            .ToListAsync();
            Console.WriteLine(ps.Count);
            return ps;
        }
        #endregion

    }
}