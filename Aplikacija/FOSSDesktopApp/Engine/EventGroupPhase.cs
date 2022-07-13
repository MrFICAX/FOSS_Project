using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FOSSDesktopApp.Engine
{
    class EventGroupPhase
    {
        #region Attributes
        private List<List<Team>> groupes;
        private int groupSize;
        private int[,] teamPointsMatrix;
        private int winnerTeamsPerGroup;
        public Competition activeCompetition;

        #endregion

        #region Constructors

        public EventGroupPhase(int groupSize, int groupNum, int winnerTeamsPerGroup, Competition comp)
        {
            this.activeCompetition = comp;
            this.groupSize = groupSize;
            this.WinnerTeamsPerGroup = winnerTeamsPerGroup;
            groupes = new List<List<Team>>(groupNum);

            for(int i = 0; i < groupNum; i++)
            {
                groupes.Add(new List<Team>(groupSize));
                //groupes[i] = new List<Team>(groupSize);
            }

            teamPointsMatrix = new int[groupNum, groupSize];
            for (int i = 0; i < groupNum; i++)
                for (int j = 0; j < groupSize; j++)
                    teamPointsMatrix[i, j] = 0;
        }

        public EventGroupPhase(Competition comp)
        {
            this.activeCompetition = comp;


        }

        #endregion

        #region Methods
        public void AddTeam(Team team)
        {
            for(int i=0;i<groupes.Capacity;i++)
            {
                if (groupes[i].Count == groupSize)
                    continue;

                groupes[i].Add(team);
                break;
            }
        }

        public void AddPoints(Team team)
        {
            //int groupNum=0;
            //int index=0;
            //foreach (var group in groupes)
            //{
            //    if (group.Find(p => p.ClubName == team.ClubName) != null)
            //    {
            //        index = group.IndexOf(group.Find(p => p.ClubName == team.ClubName));
            //        break;
            //    }
            //    groupNum++;
            //}

            //teamPointsMatrix[groupNum, index]++;
        }

        public void loadPointsfromStatistics(TeamStatistics stat)
        {
            int groupNum = 0;
            int index = 0;
            foreach (var group in groupes)
            {
                if (group.Contains(stat.ClubStat))
                {
                    index = group.IndexOf(stat.ClubStat);
                    break;
                }
                groupNum++;
            }

            teamPointsMatrix[groupNum, index] = stat.Wins;
       }


        public void Eliminate(int groupNum)
        {
            if (groupes[groupNum].Count == 2)
                return;

            int min = teamPointsMatrix[groupNum, 0];
            Team teamForElimination=groupes[groupNum][0];
            int minIndex = 0;
            for(int i = 0; i < groupSize-1; i++)
            {
                if(teamPointsMatrix[groupNum, i] < min)
                {
                    min = teamPointsMatrix[groupNum, i];
                    teamForElimination = groupes[groupNum][i];
                    minIndex = i;
                }
            }

            groupes[groupNum].Remove(teamForElimination);
            removeTeamPointsFromMatrix(groupNum, minIndex);
        }

        public void updateTeamStatistics(TeamStatistics teamS)
        {
            int g = 0, p = 0;
            for(int i=0;i<groupes.Capacity;i++)
                for(int j=0;j<groupSize;j++)
                    if (groupes[i][j].ClubName == teamS.ClubStat.ClubName)
                    {
                        g = i;
                        p = j;
                    }
            teamS.Wins = teamPointsMatrix[g, p];
        }

        public List<Team> FinishGroupePhase()
        {
            List<Team> winnerTeams = new List<Team>(groupes.Capacity*2);

        //    int grpNum = 0;
        //    foreach(var grp in groupes)
        //    {
        //        for (int i = 0; i < groupSize - winnerTeamsPerGroup; i++)
        //            Eliminate(grpNum);
        //        grpNum++;
        //    }
            foreach (var group in groupes)
            {
        //        if (groupes.Count > this.winnerTeamsPerGroup)
        //            return null;

                List<TeamStatistics> ts = new List<TeamStatistics>();
                List<TeamStatistics> tmpStat = this.activeCompetition.TeamStatistics;

                foreach (var item in group)
                {                    
                    TeamStatistics tsScore = tmpStat[tmpStat.IndexOf(tmpStat.Where((t) => t.ClubStat.ClubName == item.ClubName).FirstOrDefault())];
                    ts.Add(tsScore);
                }

                ts = ts.OrderByDescending(p => p.Wins).ThenByDescending(q => q.GoalsDifference).ToList();



                for (int i = 0; i < this.winnerTeamsPerGroup; i++)
                {
                    winnerTeams.Add(ts[i].ClubStat);
                }
            }

            return winnerTeams;
        }

        //funkcija koja izbacuje broj bodova tima koji je eliminisan iz matrice bodova
        private void removeTeamPointsFromMatrix(int groupNum, int index)
        {
            for(int i = index; i< groupSize-1; i++)
            {
                teamPointsMatrix[groupNum, i] = teamPointsMatrix[groupNum, i + 1];
            }
            teamPointsMatrix[groupNum, groupSize-1] = 0;
        }

        public List<Match> GenerateMatches()
        {
            List<Match> matches = new List<Match>((groupSize * (groupSize - 1) / 2) * groupes.Capacity);
            int index;
            foreach(var group in groupes)
            {
                for (int i = 0; i < groupSize; i++)
                    for (int j = i + 1; j < groupSize; j++)
                    {
                        var match = new Match();
                        match.Date = this.activeCompetition.StartDate;
                        match.Teams[0] = group[i];
                        match.Teams[1] = group[j];
                        match.Level = "group";
                        index = groupes.FindIndex(groupes => groupes.Contains(match.Teams[0]));
                        match.SpecificNumber = (index + 1).ToString() + ". grupa";
                        matches.Add(match);
                    }
            }

            return matches;
        }
        #endregion
        #region Properties

        public List<List<Team>> Groupes
        {
            get { return this.groupes; }
        }

        public int WinnerTeamsPerGroup { 
            get => winnerTeamsPerGroup; 
            set 
            { 
                if(value<=this.groupSize/2)
                 winnerTeamsPerGroup = value; 
            }
        }

        #endregion
    }
}
