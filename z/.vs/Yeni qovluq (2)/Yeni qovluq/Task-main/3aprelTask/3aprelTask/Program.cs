using System;

namespace _3aprelTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeetingSchedule meetingSchedule = new MeetingSchedule();
            try
            {
                meetingSchedule.SetMeeting("Rektor ile gorus", new DateTime(2022, 04, 3, 12, 00, 00), new DateTime(2022, 04, 3, 13, 00, 00));
                meetingSchedule.SetMeeting("Dekan ile gorus", new DateTime(2022, 04, 3, 11, 00, 00), new DateTime(2022, 04, 3, 12, 00, 00));
                meetingSchedule.SetMeeting("1-1 Meeting", new DateTime(2022, 04, 3, 15, 00, 00), new DateTime(2022, 04, 3, 18, 00, 00));
                meetingSchedule.SetMeeting("1-10 Meeting", new DateTime(2022, 04, 3, 14, 00, 00), new DateTime(2022, 04, 3, 16, 00, 00));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            foreach (Meeting meet in meetingSchedule.Meetings)
            {
                Console.WriteLine(meet.Name);
            }
        }
    }
}
