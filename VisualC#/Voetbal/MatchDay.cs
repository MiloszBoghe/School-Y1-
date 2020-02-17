using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer
{

    public class MatchDay
    {
        private int _dayNumber;
        private List<Team> _teamsList1;
        private List<Team> _teamsList2;
        private List<int> _scoresList1;
        private List<int> _scoresList2;
        private DateTime _date;

        public MatchDay(List<Team> team1, List<Team> team2, int day)
        {
            TeamsList1 = team1;
            TeamsList2 = team2;
            DayNumber = day;
            Date = new DateTime(DateTime.Now.Year, 7, 31);
            Date = Date.AddDays(DayNumber * 7);
            ScoresList1 = new List<int>();
            ScoresList2 = new List<int>();
            for (int i = 0; i < 8; i++)
            {
                ScoresList1.Add(0);
                ScoresList2.Add(0);
            }
            while (Date.DayOfWeek != DayOfWeek.Saturday)
            {
                Date = Date.AddDays(-1);
            }


        }

        public override string ToString()
        {
            string format = Date.ToString("dd/MM/yyyy");
            return $"Match day {_dayNumber + 1}: {format}";
        }

        public int DayNumber { get => _dayNumber; set => _dayNumber = value; }
        public List<Team> TeamsList1 { get => _teamsList1; set => _teamsList1 = value; }
        public List<Team> TeamsList2 { get => _teamsList2; set => _teamsList2 = value; }
        public List<int> ScoresList1 { get => _scoresList1; set => _scoresList1 = value; }
        public List<int> ScoresList2 { get => _scoresList2; set => _scoresList2 = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
