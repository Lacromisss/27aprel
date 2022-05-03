using System;
using System.Collections.Generic;
using System.Text;

namespace _3aprelTask
{
    internal class MeetingSchedule
    {
        private List<Meeting> _meetings;
        public MeetingSchedule()
        {
            _meetings = new List<Meeting>();
        }
        public List<Meeting> Meetings
        {
            get => _meetings;
        }
        public void SetMeeting(string name, DateTime fromDate, DateTime toDate)
        {
            if (fromDate < toDate)
            {
                Meeting meeting = new Meeting();
                meeting.Name = name;
                meeting.FromDate = fromDate;
                meeting.ToDate = toDate;
                if (_meetings.Count == 0)
                {
                    _meetings.Add(meeting);
                }
                else
                {
                    bool isTrue = false;
                    foreach (Meeting meet in _meetings)
                    {
                        if (fromDate >= meet.ToDate || toDate <= meet.FromDate)
                        {
                            isTrue = true;
                        }
                        else
                        {
                            throw new Exception("Bu zaman intervalinda meeting var !");
                        }
                    }
                    if (isTrue)
                        _meetings.Add(meeting);
                }
            } else
            {
                throw new Exception("Ilk once fromDate daxil edin. Sonra toDate!!");
            }
            
        }
        
        public int FindMeetingsCount(DateTime time)
        {
            if (time == null)
            {
                throw new Exception("Time null daxil etmek olmaz !");
            } else
            {
                int count = 0;
                foreach (Meeting meet in _meetings)
                {
                    if (time < meet.FromDate)
                    {
                        count++;
                    }
                }
                return count;
            }
            
        }
        public bool IsExistsMeetingByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Null parametr daxil etmek olmaz !");
            else
            {
                foreach (Meeting meet in _meetings)
                {
                    if (meet.Name.Contains(name))
                        return true;
                }
                return false;
            }
            
        }
        public List<Meeting> GetExistMeetings(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new Exception("Null parametr daxil etmek olmaz !");
            else
            {
                List<Meeting> newMeetingList = new List<Meeting>();
                foreach (Meeting meet in _meetings)
                {
                    if (meet.Name.Contains(name))
                        newMeetingList.Add(meet);
                }
                return newMeetingList;
            }            
        }
    }
}


